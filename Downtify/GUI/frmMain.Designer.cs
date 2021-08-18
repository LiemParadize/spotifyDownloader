using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Downtify.GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.listBoxTracks = new System.Windows.Forms.ListBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBoxAlbumCover = new System.Windows.Forms.PictureBox();
            this.labelTite = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelDurationText = new System.Windows.Forms.Label();
            this.labelDurationTextValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.downCover = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLink = new Downtify.GUI.PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).BeginInit();
            this.statusStripMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTracks
            // 
            this.listBoxTracks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listBoxTracks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTracks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTracks.ForeColor = System.Drawing.Color.White;
            this.listBoxTracks.FormattingEnabled = true;
            this.listBoxTracks.ItemHeight = 17;
            this.listBoxTracks.Location = new System.Drawing.Point(6, 21);
            this.listBoxTracks.Name = "listBoxTracks";
            this.listBoxTracks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTracks.Size = new System.Drawing.Size(962, 155);
            this.listBoxTracks.TabIndex = 0;
            this.listBoxTracks.SelectedIndexChanged += new System.EventHandler(this.listBoxTracks_SelectedIndexChanged);
            this.listBoxTracks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxTracks_KeyDown);
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownload.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownload.ForeColor = System.Drawing.Color.White;
            this.buttonDownload.Location = new System.Drawing.Point(706, 273);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(137, 36);
            this.buttonDownload.TabIndex = 2;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar1.Location = new System.Drawing.Point(12, 273);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(688, 36);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // pictureBoxAlbumCover
            // 
            this.pictureBoxAlbumCover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxAlbumCover.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxAlbumCover.Location = new System.Drawing.Point(11, 315);
            this.pictureBoxAlbumCover.Name = "pictureBoxAlbumCover";
            this.pictureBoxAlbumCover.Size = new System.Drawing.Size(188, 188);
            this.pictureBoxAlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbumCover.TabIndex = 4;
            this.pictureBoxAlbumCover.TabStop = false;
            this.pictureBoxAlbumCover.Click += new System.EventHandler(this.pictureBoxAlbumCover_Click);
            // 
            // labelTite
            // 
            this.labelTite.AutoEllipsis = true;
            this.labelTite.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTite.ForeColor = System.Drawing.Color.White;
            this.labelTite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTite.Location = new System.Drawing.Point(205, 428);
            this.labelTite.Name = "labelTite";
            this.labelTite.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelTite.Size = new System.Drawing.Size(318, 31);
            this.labelTite.TabIndex = 6;
            this.labelTite.Text = "Title";
            this.labelTite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoEllipsis = true;
            this.labelAlbum.ForeColor = System.Drawing.Color.DarkGray;
            this.labelAlbum.Location = new System.Drawing.Point(206, 479);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelAlbum.Size = new System.Drawing.Size(317, 19);
            this.labelAlbum.TabIndex = 7;
            this.labelAlbum.Text = "Album";
            this.labelAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelArtist
            // 
            this.labelArtist.AutoEllipsis = true;
            this.labelArtist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtist.ForeColor = System.Drawing.Color.White;
            this.labelArtist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelArtist.Location = new System.Drawing.Point(206, 459);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelArtist.Size = new System.Drawing.Size(317, 20);
            this.labelArtist.TabIndex = 7;
            this.labelArtist.Text = "Artist";
            this.labelArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelArtist.Click += new System.EventHandler(this.labelArtist_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.statusStripMain.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMain});
            this.statusStripMain.Location = new System.Drawing.Point(0, 506);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(998, 22);
            this.statusStripMain.TabIndex = 9;
            this.statusStripMain.Text = "Ready";
            // 
            // toolStripStatusLabelMain
            // 
            this.toolStripStatusLabelMain.Name = "toolStripStatusLabelMain";
            this.toolStripStatusLabelMain.Size = new System.Drawing.Size(0, 17);
            // 
            // labelDurationText
            // 
            this.labelDurationText.AutoSize = true;
            this.labelDurationText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.labelDurationText.ForeColor = System.Drawing.Color.White;
            this.labelDurationText.Location = new System.Drawing.Point(797, 511);
            this.labelDurationText.Name = "labelDurationText";
            this.labelDurationText.Size = new System.Drawing.Size(137, 13);
            this.labelDurationText.TabIndex = 10;
            this.labelDurationText.Text = "Selected Songs Duration:";
            this.labelDurationText.Click += new System.EventHandler(this.labelDurationText_Click);
            // 
            // labelDurationTextValue
            // 
            this.labelDurationTextValue.AutoSize = true;
            this.labelDurationTextValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.labelDurationTextValue.ForeColor = System.Drawing.Color.White;
            this.labelDurationTextValue.Location = new System.Drawing.Point(931, 511);
            this.labelDurationTextValue.Name = "labelDurationTextValue";
            this.labelDurationTextValue.Size = new System.Drawing.Size(49, 13);
            this.labelDurationTextValue.TabIndex = 10;
            this.labelDurationTextValue.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(683, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "from Downtify - by michioxd - Path: C:\\spotifyDownloader";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxLink);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(974, 65);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spotify Track URLs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(882, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "enter to submit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxTracks);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 184);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Queue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(683, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            this.label3.Click += new System.EventHandler(this.labelDurationText_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(653, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 14;
            // 
            // downCover
            // 
            this.downCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.downCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downCover.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downCover.ForeColor = System.Drawing.Color.White;
            this.downCover.Location = new System.Drawing.Point(849, 273);
            this.downCover.Name = "downCover";
            this.downCover.Size = new System.Drawing.Size(137, 36);
            this.downCover.TabIndex = 15;
            this.downCover.Text = "downCover";
            this.downCover.UseVisualStyleBackColor = false;
            this.downCover.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(900, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "LOCAL DEBUG";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxLink
            // 
            this.textBoxLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLink.ForeColor = System.Drawing.Color.White;
            this.textBoxLink.Location = new System.Drawing.Point(6, 19);
            this.textBoxLink.Multiline = true;
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Placeholder = "Put your track or playlist link here";
            this.textBoxLink.Size = new System.Drawing.Size(962, 23);
            this.textBoxLink.TabIndex = 1;
            this.textBoxLink.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLink_KeyPress);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(998, 528);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.downCover);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.pictureBoxAlbumCover);
            this.Controls.Add(this.labelTite);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDurationTextValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDurationText);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonDownload);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spotify Downloader";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).EndInit();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxTracks;
        private PlaceholderTextBox textBoxLink;
        private Button buttonDownload;
        private ProgressBar progressBar1;
        private PictureBox pictureBoxAlbumCover;
        private Label labelTite;
        private Label labelAlbum;
        private Label labelArtist;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel toolStripStatusLabelMain;
        private Label labelDurationText;
        private Label labelDurationTextValue;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private Button downCover;
        private Label label5;
    }
}

