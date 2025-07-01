namespace бхс
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.добавитьТрекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьТрекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DarkOrchid;
			this.button1.Location = new System.Drawing.Point(504, 509);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(248, 87);
			this.button1.TabIndex = 1;
			this.button1.Text = "СЛАВА СЕВЕРСЛАТ ♥СЛАВА СЕВЕРСЛАТ♥АНГЕЛА СЕВЕРСЛАТА КАЖДОМУ ИЗ ВАС♥БОЖЕ ХРАНИ СЕВЕ" +
    "РСЛАТ♥СПАСИБО ВАМ НАША СЕВЕРСЛАТ ♥ХРАНИ СЕВЕРСЛАТ♥Слава СЕВЕРСЛАТ";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// trackBar1
			// 
			this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
			this.trackBar1.LargeChange = 1;
			this.trackBar1.Location = new System.Drawing.Point(24, 466);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(474, 45);
			this.trackBar1.TabIndex = 2;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// progressBar1
			// 
			this.progressBar1.BackColor = System.Drawing.Color.Black;
			this.progressBar1.ForeColor = System.Drawing.Color.Indigo;
			this.progressBar1.Location = new System.Drawing.Point(24, 423);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(473, 37);
			this.progressBar1.Step = 2;
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar1.TabIndex = 3;
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox1.ForeColor = System.Drawing.Color.MediumPurple;
			this.listBox1.Location = new System.Drawing.Point(12, 30);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(164, 353);
			this.listBox1.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.ForeColor = System.Drawing.Color.MediumPurple;
			this.button2.Location = new System.Drawing.Point(317, 30);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(87, 60);
			this.button2.TabIndex = 5;
			this.button2.Text = "Play/Pause";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.ForeColor = System.Drawing.Color.MediumPurple;
			this.button3.Location = new System.Drawing.Point(410, 30);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(87, 60);
			this.button3.TabIndex = 6;
			this.button3.Text = "Stop";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.ForeColor = System.Drawing.Color.MediumPurple;
			this.button4.Location = new System.Drawing.Point(317, 96);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(87, 60);
			this.button4.TabIndex = 7;
			this.button4.Text = "prev track";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.ForeColor = System.Drawing.Color.MediumPurple;
			this.button5.Location = new System.Drawing.Point(410, 96);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(87, 60);
			this.button5.TabIndex = 8;
			this.button5.Text = "next track";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button6.ForeColor = System.Drawing.Color.MediumPurple;
			this.button6.Location = new System.Drawing.Point(317, 162);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(87, 60);
			this.button6.TabIndex = 9;
			this.button6.Text = "Repeat";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button7.ForeColor = System.Drawing.Color.MediumPurple;
			this.button7.Location = new System.Drawing.Point(410, 162);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(87, 60);
			this.button7.TabIndex = 10;
			this.button7.Text = "Shuffle";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(524, 24);
			this.menuStrip1.TabIndex = 11;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// управлениеToolStripMenuItem
			// 
			this.управлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТрекToolStripMenuItem,
            this.удалитьТрекToolStripMenuItem});
			this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
			this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
			this.управлениеToolStripMenuItem.Text = "Управление Треками";
			this.управлениеToolStripMenuItem.Click += new System.EventHandler(this.управлениеToolStripMenuItem_Click);
			// 
			// добавитьТрекToolStripMenuItem
			// 
			this.добавитьТрекToolStripMenuItem.Name = "добавитьТрекToolStripMenuItem";
			this.добавитьТрекToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.добавитьТрекToolStripMenuItem.Text = "Добавить Трек";
			this.добавитьТрекToolStripMenuItem.Click += new System.EventHandler(this.добавитьТрекToolStripMenuItem_Click);
			// 
			// удалитьТрекToolStripMenuItem
			// 
			this.удалитьТрекToolStripMenuItem.Name = "удалитьТрекToolStripMenuItem";
			this.удалитьТрекToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.удалитьТрекToolStripMenuItem.Text = "Удалить Трек";
			this.удалитьТрекToolStripMenuItem.Click += new System.EventHandler(this.удалитьТрекToolStripMenuItem_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::бхс.Properties.Resources.северслатик;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(524, 523);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "t";
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem добавитьТрекToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem удалитьТрекToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

