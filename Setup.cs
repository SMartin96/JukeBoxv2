using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs;
using System.IO;

namespace JukeBoxv2
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }
        string SaveToFile = Directory.GetCurrentDirectory() + "\\";

        List<string> GenreList = File.ReadAllLines("C:/Users/Gravy/Source/Repos/JukeBoxv2/Bin/Debug/GenreTitles.txt").ToList();
        List<string> TrackLists = File.ReadAllLines("C:/Users/Gravy/Source/Repos/JukeBoxv2/Bin/Debug/Songs.txt").ToList();

        public List<string> Genres = new List<string>();
        public List<string> Tracks = new List<string>();
        private void ImportedTracks_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void GenreListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ImportTracksBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] directs = Directory.GetDirectories(fbd.SelectedPath);
                string[] files = Directory.GetFiles(fbd.SelectedPath);

                foreach (string file in files)
                {

                    ImportedTracksListbox.Items.Add(Path.GetFileName(file));
                }

                foreach (string direct in directs)
                {
                    ImportedTracksListbox.Items.Add(Path.GetDirectoryName(direct));
                }
            }
        }

        private void ClearImportTracksBtn_Click(object sender, EventArgs e)
        {
            ImportedTracksListbox.Items.Clear();
        }

        private void CopyTracksBtn_Click(object sender, EventArgs e)
        {

            if (ImportedTracksListbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a track first");
            }

            else
            {
                GenreListbox.Items.Add(ImportedTracksListbox.SelectedItem);
            }
        }

        private void MoveTrackBtn_Click(object sender, EventArgs e)
        {
            string MoveTracks = GenreListbox.Items.ToString();

            if (ImportedTracksListbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a track first");
            }

            else
            {
                GenreListbox.Items.Add(ImportedTracksListbox.SelectedItem);
                ImportedTracksListbox.Items.Remove(ImportedTracksListbox.SelectedItem);
            }
        }

        private void RemoveTrackFromGenreBtn_Click(object sender, EventArgs e)
        {
            string RemoveItem = GenreListbox.Text;
            GenreListbox.Items.Remove(RemoveItem);
        }

        private void PreviousGenreBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddGenreBtn_Click(object sender, EventArgs e)
        {
        string UserGenre = My_Dialogs.InputBox("Name your Genre");
        Genres.Add(UserGenre);
        GenreTitleTextbox.Text = UserGenre;

        StreamWriter SaveGenreFile = File.AppendText("GenreTitles.txt");
        StreamWriter SaveTracksFile = File.AppendText("Songs.txt");
            SaveGenreFile.WriteLine(UserGenre);


            List <string> Tracklist = GenreListbox.Items.OfType<string>().ToList();


            foreach (string Track in Tracklist)
                {
                    SaveTracksFile.WriteLine(Track);
                }
                SaveTracksFile.Close();
                SaveGenreFile.Close();

            
            
        }

        private void NextGenreBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteGenreBtn_Click(object sender, EventArgs e)
        {

        }

        private void GenreTitleTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
