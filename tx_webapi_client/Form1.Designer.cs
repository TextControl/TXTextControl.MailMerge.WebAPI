namespace tx_webapi_client
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textControl1 = new TXTextControl.TextControl();
			ribbon1 = new TXTextControl.Windows.Forms.Ribbon.Ribbon();
			ribbonReportingTab1 = new TXTextControl.Windows.Forms.Ribbon.RibbonReportingTab();
			button1 = new Button();
			button2 = new Button();
			splitContainer1 = new SplitContainer();
			button3 = new Button();
			ribbon1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// textControl1
			// 
			textControl1.Dock = DockStyle.Fill;
			textControl1.Font = new Font("Arial", 10F);
			textControl1.FormattingPrinter = "Standard";
			textControl1.Location = new Point(0, 118);
			textControl1.Name = "textControl1";
			textControl1.Ribbon = ribbon1;
			textControl1.Size = new Size(645, 490);
			textControl1.TabIndex = 0;
			textControl1.Text = "textControl1";
			textControl1.UserNames = null;
			// 
			// ribbon1
			// 
			ribbon1.Controls.Add(ribbonReportingTab1);
			ribbon1.Dock = DockStyle.Top;
			ribbon1.Font = new Font("Segoe UI", 9F);
			ribbon1.HotTrack = true;
			ribbon1.Location = new Point(0, 0);
			ribbon1.Name = "ribbon1";
			ribbon1.SelectedIndex = 1;
			ribbon1.Size = new Size(645, 118);
			ribbon1.TabIndex = 1;
			ribbon1.Text = "ribbon1";
			// 
			// ribbonReportingTab1
			// 
			ribbonReportingTab1.Location = new Point(4, 24);
			ribbonReportingTab1.Name = "ribbonReportingTab1";
			ribbonReportingTab1.Size = new Size(637, 90);
			ribbonReportingTab1.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new Point(85, 24);
			button1.Name = "button1";
			button1.Size = new Size(94, 38);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(138, 104);
			button2.Name = "button2";
			button2.Size = new Size(145, 57);
			button2.TabIndex = 2;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(textControl1);
			splitContainer1.Panel1.Controls.Add(ribbon1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(button3);
			splitContainer1.Panel2.Controls.Add(button2);
			splitContainer1.Panel2.Controls.Add(button1);
			splitContainer1.Size = new Size(1048, 608);
			splitContainer1.SplitterDistance = 645;
			splitContainer1.TabIndex = 3;
			// 
			// button3
			// 
			button3.Location = new Point(51, 247);
			button3.Name = "button3";
			button3.Size = new Size(194, 92);
			button3.TabIndex = 3;
			button3.Text = "button3";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1048, 608);
			Controls.Add(splitContainer1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ribbon1.ResumeLayout(false);
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TXTextControl.TextControl textControl1;
		private Button button1;
		private Button button2;
		private SplitContainer splitContainer1;
		private TXTextControl.Windows.Forms.Ribbon.Ribbon ribbon1;
		private TXTextControl.Windows.Forms.Ribbon.RibbonReportingTab ribbonReportingTab1;
		private Button button3;
	}
}
