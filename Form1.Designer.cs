namespace JukeBoxv2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.GenreTextbox = new System.Windows.Forms.TextBox();
            this.TrackListListbox = new System.Windows.Forms.ListBox();
            this.HScrollBar = new System.Windows.Forms.HScrollBar();
            this.NowPlayingTextbox = new System.Windows.Forms.TextBox();
            this.SetupFormOpenButton = new System.Windows.Forms.Button();
            this.AboutFormButton = new System.Windows.Forms.Button();
            this.WaitingToPlayListbox = new System.Windows.Forms.ListBox();
            this.LoadTracks = new System.Windows.Forms.Timer(this.components);
            this.MoveToNowPlaying = new System.Windows.Forms.Timer(this.components);
            this.WMPPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.WMPPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Location = new System.Drawing.Point(372, 9);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(211, 17);
            this.CopyrightLabel.TabIndex = 0;
            this.CopyrightLabel.Text = "Copy Right  © 2018 Sean Martin";
            // 
            // GenreTextbox
            // 
            this.GenreTextbox.Location = new System.Drawing.Point(216, 106);
            this.GenreTextbox.Name = "GenreTextbox";
            this.GenreTextbox.ReadOnly = true;
            this.GenreTextbox.Size = new System.Drawing.Size(159, 22);
            this.GenreTextbox.TabIndex = 1;
            this.GenreTextbox.TextChanged += new System.EventHandler(this.GenreTextbox_TextChanged);
            // 
            // TrackListListbox
            // 
            this.TrackListListbox.FormattingEnabled = true;
            this.TrackListListbox.ItemHeight = 16;
            this.TrackListListbox.Location = new System.Drawing.Point(216, 134);
            this.TrackListListbox.Name = "TrackListListbox";
            this.TrackListListbox.Size = new System.Drawing.Size(159, 100);
            this.TrackListListbox.TabIndex = 2;
            this.TrackListListbox.SelectedIndexChanged += new System.EventHandler(this.TrackListListbox_SelectedIndexChanged);
            // 
            // HScrollBar
            // 
            this.HScrollBar.Location = new System.Drawing.Point(201, 237);
            this.HScrollBar.Name = "HScrollBar";
            this.HScrollBar.Size = new System.Drawing.Size(190, 14);
            this.HScrollBar.TabIndex = 3;
            this.HScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar_Scroll);
            // 
            // NowPlayingTextbox
            // 
            this.NowPlayingTextbox.Location = new System.Drawing.Point(213, 267);
            this.NowPlayingTextbox.Name = "NowPlayingTextbox";
            this.NowPlayingTextbox.ReadOnly = true;
            this.NowPlayingTextbox.Size = new System.Drawing.Size(162, 22);
            this.NowPlayingTextbox.TabIndex = 4;
            this.NowPlayingTextbox.TextChanged += new System.EventHandler(this.NowPlayingTextbox_TextChanged);
            // 
            // SetupFormOpenButton
            // 
            this.SetupFormOpenButton.Location = new System.Drawing.Point(155, 475);
            this.SetupFormOpenButton.Name = "SetupFormOpenButton";
            this.SetupFormOpenButton.Size = new System.Drawing.Size(104, 24);
            this.SetupFormOpenButton.TabIndex = 5;
            this.SetupFormOpenButton.Text = "Setup";
            this.SetupFormOpenButton.UseVisualStyleBackColor = true;
            this.SetupFormOpenButton.Click += new System.EventHandler(this.SetupFormOpenButton_Click);
            // 
            // AboutFormButton
            // 
            this.AboutFormButton.Location = new System.Drawing.Point(336, 474);
            this.AboutFormButton.Name = "AboutFormButton";
            this.AboutFormButton.Size = new System.Drawing.Size(104, 26);
            this.AboutFormButton.TabIndex = 6;
            this.AboutFormButton.Text = "About";
            this.AboutFormButton.UseVisualStyleBackColor = true;
            this.AboutFormButton.Click += new System.EventHandler(this.AboutFormButton_Click);
            // 
            // WaitingToPlayListbox
            // 
            this.WaitingToPlayListbox.FormattingEnabled = true;
            this.WaitingToPlayListbox.ItemHeight = 16;
            this.WaitingToPlayListbox.Location = new System.Drawing.Point(213, 295);
            this.WaitingToPlayListbox.Name = "WaitingToPlayListbox";
            this.WaitingToPlayListbox.Size = new System.Drawing.Size(162, 148);
            this.WaitingToPlayListbox.TabIndex = 7;
            this.WaitingToPlayListbox.SelectedIndexChanged += new System.EventHandler(this.WaitingToPlayListbox_SelectedIndexChanged);
            // 
            // LoadTracks
            // 
            this.LoadTracks.Enabled = true;
            this.LoadTracks.Tick += new System.EventHandler(this.LoadTracks_Tick);
            // 
            // MoveToNowPlaying
            // 
            this.MoveToNowPlaying.Enabled = true;
            this.MoveToNowPlaying.Tick += new System.EventHandler(this.MoveToNowPlaying_Tick);
            // 
            // WMPPlayer
            // 
            this.WMPPlayer.Enabled = true;
            this.WMPPlayer.Location = new System.Drawing.Point(573, 29);
            this.WMPPlayer.Name = "WMPPlayer";
            this.WMPPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPPlayer.OcxState")));
            this.WMPPlayer.Size = new System.Drawing.Size(10, 10);
            this.WMPPlayer.TabIndex = 9;
            this.WMPPlayer.Enter += new System.EventHandler(this.WMPPlayer_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 533);
            this.Controls.Add(this.WMPPlayer);
            this.Controls.Add(this.WaitingToPlayListbox);
            this.Controls.Add(this.AboutFormButton);
            this.Controls.Add(this.SetupFormOpenButton);
            this.Controls.Add(this.NowPlayingTextbox);
            this.Controls.Add(this.HScrollBar);
            this.Controls.Add(this.TrackListListbox);
            this.Controls.Add(this.GenreTextbox);
            this.Controls.Add(this.CopyrightLabel);
            this.Name = "Form1";
            this.Text = "My Juke Box V1.0";
            ((System.ComponentModel.ISupportInitialize)(this.WMPPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.TextBox GenreTextbox;
        private System.Windows.Forms.ListBox TrackListListbox;
        private System.Windows.Forms.HScrollBar HScrollBar;
        private System.Windows.Forms.TextBox NowPlayingTextbox;
        private System.Windows.Forms.Button SetupFormOpenButton;
        private System.Windows.Forms.Button AboutFormButton;
        private System.Windows.Forms.ListBox WaitingToPlayListbox;
        private System.Windows.Forms.Timer LoadTracks;
        private System.Windows.Forms.Timer MoveToNowPlaying;
        private AxWMPLib.AxWindowsMediaPlayer WMPPlayer;
    }
}

