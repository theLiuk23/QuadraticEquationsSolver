
namespace Eq.grado2
{
	partial class ParabolaForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParabolaForm));
			this.pannello = new System.Windows.Forms.Panel();
			this.bottoneDisegna = new System.Windows.Forms.Button();
			this.trackBar = new System.Windows.Forms.TrackBar();
			this.zoomLabel = new System.Windows.Forms.Label();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.bottoneStampa = new System.Windows.Forms.Button();
			this.lbl_vertice = new System.Windows.Forms.Label();
			this.lbl_fuoco = new System.Windows.Forms.Label();
			this.lbl_direttrice = new System.Windows.Forms.Label();
			this.lbl_c = new System.Windows.Forms.Label();
			this.lbl_b = new System.Windows.Forms.Label();
			this.lbl_a = new System.Windows.Forms.Label();
			this.box_a = new System.Windows.Forms.TextBox();
			this.box_b = new System.Windows.Forms.TextBox();
			this.box_c = new System.Windows.Forms.TextBox();
			this.bottonePrederenze = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// pannello
			// 
			this.pannello.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pannello.AutoScroll = true;
			this.pannello.Cursor = System.Windows.Forms.Cursors.Cross;
			this.pannello.Location = new System.Drawing.Point(12, 12);
			this.pannello.Name = "pannello";
			this.pannello.Size = new System.Drawing.Size(761, 631);
			this.pannello.TabIndex = 0;
			this.pannello.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pannello_MouseClick);
			// 
			// bottoneDisegna
			// 
			this.bottoneDisegna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bottoneDisegna.Location = new System.Drawing.Point(669, 728);
			this.bottoneDisegna.Name = "bottoneDisegna";
			this.bottoneDisegna.Size = new System.Drawing.Size(104, 53);
			this.bottoneDisegna.TabIndex = 1;
			this.bottoneDisegna.Text = "Disegna";
			this.bottoneDisegna.UseVisualStyleBackColor = true;
			this.bottoneDisegna.Click += new System.EventHandler(this.bottoneDisegna_Click);
			// 
			// trackBar
			// 
			this.trackBar.Location = new System.Drawing.Point(12, 742);
			this.trackBar.Name = "trackBar";
			this.trackBar.Size = new System.Drawing.Size(305, 45);
			this.trackBar.TabIndex = 2;
			this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// zoomLabel
			// 
			this.zoomLabel.AutoSize = true;
			this.zoomLabel.Location = new System.Drawing.Point(128, 771);
			this.zoomLabel.Name = "zoomLabel";
			this.zoomLabel.Size = new System.Drawing.Size(52, 13);
			this.zoomLabel.TabIndex = 3;
			this.zoomLabel.Text = "Zoom=50";
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// bottoneStampa
			// 
			this.bottoneStampa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bottoneStampa.Location = new System.Drawing.Point(559, 728);
			this.bottoneStampa.Name = "bottoneStampa";
			this.bottoneStampa.Size = new System.Drawing.Size(104, 53);
			this.bottoneStampa.TabIndex = 4;
			this.bottoneStampa.Text = "Stampa";
			this.bottoneStampa.UseVisualStyleBackColor = true;
			this.bottoneStampa.Click += new System.EventHandler(this.bottoneStampa_Click);
			// 
			// lbl_vertice
			// 
			this.lbl_vertice.AutoSize = true;
			this.lbl_vertice.Location = new System.Drawing.Point(12, 663);
			this.lbl_vertice.Name = "lbl_vertice";
			this.lbl_vertice.Size = new System.Drawing.Size(58, 13);
			this.lbl_vertice.TabIndex = 5;
			this.lbl_vertice.Text = "Vertice = ()";
			// 
			// lbl_fuoco
			// 
			this.lbl_fuoco.AutoSize = true;
			this.lbl_fuoco.Location = new System.Drawing.Point(12, 685);
			this.lbl_fuoco.Name = "lbl_fuoco";
			this.lbl_fuoco.Size = new System.Drawing.Size(55, 13);
			this.lbl_fuoco.TabIndex = 6;
			this.lbl_fuoco.Text = "Fuoco = ()";
			// 
			// lbl_direttrice
			// 
			this.lbl_direttrice.AutoSize = true;
			this.lbl_direttrice.Location = new System.Drawing.Point(12, 709);
			this.lbl_direttrice.Name = "lbl_direttrice";
			this.lbl_direttrice.Size = new System.Drawing.Size(61, 13);
			this.lbl_direttrice.TabIndex = 7;
			this.lbl_direttrice.Text = "Direttrice = ";
			// 
			// lbl_c
			// 
			this.lbl_c.AutoSize = true;
			this.lbl_c.Location = new System.Drawing.Point(355, 749);
			this.lbl_c.Name = "lbl_c";
			this.lbl_c.Size = new System.Drawing.Size(25, 13);
			this.lbl_c.TabIndex = 8;
			this.lbl_c.Text = "c = ";
			// 
			// lbl_b
			// 
			this.lbl_b.AutoSize = true;
			this.lbl_b.Location = new System.Drawing.Point(355, 705);
			this.lbl_b.Name = "lbl_b";
			this.lbl_b.Size = new System.Drawing.Size(22, 13);
			this.lbl_b.TabIndex = 9;
			this.lbl_b.Text = "b =";
			// 
			// lbl_a
			// 
			this.lbl_a.AutoSize = true;
			this.lbl_a.Location = new System.Drawing.Point(355, 663);
			this.lbl_a.Name = "lbl_a";
			this.lbl_a.Size = new System.Drawing.Size(25, 13);
			this.lbl_a.TabIndex = 10;
			this.lbl_a.Text = "a = ";
			// 
			// box_a
			// 
			this.box_a.Location = new System.Drawing.Point(386, 660);
			this.box_a.Name = "box_a";
			this.box_a.Size = new System.Drawing.Size(100, 20);
			this.box_a.TabIndex = 11;
			// 
			// box_b
			// 
			this.box_b.Location = new System.Drawing.Point(386, 702);
			this.box_b.Name = "box_b";
			this.box_b.Size = new System.Drawing.Size(100, 20);
			this.box_b.TabIndex = 12;
			// 
			// box_c
			// 
			this.box_c.Location = new System.Drawing.Point(386, 742);
			this.box_c.Name = "box_c";
			this.box_c.Size = new System.Drawing.Size(100, 20);
			this.box_c.TabIndex = 13;
			// 
			// bottonePrederenze
			// 
			this.bottonePrederenze.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bottonePrederenze.Location = new System.Drawing.Point(560, 663);
			this.bottonePrederenze.Name = "bottonePrederenze";
			this.bottonePrederenze.Size = new System.Drawing.Size(214, 59);
			this.bottonePrederenze.TabIndex = 14;
			this.bottonePrederenze.Text = "Preferenze";
			this.bottonePrederenze.UseVisualStyleBackColor = true;
			this.bottonePrederenze.Click += new System.EventHandler(this.bottonePrederenze_Click);
			// 
			// ParabolaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(786, 795);
			this.Controls.Add(this.bottonePrederenze);
			this.Controls.Add(this.box_c);
			this.Controls.Add(this.box_b);
			this.Controls.Add(this.box_a);
			this.Controls.Add(this.lbl_a);
			this.Controls.Add(this.lbl_b);
			this.Controls.Add(this.lbl_c);
			this.Controls.Add(this.lbl_direttrice);
			this.Controls.Add(this.lbl_fuoco);
			this.Controls.Add(this.lbl_vertice);
			this.Controls.Add(this.zoomLabel);
			this.Controls.Add(this.bottoneStampa);
			this.Controls.Add(this.trackBar);
			this.Controls.Add(this.bottoneDisegna);
			this.Controls.Add(this.pannello);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximumSize = new System.Drawing.Size(802, 834);
			this.MinimumSize = new System.Drawing.Size(802, 834);
			this.Name = "ParabolaForm";
			this.Text = "Parabola";
			this.Load += new System.EventHandler(this.Parabola_Load);
			((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pannello;
		private System.Windows.Forms.Button bottoneDisegna;
		private System.Windows.Forms.TrackBar trackBar;
		private System.Windows.Forms.Label zoomLabel;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.Button bottoneStampa;
		private System.Windows.Forms.Label lbl_vertice;
		private System.Windows.Forms.Label lbl_fuoco;
		private System.Windows.Forms.Label lbl_direttrice;
		private System.Windows.Forms.Label lbl_c;
		private System.Windows.Forms.Label lbl_b;
		private System.Windows.Forms.Label lbl_a;
		private System.Windows.Forms.TextBox box_a;
		private System.Windows.Forms.TextBox box_b;
		private System.Windows.Forms.TextBox box_c;
		private System.Windows.Forms.Button bottonePrederenze;
	}
}