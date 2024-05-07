using System;
using System.Windows.Forms;
using System.Threading;
using WMPLib;
using System.Threading.Tasks;

namespace music_player
{
    public partial class UCHome : UserControl
    {
        public static UCHome ucHome;

        public UCHome()
        {
            InitializeComponent();
            ucHome = this;
        }

        public static int playbackState = -1;

        // Play ---------------------------------------------------------------
        private void picPlayEmerge()
        {
            picPlay.Visible = true;
        }
        public void picPlayDisappear() {
            picPlay.Visible = false;
        }
        private void picPlay_Click(object sender, EventArgs e)
        {
            picPlayDisappear();
            picPauseEmerge();
            switch (UCPlaylist.option)
            {
                case 0:
                    Form1.wmp.Ctlcontrols.play();
                    break;
                case 1:
                    playbackState = 1;
                    break;
            }
        }
        private void picPlay_MouseEnter(object sender, EventArgs e)
        {
            picPlay.Width += 4;
            picPlay.Height += 4;
            picPlay.Left -= 2;
            picPlay.Top -= 2;
        }
        private void picPlay_MouseLeave(object sender, EventArgs e)
        {
            picPlay.Width -= 4;
            picPlay.Height -= 4;
            picPlay.Left += 2;
            picPlay.Top += 2;
        }

        // Pause ---------------------------------------------------------------
        public void picPauseEmerge()
        {
            picPause.Visible = true;
        }
        public void picPauseDisappear() { 
            picPause.Visible = false; 
        }
        private void picPause_Click(object sender, EventArgs e)
        {
            switch (UCPlaylist.option) {
                case 0:
                    if (Form1.wmp.playState == WMPPlayState.wmppsStopped) return;
                    break;
                case 1:
                    if (playbackState == -1) return;
                    break;
            }
            picPauseDisappear();
            picPlayEmerge();
            switch (UCPlaylist.option) {
                case 0:
                    Form1.wmp.Ctlcontrols.pause();
                    break;
                case 1:
                    playbackState = 0;
                    break;
            }
        }
        private void picPause_MouseLeave(object sender, EventArgs e)
        {
            picPause.Width -= 4;
            picPause.Height -= 4;
            picPause.Left += 2;
            picPause.Top += 2;
        }
        private void picPause_MouseEnter(object sender, EventArgs e)
        {
            picPause.Width += 4;
            picPause.Height += 4;
            picPause.Left -= 2;
            picPause.Top -= 2;
        }

        // Previous ---------------------------------------------------------------
        private void clickPrevious() {
            clickPicStop();
            UCPlaylist.ucPlayList.smusicList.SelectedIndices.Clear();
            --UCPlaylist.curIndex;
            if (UCPlaylist.curIndex < 0)
            {
                UCPlaylist.curIndex = UCPlaylist.ucPlayList.smusicList.Items.Count-1;
            }
            UCPlaylist.ucPlayList.smusicList.SelectedIndices.Add(UCPlaylist.curIndex);
        }
        private void picPrevious_Click(object sender, EventArgs e)
        {
            switch (UCPlaylist.option)
            {
                case 0:
                    if (Form1.wmp.playState == WMPPlayState.wmppsStopped) return;
                    break;
                case 1:
                    if (playbackState == -1) return;
                    break;
            }
            isStoppedManually = false;
            isNextManually = true;
            clickPrevious();
        }
        private void picPrevious_MouseEnter(object sender, EventArgs e)
        {
            picPrevious.Width += 4;
            picPrevious.Height += 4;
            picPrevious.Left -= 2;
            picPrevious.Top -= 2;
        }
        private void picPrevious_MouseLeave(object sender, EventArgs e)
        {
            picPrevious.Width -= 4;
            picPrevious.Height -= 4;
            picPrevious.Left += 2;
            picPrevious.Top += 2;
        }

        // Next ---------------------------------------------------------------
        public static bool isNextManually = false;
        public void clickNext() {
            clickPicStop();
            UCPlaylist.ucPlayList.smusicList.SelectedIndices.Clear();
            ++UCPlaylist.curIndex;
            if (UCPlaylist.curIndex >= UCPlaylist.ucPlayList.smusicList.Items.Count) {
                UCPlaylist.curIndex = 0;
            }
            UCPlaylist.ucPlayList.smusicList.SelectedIndices.Add(UCPlaylist.curIndex);
        }
        private void picNext_Click(object sender, EventArgs e)
        {
            switch (UCPlaylist.option)
            {
                case 0:
                    if (Form1.wmp.playState == WMPPlayState.wmppsStopped) return;
                    break;
                case 1:
                    if (playbackState == -1) return;
                    break;
            }
            isStoppedManually = false;
            isNextManually = true;
            clickNext();
        }
        private void picNext_MouseEnter(object sender, EventArgs e)
        {
            picNext.Width += 4;
            picNext.Height += 4;
            picNext.Left -= 2;
            picNext.Top -= 2;
        }
        private void picNext_MouseLeave(object sender, EventArgs e)
        {
            picNext.Width -= 4;
            picNext.Height -= 4;
            picNext.Left += 2;
            picNext.Top += 2;
        }

        // Stop ---------------------------------------------------------------
        public static bool isStoppedManually = false;
        public void clickPicStop() {
            picPlayDisappear();
            picPauseEmerge();
            labelSongName.Text = string.Empty;
            changeStateText(false);
            switch (UCPlaylist.option)
            {
                case 0:
                    Form1.wmp.Ctlcontrols.stop();
                    break;
                case 1:
                    playbackState = -1;
                    break;
            }
        }
        private void picStop_Click(object sender, EventArgs e)
        {
            isStoppedManually = true;
            UCPlaylist.ucPlayList.smusicList.SelectedIndices.Clear();
            clickPicStop();
        }

        private void picStop_MouseEnter(object sender, EventArgs e)
        {
            picStop.Width += 4;
            picStop.Height += 4;
            picStop.Left -= 2;
            picStop.Top -= 2;
        }

        private void picStop_MouseLeave(object sender, EventArgs e)
        {
            picStop.Width -= 4;
            picStop.Height -= 4;
            picStop.Left += 2;
            picStop.Top += 2;
        }

        // Change Current Song Name -----------------------------------------
        public void changeCurName(string song)
        {
            labelSongName.Text = song; 
        }

        // Change Playing State Text -----------------------------------------
        public void changeStateText(bool isPlaying)
        {
            if (isPlaying)
            {
                lablePlayingState.Text = "Be Playing : ";
            }
            else {
                lablePlayingState.Text = "No Playing ...";
            }
        }
    }
}
