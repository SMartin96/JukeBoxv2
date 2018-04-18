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

            if (Genres.Count > 0 && Tracks.Count > 0) // Allows me to display first Genre and tracks
            {
                GenreTitleTextbox.Text = Genres[0].ToString(); // Selects 0th index and returns value
                GenreListbox.Items.Add(Tracks[0]);
            }
        }
        string SaveToFile = Directory.GetCurrentDirectory() + "\\"; // Lets me find the path to my debug folder

        List<string> GenreList = File.ReadAllLines("GenreTitles.txt").ToList(); // Creates lists from text files I have saved
        List<string> TrackList = File.ReadAllLines("Songs.txt").ToList();


        public List<string> Genres = new List<string>(); // Created new lists from input that I save
        public List<string> Tracks = new List<string>();

        int NumberOfGenres = 0; 
        int NumberOfTracks = 0;
        private void ImportedTracks_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void GenreListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ImportTracksBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog(); // Allows me to select a folder in which to import tracks
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

        private void ClearImportTracksBtn_Click(object sender, EventArgs e) // Lets me clear import tracks from listbox
        {
            ImportedTracksListbox.Items.Clear();
        }

        private void CopyTracksBtn_Click(object sender, EventArgs e) // Lets me copy tracks from imported tracks listbox to genre list
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

        private void MoveTrackBtn_Click(object sender, EventArgs e) // Moves the track so it disappears from import listbox
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

        private void RemoveTrackFromGenreBtn_Click(object sender, EventArgs e) // Lets me remove a track from the genre
        {
            string RemoveItem = GenreListbox.Text;
            GenreListbox.Items.Remove(RemoveItem);
        }

        private void PreviousGenreBtn_Click(object sender, EventArgs e) // Allows me to move a previous record for the title and songs
        {
            List<string> GenreList = File.ReadAllLines(SaveToFile + "GenreTitles.txt").ToList();
            List<string> TrackList = File.ReadAllLines(SaveToFile + "Songs.txt").ToList();

            if (NumberOfGenres < Genres.Count - 1) // Decrements count and shows next list value
            {
                NumberOfGenres += 1;
                GenreTitleTextbox.Text = GenreList[NumberOfGenres];
            }

            if (NumberOfTracks < TrackList.Count - 1)
            {
                NumberOfTracks += 1;
                GenreListbox.Items.Clear();
                GenreListbox.Items.Add(TrackList[NumberOfTracks]);
            }
        }

        private void AddGenreBtn_Click(object sender, EventArgs e) // Allows me to add genre
        {
        string UserGenre = My_Dialogs.InputBox("Name your Genre"); // Get input from user
        NumberOfGenres++;
        Genres.Add(UserGenre); // Adds the user input to a list of genres
        GenreTitleTextbox.Text = UserGenre; // Displays the input in the text box

        StreamWriter SaveGenreFile = File.AppendText("GenreTitles.txt"); // Allows me to continue writing in the same text file
        StreamWriter SaveTracksFile = File.AppendText("Songs.txt");
            SaveGenreFile.WriteLine(UserGenre);


            List <string> TracklistGenre = GenreListbox.Items.OfType<string>().ToList(); // Create list to allow me to write down listbox items to text file


            foreach (string Track in TracklistGenre) // Adds x amount of tracks for every x amount of items in the listbox
                {
                    SaveTracksFile.WriteLine(Track);             
                }

           List<int> TracklistSong = GenreListbox.Items.OfType<int>().ToList();

            foreach ( int NumberTracks in TracklistSong)
            {
                NumberOfTracks++;
            }
                SaveTracksFile.Close();
                SaveGenreFile.Close();


            if (GenreTitleTextbox.Text != "")
            {
                GenreListbox.Items.Clear();
            }


        }

        private void NextGenreBtn_Click(object sender, EventArgs e) // Allows me to go to next genre by incrimenting the values
        {
            List<string> GenreList = File.ReadAllLines(SaveToFile + "GenreTitles.txt").ToList();
            List<string> TrackList = File.ReadAllLines(SaveToFile + "Songs.txt").ToList();

            if (NumberOfGenres > 0)
            {
                NumberOfGenres -= 1;
                GenreTitleTextbox.Text = GenreList[NumberOfGenres];
            }

            if (NumberOfTracks > 0)
            {
                NumberOfTracks -= 1;
                GenreListbox.Items.Clear();
                GenreListbox.Items.Add(TrackList[NumberOfTracks]);
            }



        }

        private void DeleteGenreBtn_Click(object sender, EventArgs e) // Allows me to delete a genre 
        {
            List<string> GenreList = File.ReadAllLines(SaveToFile + "GenreTitles.txt").ToList();
            List<string> TrackList = File.ReadAllLines(SaveToFile + "Songs.txt").ToList();

            string RemoveTracks = GenreListbox.Items.ToString(); 
            string RemoveGenres = GenreTitleTextbox.Text;

            GenreList.Remove(RemoveGenres); // Removes them from list box
            TrackList.Remove(RemoveTracks);

            GenreTitleTextbox.Clear();
            GenreListbox.Items.Clear();
        }

        private void GenreTitleTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
