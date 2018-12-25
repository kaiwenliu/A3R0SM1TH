namespace A3R0SM1TH
{
	partial class A3R0SM1THform
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A3R0SM1THform));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.generateButton = new System.Windows.Forms.Button();
			this.fileLinkBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.saveDownloader = new System.Windows.Forms.SaveFileDialog();
			this.errorLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Lime;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(66, -23);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(799, 166);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Lime;
			this.pictureBox2.Location = new System.Drawing.Point(-3, -12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(932, 155);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// generateButton
			// 
			this.generateButton.BackColor = System.Drawing.Color.Lime;
			this.generateButton.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.generateButton.ForeColor = System.Drawing.Color.Black;
			this.generateButton.Location = new System.Drawing.Point(442, 330);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(184, 40);
			this.generateButton.TabIndex = 2;
			this.generateButton.Text = "Create Downloader";
			this.generateButton.UseVisualStyleBackColor = false;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// fileLinkBox
			// 
			this.fileLinkBox.Location = new System.Drawing.Point(443, 252);
			this.fileLinkBox.Name = "fileLinkBox";
			this.fileLinkBox.Size = new System.Drawing.Size(183, 22);
			this.fileLinkBox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Silver;
			this.label1.Location = new System.Drawing.Point(440, 206);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(191, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Enter an online link to the file";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Silver;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(45, 202);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(299, 168);
			this.label2.TabIndex = 5;
			this.label2.Text = "Disclaimer: If you decide to \r\nutilize this program for \r\nmalicious rather than \r" +
    "\nexperimental purposes, \r\nyour consequences are not \r\nmy fault, as this program " +
    "was\r\n only made for experimentation";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(705, 206);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(224, 228);
			this.pictureBox3.TabIndex = 6;
			this.pictureBox3.TabStop = false;
			// 
			// errorLabel
			// 
			this.errorLabel.AutoSize = true;
			this.errorLabel.BackColor = System.Drawing.Color.Silver;
			this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorLabel.Location = new System.Drawing.Point(12, 392);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(0, 12);
			this.errorLabel.TabIndex = 7;
			// 
			// A3R0SM1THform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkRed;
			this.ClientSize = new System.Drawing.Size(926, 537);
			this.Controls.Add(this.errorLabel);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.fileLinkBox);
			this.Controls.Add(this.generateButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "A3R0SM1THform";
			this.Text = "A3R0SM1TH";
			this.Load += new System.EventHandler(this.A3R0SM1THform_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.A3R0SM1THform_Paint);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.TextBox fileLinkBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.SaveFileDialog saveDownloader;
		private System.Windows.Forms.Label errorLabel;
	}
}

