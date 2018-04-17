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
            LoadTracks.Start();
        }
        
        string SaveToFile = Directory.GetCurrentDirectory() + "\\";


        bool IsJukeboxPlaying;

        private void GenreTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrackListListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            string GenreTitle = File.ReadLines(SaveToFile + "GenreTitles.txt").Skip(0).Take(1).First();
            string TrackList = File.ReadLines(SaveToFile + "Songs.txt").Skip(0).Take(1).First();
        }
    }
}
