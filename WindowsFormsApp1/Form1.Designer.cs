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
         this.button1 = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.scrollPanel1 = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.scrollPanel2 = new System.Windows.Forms.Panel();
         this.panel4 = new System.Windows.Forms.Panel();
         this.pictureBox2 = new System.Windows.Forms.PictureBox();
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.progressBar1 = new System.Windows.Forms.ProgressBar();
         this.lblPath = new System.Windows.Forms.Label();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.groupBox1.SuspendLayout();
         this.scrollPanel1.SuspendLayout();
         this.panel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.groupBox2.SuspendLayout();
         this.scrollPanel2.SuspendLayout();
         this.panel4.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.button1.Location = new System.Drawing.Point(750, 43);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 0;
         this.button1.Text = "Search";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.scrollPanel1);
         this.groupBox1.Location = new System.Drawing.Point(9, 70);
         this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
         this.groupBox1.Size = new System.Drawing.Size(401, 384);
         this.groupBox1.TabIndex = 2;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "groupBox1";
         // 
         // scrollPanel1
         // 
         this.scrollPanel1.AutoScroll = true;
         this.scrollPanel1.Controls.Add(this.panel2);
         this.scrollPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.scrollPanel1.Location = new System.Drawing.Point(2, 15);
         this.scrollPanel1.Name = "scrollPanel1";
         this.scrollPanel1.Size = new System.Drawing.Size(397, 367);
         this.scrollPanel1.TabIndex = 0;
         this.scrollPanel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel1_Scroll);
         // 
         // panel2
         // 
         this.panel2.AutoSize = true;
         this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.panel2.Controls.Add(this.pictureBox1);
         this.panel2.Location = new System.Drawing.Point(0, 0);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(363, 329);
         this.panel2.TabIndex = 1;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Location = new System.Drawing.Point(0, 0);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(360, 326);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pictureBox1.TabIndex = 3;
         this.pictureBox1.TabStop = false;
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.scrollPanel2);
         this.groupBox2.Location = new System.Drawing.Point(426, 70);
         this.groupBox2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
         this.groupBox2.Size = new System.Drawing.Size(401, 384);
         this.groupBox2.TabIndex = 2;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "groupBox1";
         // 
         // scrollPanel2
         // 
         this.scrollPanel2.AutoScroll = true;
         this.scrollPanel2.Controls.Add(this.panel4);
         this.scrollPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.scrollPanel2.Location = new System.Drawing.Point(2, 15);
         this.scrollPanel2.Name = "scrollPanel2";
         this.scrollPanel2.Size = new System.Drawing.Size(397, 367);
         this.scrollPanel2.TabIndex = 0;
         this.scrollPanel2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollPanel2_Scroll);
         // 
         // panel4
         // 
         this.panel4.AutoSize = true;
         this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.panel4.Controls.Add(this.pictureBox2);
         this.panel4.Location = new System.Drawing.Point(0, 0);
         this.panel4.Name = "panel4";
         this.panel4.Size = new System.Drawing.Size(363, 329);
         this.panel4.TabIndex = 1;
         // 
         // pictureBox2
         // 
         this.pictureBox2.Location = new System.Drawing.Point(0, 0);
         this.pictureBox2.Name = "pictureBox2";
         this.pictureBox2.Size = new System.Drawing.Size(360, 326);
         this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pictureBox2.TabIndex = 3;
         this.pictureBox2.TabStop = false;
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
         this.tabControl1.Size = new System.Drawing.Size(862, 510);
         this.tabControl1.TabIndex = 3;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.progressBar1);
         this.tabPage1.Controls.Add(this.lblPath);
         this.tabPage1.Controls.Add(this.button1);
         this.tabPage1.Controls.Add(this.groupBox1);
         this.tabPage1.Controls.Add(this.groupBox2);
         this.tabPage1.Location = new System.Drawing.Point(23, 4);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(835, 502);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Shapify";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // progressBar1
         // 
         this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.progressBar1.Location = new System.Drawing.Point(9, 17);
         this.progressBar1.Name = "progressBar1";
         this.progressBar1.Size = new System.Drawing.Size(816, 23);
         this.progressBar1.TabIndex = 4;
         // 
         // lblPath
         // 
         this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.lblPath.Location = new System.Drawing.Point(8, 43);
         this.lblPath.Name = "lblPath";
         this.lblPath.Size = new System.Drawing.Size(736, 23);
         this.lblPath.TabIndex = 3;
         this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // tabPage2
         // 
         this.tabPage2.Location = new System.Drawing.Point(23, 4);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(835, 502);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "tabPage2";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(862, 510);
         this.Controls.Add(this.tabControl1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
         this.groupBox1.ResumeLayout(false);
         this.scrollPanel1.ResumeLayout(false);
         this.scrollPanel1.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.groupBox2.ResumeLayout(false);
         this.scrollPanel2.ResumeLayout(false);
         this.scrollPanel2.PerformLayout();
         this.panel4.ResumeLayout(false);
         this.panel4.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel scrollPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel scrollPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.Label lblPath;
      private System.Windows.Forms.ProgressBar progressBar1;
   }
}

