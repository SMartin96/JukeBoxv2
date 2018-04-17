namespace JukeBoxv2
{
    partial class Setup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearImportTracksBtn = new System.Windows.Forms.Button();
            this.ImportTracksBtn = new System.Windows.Forms.Button();
            this.ImportedTracksListbox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GenreTitleTextbox = new System.Windows.Forms.TextBox();
            this.DeleteGenreBtn = new System.Windows.Forms.Button();
            this.PreviousGenreBtn = new System.Windows.Forms.Button();
            this.AddGenreBtn = new System.Windows.Forms.Button();
            this.NextGenreBtn = new System.Windows.Forms.Button();
            this.GenreListbox = new System.Windows.Forms.ListBox();
            this.CopyTracksBtn = new System.Windows.Forms.Button();
            this.MoveTrackBtn = new System.Windows.Forms.Button();
            this.RemoveTrackFromGenreBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearImportTracksBtn);
            this.groupBox1.Controls.Add(this.ImportTracksBtn);
            this.groupBox1.Controls.Add(this.ImportedTracksListbox);
            this.groupBox1.Location = new System.Drawing.Point(8, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imported Tracks";
            // 
            // ClearImportTracksBtn
            // 
            this.ClearImportTracksBtn.Location = new System.Drawing.Point(12, 382);
            this.ClearImportTracksBtn.Name = "ClearImportTracksBtn";
            this.ClearImportTracksBtn.Size = new System.Drawing.Size(245, 41);
            this.ClearImportTracksBtn.TabIndex = 2;
            this.ClearImportTracksBtn.Text = "Clear Import Tracks";
            this.ClearImportTracksBtn.UseVisualStyleBackColor = true;
            this.ClearImportTracksBtn.Click += new System.EventHandler(this.ClearImportTracksBtn_Click);
            // 
            // ImportTracksBtn
            // 
            this.ImportTracksBtn.Location = new System.Drawing.Point(12, 324);
            this.ImportTracksBtn.Name = "ImportTracksBtn";
            this.ImportTracksBtn.Size = new System.Drawing.Size(245, 51);
            this.ImportTracksBtn.TabIndex = 1;
            this.ImportTracksBtn.Text = "Import Tracks";
            this.ImportTracksBtn.UseVisualStyleBackColor = true;
            this.ImportTracksBtn.Click += new System.EventHandler(this.ImportTracksBtn_Click);
            // 
            // ImportedTracksListbox
            // 
            this.ImportedTracksListbox.FormattingEnabled = true;
            this.ImportedTracksListbox.ItemHeight = 16;
            this.ImportedTracksListbox.Location = new System.Drawing.Point(12, 26);
            this.ImportedTracksListbox.Name = "ImportedTracksListbox";
            this.ImportedTracksListbox.Size = new System.Drawing.Size(245, 292);
            this.ImportedTracksListbox.TabIndex = 0;
            this.ImportedTracksListbox.SelectedIndexChanged += new System.EventHandler(this.ImportedTracks_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GenreTitleTextbox);
            this.groupBox2.Controls.Add(this.DeleteGenreBtn);
            this.groupBox2.Controls.Add(this.PreviousGenreBtn);
            this.groupBox2.Controls.Add(this.AddGenreBtn);
            this.groupBox2.Controls.Add(this.NextGenreBtn);
            this.groupBox2.Controls.Add(this.GenreListbox);
            this.groupBox2.Location = new System.Drawing.Point(429, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 429);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Present Genres Track List";
            // 
            // GenreTitleTextbox
            // 
            this.GenreTitleTextbox.Location = new System.Drawing.Point(13, 24);
            this.GenreTitleTextbox.Name = "GenreTitleTextbox";
            this.GenreTitleTextbox.ReadOnly = true;
            this.GenreTitleTextbox.Size = new System.Drawing.Size(247, 22);
            this.GenreTitleTextbox.TabIndex = 6;
            this.GenreTitleTextbox.TextChanged += new System.EventHandler(this.GenreTitleTextbox_TextChanged);
            // 
            // DeleteGenreBtn
            // 
            this.DeleteGenreBtn.Location = new System.Drawing.Point(100, 372);
            this.DeleteGenreBtn.Name = "DeleteGenreBtn";
            this.DeleteGenreBtn.Size = new System.Drawing.Size(90, 51);
            this.DeleteGenreBtn.TabIndex = 5;
            this.DeleteGenreBtn.Text = "Delete Genre";
            this.DeleteGenreBtn.UseVisualStyleBackColor = true;
            this.DeleteGenreBtn.Click += new System.EventHandler(this.DeleteGenreBtn_Click);
            // 
            // PreviousGenreBtn
            // 
            this.PreviousGenreBtn.Location = new System.Drawing.Point(15, 324);
            this.PreviousGenreBtn.Name = "PreviousGenreBtn";
            this.PreviousGenreBtn.Size = new System.Drawing.Size(79, 99);
            this.PreviousGenreBtn.TabIndex = 4;
            this.PreviousGenreBtn.Text = "<< Previous Genre";
            this.PreviousGenreBtn.UseVisualStyleBackColor = true;
            this.PreviousGenreBtn.Click += new System.EventHandler(this.PreviousGenreBtn_Click);
            // 
            // AddGenreBtn
            // 
            this.AddGenreBtn.Location = new System.Drawing.Point(100, 324);
            this.AddGenreBtn.Name = "AddGenreBtn";
            this.AddGenreBtn.Size = new System.Drawing.Size(90, 42);
            this.AddGenreBtn.TabIndex = 3;
            this.AddGenreBtn.Text = "Add Genre";
            this.AddGenreBtn.UseVisualStyleBackColor = true;
            this.AddGenreBtn.Click += new System.EventHandler(this.AddGenreBtn_Click);
            // 
            // NextGenreBtn
            // 
            this.NextGenreBtn.Location = new System.Drawing.Point(196, 324);
            this.NextGenreBtn.Name = "NextGenreBtn";
            this.NextGenreBtn.Size = new System.Drawing.Size(79, 99);
            this.NextGenreBtn.TabIndex = 2;
            this.NextGenreBtn.Text = "Next Genre >>";
            this.NextGenreBtn.UseVisualStyleBackColor = true;
            this.NextGenreBtn.Click += new System.EventHandler(this.NextGenreBtn_Click);
            // 
            // GenreListbox
            // 
            this.GenreListbox.FormattingEnabled = true;
            this.GenreListbox.ItemHeight = 16;
            this.GenreListbox.Location = new System.Drawing.Point(15, 58);
            this.GenreListbox.Name = "GenreListbox";
            this.GenreListbox.Size = new System.Drawing.Size(246, 260);
            this.GenreListbox.TabIndex = 1;
            this.GenreListbox.SelectedIndexChanged += new System.EventHandler(this.GenreListbox_SelectedIndexChanged);
            // 
            // CopyTracksBtn
            // 
            this.CopyTracksBtn.Location = new System.Drawing.Point(294, 50);
            this.CopyTracksBtn.Name = "CopyTracksBtn";
            this.CopyTracksBtn.Size = new System.Drawing.Size(122, 75);
            this.CopyTracksBtn.TabIndex = 2;
            this.CopyTracksBtn.Text = "Copy Track >>";
            this.CopyTracksBtn.UseVisualStyleBackColor = true;
            this.CopyTracksBtn.Click += new System.EventHandler(this.CopyTracksBtn_Click);
            // 
            // MoveTrackBtn
            // 
            this.MoveTrackBtn.Location = new System.Drawing.Point(294, 131);
            this.MoveTrackBtn.Name = "MoveTrackBtn";
            this.MoveTrackBtn.Size = new System.Drawing.Size(122, 75);
            this.MoveTrackBtn.TabIndex = 3;
            this.MoveTrackBtn.Text = "Move Track >>";
            this.MoveTrackBtn.UseVisualStyleBackColor = true;
            this.MoveTrackBtn.Click += new System.EventHandler(this.MoveTrackBtn_Click);
            // 
            // RemoveTrackFromGenreBtn
            // 
            this.RemoveTrackFromGenreBtn.Location = new System.Drawing.Point(294, 280);
            this.RemoveTrackFromGenreBtn.Name = "RemoveTrackFromGenreBtn";
            this.RemoveTrackFromGenreBtn.Size = new System.Drawing.Size(121, 114);
            this.RemoveTrackFromGenreBtn.TabIndex = 4;
            this.RemoveTrackFromGenreBtn.Text = "Remove Track From Genre";
            this.RemoveTrackFromGenreBtn.UseVisualStyleBackColor = true;
            this.RemoveTrackFromGenreBtn.Click += new System.EventHandler(this.RemoveTrackFromGenreBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(635, 476);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(554, 476);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 6;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 511);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.RemoveTrackFromGenreBtn);
            this.Controls.Add(this.MoveTrackBtn);
            this.Controls.Add(this.CopyTracksBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Setup";
            this.Text = "Setup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ImportedTracksListbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox GenreListbox;
        private System.Windows.Forms.Button ImportTracksBtn;
        private System.Windows.Forms.Button ClearImportTracksBtn;
        private System.Windows.Forms.Button CopyTracksBtn;
        private System.Windows.Forms.Button MoveTrackBtn;
        private System.Windows.Forms.Button RemoveTrackFromGenreBtn;
        private System.Windows.Forms.Button DeleteGenreBtn;
        private System.Windows.Forms.Button PreviousGenreBtn;
        private System.Windows.Forms.Button AddGenreBtn;
        private System.Windows.Forms.Button NextGenreBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.TextBox GenreTitleTextbox;
    }
}