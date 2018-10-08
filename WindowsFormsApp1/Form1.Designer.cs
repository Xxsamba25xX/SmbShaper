namespace WindowsFormsApp1
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
         this.button1 = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.scrollPanel1 = new System.Windows.Forms.Panel();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.pnPresentation = new System.Windows.Forms.Panel();
         this.button2 = new System.Windows.Forms.Button();
         this.pictureBox4 = new System.Windows.Forms.PictureBox();
         this.label2 = new System.Windows.Forms.Label();
         this.pictureBox3 = new System.Windows.Forms.PictureBox();
         this.label1 = new System.Windows.Forms.Label();
         this.progressBar1 = new System.Windows.Forms.ProgressBar();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.groupBox1.SuspendLayout();
         this.scrollPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.pnPresentation.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.button1.Location = new System.Drawing.Point(11, 9);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(811, 21);
         this.button1.TabIndex = 0;
         this.button1.Text = "Search";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.scrollPanel1);
         this.groupBox1.Location = new System.Drawing.Point(9, 116);
         this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
         this.groupBox1.Size = new System.Drawing.Size(816, 382);
         this.groupBox1.TabIndex = 2;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "groupBox1";
         // 
         // scrollPanel1
         // 
         this.scrollPanel1.AutoScroll = true;
         this.scrollPanel1.Controls.Add(this.pictureBox1);
         this.scrollPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.scrollPanel1.Location = new System.Drawing.Point(2, 15);
         this.scrollPanel1.Name = "scrollPanel1";
         this.scrollPanel1.Size = new System.Drawing.Size(812, 365);
         this.scrollPanel1.TabIndex = 0;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Location = new System.Drawing.Point(3, 3);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(360, 326);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pictureBox1.TabIndex = 3;
         this.pictureBox1.TabStop = false;
         // 
         // tabControl1
         // 
         this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControl1.Location = new System.Drawing.Point(0, 0);
         this.tabControl1.Multiline = true;
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(862, 516);
         this.tabControl1.TabIndex = 3;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.button1);
         this.tabPage1.Controls.Add(this.pnPresentation);
         this.tabPage1.Controls.Add(this.groupBox1);
         this.tabPage1.Location = new System.Drawing.Point(23, 4);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(835, 508);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Shapify";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // pnPresentation
         // 
         this.pnPresentation.Controls.Add(this.button2);
         this.pnPresentation.Controls.Add(this.pictureBox4);
         this.pnPresentation.Controls.Add(this.label2);
         this.pnPresentation.Controls.Add(this.pictureBox3);
         this.pnPresentation.Controls.Add(this.label1);
         this.pnPresentation.Controls.Add(this.progressBar1);
         this.pnPresentation.Location = new System.Drawing.Point(9, 8);
         this.pnPresentation.Name = "pnPresentation";
         this.pnPresentation.Size = new System.Drawing.Size(816, 104);
         this.pnPresentation.TabIndex = 5;
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(727, 54);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(86, 43);
         this.button2.TabIndex = 9;
         this.button2.Text = "Next Steps";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // pictureBox4
         // 
         this.pictureBox4.Location = new System.Drawing.Point(3, 80);
         this.pictureBox4.Name = "pictureBox4";
         this.pictureBox4.Size = new System.Drawing.Size(20, 20);
         this.pictureBox4.TabIndex = 8;
         this.pictureBox4.TabStop = false;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(29, 84);
         this.label2.Margin = new System.Windows.Forms.Padding(3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(56, 13);
         this.label2.TabIndex = 7;
         this.label2.Text = "Shapifying";
         // 
         // pictureBox3
         // 
         this.pictureBox3.Location = new System.Drawing.Point(3, 54);
         this.pictureBox3.Name = "pictureBox3";
         this.pictureBox3.Size = new System.Drawing.Size(20, 20);
         this.pictureBox3.TabIndex = 6;
         this.pictureBox3.TabStop = false;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(29, 58);
         this.label1.Margin = new System.Windows.Forms.Padding(3);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(61, 13);
         this.label1.TabIndex = 5;
         this.label1.Text = "Normalizing";
         // 
         // progressBar1
         // 
         this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.progressBar1.Location = new System.Drawing.Point(3, 27);
         this.progressBar1.Name = "progressBar1";
         this.progressBar1.Size = new System.Drawing.Size(810, 21);
         this.progressBar1.TabIndex = 4;
         // 
         // tabPage2
         // 
         this.tabPage2.Location = new System.Drawing.Point(23, 4);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(835, 508);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "tabPage2";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // timer1
         // 
         this.timer1.Interval = 500;
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(862, 516);
         this.Controls.Add(this.tabControl1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
         this.groupBox1.ResumeLayout(false);
         this.scrollPanel1.ResumeLayout(false);
         this.scrollPanel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.pnPresentation.ResumeLayout(false);
         this.pnPresentation.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
         this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel scrollPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.ProgressBar progressBar1;
      private System.Windows.Forms.Timer timer1;
      private System.Windows.Forms.Panel pnPresentation;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.PictureBox pictureBox4;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.PictureBox pictureBox3;
      private System.Windows.Forms.Label label1;
   }
}

