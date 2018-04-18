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
            MoveToNowPlaying.Start();
        }

        
        List<string> GenreList = File.ReadAllLines("GenreTitles.txt").ToList();
        List<string> TrackList = File.ReadAllLines("Songs.txt").ToList();

        int NumberOfGenres = 0;
        int NumberOfTracks = 0;

        string SaveToFile = Directory.GetCurrentDirectory() + "\\";

        bool IsJukeboxPlaying;


        private void GenreTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrackListListbox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (TrackListListbox.Items.Count <= 1)
            { 
                WaitingToPlayListbox.Items.Add(TrackListListbox.SelectedItem);
            MoveToNowPlaying.Start();
            }
            else
            {
                MessageBox.Show("Add more tracks");
            }
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
            if (NowPlayingTextbox.Text == "")
            {
                if (WaitingToPlayListbox.Items.Count > 0)
                {
                    string Song = WaitingToPlayListbox.Items[0].ToString();
                    NowPlayingTextbox.Text = Song;
                    MoveToNowPlaying.Stop();
                    WaitingToPlayListbox.Items.RemoveAt(0);
                }
            
                    WMPLib.WindowsMediaPlayer Playerz = new WMPLib.WindowsMediaPlayer();
                    Playerz.URL = (SaveToFile + "SleepAway.mp3");
                    Playerz.controls.play();
                    IsJukeboxPlaying = true;
                MoveToNowPlaying.Stop();
                
            }
            WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();

            Player.URL = ( SaveToFile + "Tracks/SleepAway.mp3");
            Player.controls.play();
            IsJukeboxPlaying = true;
        }


        private void WMPPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void AddDataBtn_Click(object sender, EventArgs e)
        {

            GenreTextbox.Text = GenreList[NumberOfGenres];
            TrackListListbox.Items.Clear();
            TrackListListbox.Items.Add(TrackList[NumberOfTracks]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

    }
}
