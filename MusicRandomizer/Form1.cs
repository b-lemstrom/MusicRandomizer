using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

//Bastian Lemström 2018-01-21

namespace MusicRandomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] lines;

        private void playlistbtn_Click(object sender, EventArgs e)
        {
            //Code to open and select a playlist, filtering for .m3u8 playlist-files.
            OpenFileDialog openPlaylist = new OpenFileDialog();
            openPlaylist.Filter = "Playlist Files|*.m3u8";
            openPlaylist.Title = "Select a Playlist File";

            //Gather chosen playlist.
            if (openPlaylist.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                string filename = openPlaylist.FileName;
                lines = File.ReadAllLines(filename);
                string display = openPlaylist.SafeFileName;
                display = display.Replace("_", " ");
                playlistlbl.Text = "Playlist: " + display.Replace(".m3u8", " ");
            }
        }

        private void rndbtn_Click(object sender, EventArgs e)
        {
            //Simple random-function, between 1 and the length of the array. Is not 0 due to file structure.
            Random rnd = new Random();
            if (lines == null)
            {
                DialogResult dlg = MessageBox.Show("Please pick a playlist first.",
                                               "Confirmation",
                                               MessageBoxButtons.OKCancel,
                                               MessageBoxIcon.Warning
               ); //Send to OPEN PLAYLIST IF OK
            }
            else
            {
                int y = lines.Length;
                int x = rnd.Next(1, y);
                //Here we do check, because the structure of a playlistfile gives us the filepath on every other line.
                while (x % 2 == 0)
                {
                    x = rnd.Next(1, y);
                }
                //Cleaning up the output from "#EXTINF:177,AC/DC - Miss Adventure" -> "AC/DC - Miss Adventure"
                string second = lines[x];
                second = second.Replace("#EXTINF:", "");
                second = second.Remove(0, 4);
                randomSongs(second);
                outputlbl.Text = "Song: " + second;
            }
        }
        // Create a list to store the songs that hav been randomized.

        // --------------

        // Create an option to cache the playlist. To avoid having to reselect the same file everytime the program starts.
        private void randomSongs(string song)
        {
            string s = song;
            string path = System.IO.Directory.GetCurrentDirectory();
            string filename = "Playlist_" + DateTime.Now.ToString("yyyy/MM/dd") + ".txt";
            path = System.IO.Path.Combine(path, filename);
            Console.WriteLine();
            if (!System.IO.File.Exists(path))
            {
                using (System.IO.StreamWriter fs = new System.IO.StreamWriter(path))
                {
                    fs.WriteLine(s);
                }
            }
            else
            {
                using (System.IO.StreamWriter fs = new System.IO.StreamWriter(path, true))
                {
                    fs.WriteLine(s);
                }
            }
        }

    }
}
