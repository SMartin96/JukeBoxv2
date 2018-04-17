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

        }

        private void PreviousGenreBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddGenreBtn_Click(object sender, EventArgs e)
        {

        }

        private void NextGenreBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteGenreBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
