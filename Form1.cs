using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JukeBoxv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
         Setup Lists = new Setup();
        List<string> JukeboxTracks = new List<string>();

        List<string> GenreList = File.ReadAllLines("GenreTitles.txt").ToList();
        List<string> TrackList = File.ReadAllLines("Songs.txt").ToList();

        int NumberOfGenres = 0;
        int NumberOfTracks = 0;

        string SaveToFile = Directory.GetCurrentDirectory();


        bool IsJukeboxPlaying;

        private void GenreTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrackListListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            WaitingToPlayListbox.Items.Add(TrackListListbox.SelectedItem);

        }

        private void HScrollBar_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void NowPlayingTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void WaitingToPlayListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetupFormOpenButton_Click(object sender, EventArgs e)
        {
            Setup GoToSetup = new Setup();
            GoToSetup.Show();
        }

        private void AboutFormButton_Click(object sender, EventArgs e)
        {
            About GoToAbout = new About();
            GoToAbout.Show();
        }

        private void LoadTracks_Tick(object sender, EventArgs e)
        {
            
         
        }

        private void MoveToNowPlaying_Tick(object sender, EventArgs e)
        {
            if (GenreTextbox.Text == "")
            {

                if (WaitingToPlayListbox.Items.Count > 0)
                {
                    string MovetoPlaying = WaitingToPlayListbox.Items[0].ToString();
                    NowPlayingTextbox.Text = MovetoPlaying;
                    MoveToNowPlaying.Start();                    
                    WaitingToPlayListbox.Items.RemoveAt(0);
                }
            }
            if (IsJukeboxPlaying == false)
            {
                WMPLib.WindowsMediaPlayer PlayMusic = new WMPLib.WindowsMediaPlayer();
                PlayMusic.URL = (SaveToFile + "Tracks" + GenreTextbox.Text);
                PlayMusic.controls.play();
                IsJukeboxPlaying = true;
                MoveToNowPlaying.Stop();
            }
            
        }

        private void WMPPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void AddDataBtn_Click(object sender, EventArgs e)
        {
            GenreTextbox.Text = GenreList[NumberOfGenres];
            TrackListListbox.Items.Clear();
            TrackListListbox.Items.Add(TrackList[NumberOfTracks]);
            WMPLib.WindowsMediaPlayer PlayMusic = new WMPLib.WindowsMediaPlayer();
            PlayMusic.URL = (SaveToFile + "Tracks" + GenreTextbox.Text);
            PlayMusic.controls.play();
        }
    }
}
