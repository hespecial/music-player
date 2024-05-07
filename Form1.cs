using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace music_player
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        [DllImport("Gdi32.dll",EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public static AxWMPLib.AxWindowsMediaPlayer wmp;

        UCHome ucHome = new UCHome
        {
            Dock = DockStyle.Fill
        };
        UCPlaylist ucPlaylist = new UCPlaylist()
        {
            Dock = DockStyle.Fill
        };

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            wmp = axWindowsMediaPlayer1;
            pnl_content.Controls.Add(ucHome);
            pnl_content.Controls.Add(ucPlaylist);
            clickHomeBtn();
        }
        
        // Home ---------------------------------------------------------------
        private void clickHomeBtn() {
            btn_home.BackColor = Color.FromArgb(213, 215, 218);
            btn_home.ForeColor = Color.Black;
            pnl_nav_home.Visible = true;
            
            ucHome.Visible = true;
        }
        private void leaveHomeBtn()
        {
            btn_home.BackColor = Color.FromArgb(237, 239, 243);
            btn_home.ForeColor = Color.Gray;
            pnl_nav_home.Visible = false;

            ucHome.Visible = false;
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            leavePlaylistBtn();
            clickHomeBtn();
        }

        // Playlist ---------------------------------------------------------------
        private void clickPlaylistBtn()
        {
            btn_playlist.BackColor = Color.FromArgb(213, 215, 218);
            btn_playlist.ForeColor = Color.Black;
            pnl_nav_palylist.Visible = true;

            ucPlaylist.Visible = true;
        }
        private void leavePlaylistBtn()
        {
            btn_playlist.BackColor = Color.FromArgb(237, 239, 243);
            btn_playlist.ForeColor = Color.Gray;
            pnl_nav_palylist.Visible = false;

            ucPlaylist.Visible = false;
        }
        private void btn_playlist_Click(object sender, EventArgs e)
        {
            leaveHomeBtn();
            clickPlaylistBtn();
        }

        // Close ---------------------------------------------------------------
        private async void btn_close_Click(object sender, EventArgs e)
        {
            UCHome.playbackState = -1;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            await Task.Delay(100);
            Environment.Exit(0);
        }

        // Minimize ---------------------------------------------------------------
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Move ---------------------------------------------------------------
        private void pnl_border_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        // Play ended ---------------------------------------------------------------
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                UCHome.ucHome.clickNext();
            }
        }
    }
}
