namespace MusicRandomizer
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
            this.rndbtn = new System.Windows.Forms.Button();
            this.outputlbl = new System.Windows.Forms.Label();
            this.playlistlbl = new System.Windows.Forms.Label();
            this.playlistbtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // rndbtn
            // 
            this.rndbtn.Location = new System.Drawing.Point(12, 91);
            this.rndbtn.Name = "rndbtn";
            this.rndbtn.Size = new System.Drawing.Size(128, 23);
            this.rndbtn.TabIndex = 0;
            this.rndbtn.Text = "Get a random song";
            this.rndbtn.UseVisualStyleBackColor = true;
            this.rndbtn.Click += new System.EventHandler(this.rndbtn_Click);
            // 
            // outputlbl
            // 
            this.outputlbl.AutoSize = true;
            this.outputlbl.Location = new System.Drawing.Point(9, 134);
            this.outputlbl.Name = "outputlbl";
            this.outputlbl.Size = new System.Drawing.Size(0, 13);
            this.outputlbl.TabIndex = 1;
            // 
            // playlistlbl
            // 
            this.playlistlbl.AutoSize = true;
            this.playlistlbl.Location = new System.Drawing.Point(9, 57);
            this.playlistlbl.Name = "playlistlbl";
            this.playlistlbl.Size = new System.Drawing.Size(0, 13);
            this.playlistlbl.TabIndex = 2;
            // 
            // playlistbtn
            // 
            this.playlistbtn.Location = new System.Drawing.Point(12, 12);
            this.playlistbtn.Name = "playlistbtn";
            this.playlistbtn.Size = new System.Drawing.Size(127, 23);
            this.playlistbtn.TabIndex = 3;
            this.playlistbtn.Text = "Open Playlist";
            this.playlistbtn.UseVisualStyleBackColor = true;
            this.playlistbtn.Click += new System.EventHandler(this.playlistbtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 185);
            this.Controls.Add(this.playlistbtn);
            this.Controls.Add(this.playlistlbl);
            this.Controls.Add(this.outputlbl);
            this.Controls.Add(this.rndbtn);
            this.Name = "Form1";
            this.Text = "Music Randomizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rndbtn;
        private System.Windows.Forms.Label outputlbl;
        private System.Windows.Forms.Label playlistlbl;
        private System.Windows.Forms.Button playlistbtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

