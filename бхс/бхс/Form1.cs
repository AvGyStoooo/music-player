using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WMPLib;

namespace бхс
{
	public partial class Form1 : Form
	{
		Random rnd = new Random();
		WindowsMediaPlayer player;
		int current_track;
		bool shuffle = false;
		List<Track> playlist = new List<Track>();
		bool repeat = false;
		public Form1()
		{
			InitializeComponent();
			player = new WindowsMediaPlayer(); 
		}

		
		void RefreshPlayList()
		{
			listBox1.Items.Clear();
			for (int i = 0; i < playlist.Count; i++)
			{
				listBox1.Items.Add(playlist[i].Name);
			}
		}

		void PlayTrack(int v)
		{
			string path = playlist[v].Path;
			player.URL = path;
			current_track = v;
			listBox1.SelectedIndex = v;
			this.Text = "плеер: " + playlist[v].Name;
		}
		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			progressBar1.Value = trackBar1.Value;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (playlist.Count == 0)
			{
				AddAudioFile();
			}
			if (player.playState == WMPPlayState.wmppsPlaying)
			{
				player.controls.pause();
			}
			else if (player.playState == WMPPlayState.wmppsPaused || player.playState == WMPPlayState.wmppsStopped)
			{
				player.controls.play();
				while (shuffle)
				{
					player.controls.currentPosition = 0;
				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			player.controls.stop();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (!shuffle && !repeat)
			{
				current_track--;
				if (current_track < 0)
				{
					current_track = playlist.Count - 1;
				}

			}
			else if (repeat)
			{

			}
			else
			{
				current_track = rnd.Next(0, playlist.Count);
			}
			PlayTrack(current_track);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (!shuffle && !repeat)
			{
				current_track++;
				if (current_track > playlist.Count - 1)
				{
					current_track = 0;
				}

			}
			else if (repeat)
			{

			}
			else
			{
				current_track = rnd.Next(0, playlist.Count);
			}
			PlayTrack(current_track);
		}

		private void управлениеToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void добавитьТрекToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddAudioFile();
		}
		void AddAudioFile()
		{
			openFileDialog1.Title = "Файл скинь";
			openFileDialog1.Filter = "Audio Files|*.mp3|WAV|*.wav|Flac files|*.flac|ALL FILES|*.*";
			openFileDialog1.FileName = "";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				playlist.Add(new Track(openFileDialog1.SafeFileName,openFileDialog1.FileName));
				RefreshPlayList();
			}
			if(playlist.Count ==1)
			{
				PlayTrack(0);
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			repeat = !repeat;
			if (repeat) { button6.Text = "Repeat ON"; }
			else { button6.Text = "Repeat OFF"; }
		}

		private void button7_Click(object sender, EventArgs e)
		{
			shuffle = !shuffle;
			if (repeat) { button7.Text = "Shuffle ON"; }
			else { button7.Text = "Shuffle OFF"; }
		}

		private void удалитьТрекToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex != -1)
			{
				playlist.RemoveAt(listBox1.SelectedIndex);
			}
			RefreshPlayList();
		}
	}
}
