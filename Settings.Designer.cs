
namespace Eq.grado2
{
	partial class Settings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
			this.cdBox = new System.Windows.Forms.ComboBox();
			this.bottoneOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.directoryButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.directoryLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.fileNameLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.yes_label = new System.Windows.Forms.RadioButton();
			this.no_label = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// cdBox
			// 
			this.cdBox.FormattingEnabled = true;
			this.cdBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.cdBox.Location = new System.Drawing.Point(193, 18);
			this.cdBox.Name = "cdBox";
			this.cdBox.Size = new System.Drawing.Size(121, 21);
			this.cdBox.TabIndex = 0;
			this.cdBox.SelectedIndexChanged += new System.EventHandler(this.cdBox_SelectedIndexChanged);
			// 
			// bottoneOK
			// 
			this.bottoneOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bottoneOK.ForeColor = System.Drawing.Color.CadetBlue;
			this.bottoneOK.Location = new System.Drawing.Point(406, 286);
			this.bottoneOK.Name = "bottoneOK";
			this.bottoneOK.Size = new System.Drawing.Size(87, 38);
			this.bottoneOK.TabIndex = 1;
			this.bottoneOK.Text = "OK";
			this.bottoneOK.UseVisualStyleBackColor = true;
			this.bottoneOK.Click += new System.EventHandler(this.bottoneOK_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(22, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Decimal figures: ";
			// 
			// directoryButton
			// 
			this.directoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.directoryButton.ForeColor = System.Drawing.Color.CadetBlue;
			this.directoryButton.Location = new System.Drawing.Point(193, 59);
			this.directoryButton.Name = "directoryButton";
			this.directoryButton.Size = new System.Drawing.Size(121, 40);
			this.directoryButton.TabIndex = 3;
			this.directoryButton.Text = "Choose";
			this.directoryButton.UseVisualStyleBackColor = true;
			this.directoryButton.Click += new System.EventHandler(this.directoryButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 40);
			this.label2.TabIndex = 4;
			this.label2.Text = "Choose Directory of\r\nthe log files:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(350, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "default: 2";
			// 
			// directoryLabel
			// 
			this.directoryLabel.AutoSize = true;
			this.directoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.directoryLabel.Location = new System.Drawing.Point(350, 71);
			this.directoryLabel.Name = "directoryLabel";
			this.directoryLabel.Size = new System.Drawing.Size(143, 20);
			this.directoryLabel.TabIndex = 6;
			this.directoryLabel.Text = "default: F:\\C#\\Logs";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(22, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(149, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Name of the log file:";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(193, 129);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(300, 28);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// fileNameLabel
			// 
			this.fileNameLabel.AutoSize = true;
			this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fileNameLabel.Location = new System.Drawing.Point(22, 169);
			this.fileNameLabel.Name = "fileNameLabel";
			this.fileNameLabel.Size = new System.Drawing.Size(173, 20);
			this.fileNameLabel.TabIndex = 9;
			this.fileNameLabel.Text = "default: log_{date-time}";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(22, 220);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(323, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "Show important points in the parabola panel:";
			// 
			// yes_label
			// 
			this.yes_label.AutoSize = true;
			this.yes_label.Location = new System.Drawing.Point(369, 220);
			this.yes_label.Name = "yes_label";
			this.yes_label.Size = new System.Drawing.Size(43, 17);
			this.yes_label.TabIndex = 11;
			this.yes_label.TabStop = true;
			this.yes_label.Text = "Yes";
			this.yes_label.UseVisualStyleBackColor = true;
			this.yes_label.CheckedChanged += new System.EventHandler(this.yes_label_CheckedChanged);
			// 
			// no_label
			// 
			this.no_label.AutoSize = true;
			this.no_label.Location = new System.Drawing.Point(369, 243);
			this.no_label.Name = "no_label";
			this.no_label.Size = new System.Drawing.Size(39, 17);
			this.no_label.TabIndex = 12;
			this.no_label.TabStop = true;
			this.no_label.Text = "No";
			this.no_label.UseVisualStyleBackColor = true;
			this.no_label.CheckedChanged += new System.EventHandler(this.no_label_CheckedChanged);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkCyan;
			this.ClientSize = new System.Drawing.Size(519, 349);
			this.Controls.Add(this.no_label);
			this.Controls.Add(this.yes_label);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.fileNameLabel);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.directoryLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.directoryButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bottoneOK);
			this.Controls.Add(this.cdBox);
			this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(535, 388);
			this.MinimumSize = new System.Drawing.Size(535, 388);
			this.Name = "Settings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.Settings_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cdBox;
		private System.Windows.Forms.Button bottoneOK;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button directoryButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label directoryLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label fileNameLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton yes_label;
		private System.Windows.Forms.RadioButton no_label;
	}
}