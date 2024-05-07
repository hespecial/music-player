using NAudio.Vorbis;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace music_player
{
    public partial class UCPlaylist : UserControl
    {

        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        public static extern void SetWindowTheme(IntPtr hWnd, string appId, string classId);

        public static UCPlaylist ucPlayList;
        public System.Windows.Forms.ListView smusicList;

        public UCPlaylist()
        {
            InitializeComponent();
            SetWindowTheme(musicList.Handle, "Explorer", null);
            SetWindowTheme(musicList.Handle, "Explorer", null);
            ucPlayList = this;
            smusicList = musicList;
            //musicList.Columns.Add("#",50,HorizontalAlignment.Center);
            //musicList.Columns.Add("Song", 300, HorizontalAlignment.Center);
            //musicList.Columns.Add("Ext", 80, HorizontalAlignment.Center);
        }

        List<string> urlList = new List<string>();
        HashSet<string> musicSet = new HashSet<string>();

        private void OnPlaybackStopped(object sender, StoppedEventArgs e) {
            if (UCHome.isStoppedManually)
            {
                UCHome.isStoppedManually = false;
                musicList.SelectedIndices.Clear();
            }
            else {
                if (UCHome.isNextManually)
                {
                    UCHome.isNextManually = false;
                }
                else
                {
                    UCHome.ucHome.clickNext();
                }
            }
        }

        private async Task playOgg(string filePath) {
            using (VorbisWaveReader reader = new VorbisWaveReader(filePath))
            {
                using (WaveOutEvent outputDevice = new WaveOutEvent())
                {
                    outputDevice.PlaybackStopped += OnPlaybackStopped;
                    outputDevice.Init(reader);
                    while (true) {
                        switch (UCHome.playbackState) {
                            case -1:
                                outputDevice.Stop();
                                outputDevice.Dispose();
                                reader.Dispose();
                                return;
                            case 0:
                                outputDevice.Pause();
                                while (UCHome.playbackState == 0) { 
                                    await Task.Delay(10);
                                }
                                break;
                            case 1:
                                outputDevice.Play();
                                while (UCHome.playbackState == 1)
                                {
                                    await Task.Delay(10);
                                }
                                break;
                        }
                    }
                }
            }
        }

        private void playCommon(int selectIndex) {
            Form1.wmp.Ctlcontrols.stop();
            Thread.Sleep(100);
            Form1.wmp.URL = urlList[selectIndex];
        }

        private string getOggMusicDuration(string filePath)
        {
            using (VorbisWaveReader reader = new VorbisWaveReader(filePath))
            {
                TimeSpan duration = reader.TotalTime;
                int minutes = duration.Minutes;
                int seconds = duration.Seconds;
                string formattedSeconds = seconds.ToString("D2");
                return $"{minutes}:{formattedSeconds}";
            }
        }

        private string getCommonMusicDuration(string filePath)
        {
            using (AudioFileReader reader = new AudioFileReader(filePath))
            {
                TimeSpan duration = reader.TotalTime;
                int minutes = duration.Minutes;
                int seconds = duration.Seconds;
                string formattedSeconds = seconds.ToString("D2");
                return $"{minutes}:{formattedSeconds}";
            }
        }

        private async Task playMusic(string filePath,int selectIndex) { 
            string ext = Path.GetExtension(filePath);
            UCHome.playbackState = 1;
            switch (ext) {
                case ".ogg":
                    option = 1;
                    await playOgg(filePath);
                    break;
                default:
                    option = 0;
                    playCommon(selectIndex);
                    break;
            }
        }

        int cnt = 1;

        private void buttonAddMusic_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "Select Music File";
            ofd.Filter = "File Ext | *.mp3;*.avi;*.wav;*.flac;*.ogg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] nameList = ofd.FileNames;
                for (int i = 0; i < nameList.Length; i++)
                {
                    string url = nameList[i];
                    if (musicSet.Contains(url)) continue;
                    musicList.BeginUpdate();
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = "  " + (cnt++).ToString();
                    lvi.SubItems.Add(Path.GetFileNameWithoutExtension(url));
                    string ext = Path.GetExtension(url);
                    string duration;
                    switch (ext)
                    {
                        case ".ogg":
                            duration = getOggMusicDuration(url);
                            break;
                        default:
                            duration = getCommonMusicDuration(url);
                            break;
                    }
                    lvi.SubItems.Add(duration);
                    lvi.SubItems.Add(ext);
                    musicList.Items.Add(lvi);
                    musicList.EndUpdate();
                    urlList.Add(url);
                    musicSet.Add(url);
                }
            }
        }

        public static int option = 1;
        public static int curIndex;
        private  async void musicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (musicList.SelectedItems.Count>0) {
                UCHome.isNextManually = true;
                UCHome.ucHome.clickPicStop();
                await Task.Delay(100);
                UCHome.isNextManually = false;

                if (musicList.SelectedItems.Count == 0) {
                    await Task.Delay(100);
                    if(musicList.SelectedItems.Count == 0) return;
                }
                int selectIndex = musicList.SelectedItems[0].Index;
                curIndex = selectIndex;
                string filePath = urlList[selectIndex].ToString();

                UCHome.ucHome.changeCurName(Path.GetFileNameWithoutExtension(filePath));
                UCHome.ucHome.changeStateText(true);

                await playMusic(filePath, selectIndex);
            }
        }

        private void musicList_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            Color myColor = Color.FromArgb(246, 248, 250);
            Brush brush = new SolidBrush(myColor);
            e.Graphics.FillRectangle(brush, e.Bounds);
            e.DrawText();
        }

        private void musicList_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
