
namespace Eq.grado2
{
	partial class MainForm
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.bottoneCalcola = new System.Windows.Forms.Button();
			this.aBox = new System.Windows.Forms.RichTextBox();
			this.bBox = new System.Windows.Forms.RichTextBox();
			this.cBox = new System.Windows.Forms.RichTextBox();
			this.deltaBox = new System.Windows.Forms.RichTextBox();
			this.x1Box = new System.Windows.Forms.RichTextBox();
			this.x2Box = new System.Windows.Forms.RichTextBox();
			this.eqBox = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.preferenzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.parabolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stampaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.aggiornamentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.segnalaUnErroreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.label8 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bottoneCalcola
			// 
			this.bottoneCalcola.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.bottoneCalcola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.bottoneCalcola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bottoneCalcola.ForeColor = System.Drawing.SystemColors.ControlText;
			this.bottoneCalcola.Location = new System.Drawing.Point(417, 241);
			this.bottoneCalcola.Name = "bottoneCalcola";
			this.bottoneCalcola.Size = new System.Drawing.Size(128, 58);
			this.bottoneCalcola.TabIndex = 0;
			this.bottoneCalcola.Text = "Calcola";
			this.bottoneCalcola.UseVisualStyleBackColor = false;
			this.bottoneCalcola.Click += new System.EventHandler(this.bottoneCalcola_Click);
			// 
			// aBox
			// 
			this.aBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.aBox.BackColor = System.Drawing.Color.White;
			this.aBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aBox.Location = new System.Drawing.Point(66, 50);
			this.aBox.Multiline = false;
			this.aBox.Name = "aBox";
			this.aBox.Size = new System.Drawing.Size(122, 44);
			this.aBox.TabIndex = 1;
			this.aBox.Text = "0";
			// 
			// bBox
			// 
			this.bBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.bBox.BackColor = System.Drawing.Color.White;
			this.bBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bBox.Location = new System.Drawing.Point(66, 100);
			this.bBox.Multiline = false;
			this.bBox.Name = "bBox";
			this.bBox.Size = new System.Drawing.Size(122, 44);
			this.bBox.TabIndex = 2;
			this.bBox.Text = "0";
			// 
			// cBox
			// 
			this.cBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cBox.BackColor = System.Drawing.Color.White;
			this.cBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cBox.Location = new System.Drawing.Point(66, 150);
			this.cBox.Multiline = false;
			this.cBox.Name = "cBox";
			this.cBox.Size = new System.Drawing.Size(122, 44);
			this.cBox.TabIndex = 3;
			this.cBox.Text = "0";
			// 
			// deltaBox
			// 
			this.deltaBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.deltaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.deltaBox.Enabled = false;
			this.deltaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deltaBox.ForeColor = System.Drawing.Color.Black;
			this.deltaBox.Location = new System.Drawing.Point(412, 50);
			this.deltaBox.Name = "deltaBox";
			this.deltaBox.Size = new System.Drawing.Size(122, 44);
			this.deltaBox.TabIndex = 4;
			this.deltaBox.Text = "";
			// 
			// x1Box
			// 
			this.x1Box.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.x1Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.x1Box.Enabled = false;
			this.x1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.x1Box.ForeColor = System.Drawing.Color.Black;
			this.x1Box.Location = new System.Drawing.Point(412, 100);
			this.x1Box.Name = "x1Box";
			this.x1Box.Size = new System.Drawing.Size(122, 44);
			this.x1Box.TabIndex = 5;
			this.x1Box.Text = "";
			// 
			// x2Box
			// 
			this.x2Box.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.x2Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.x2Box.Enabled = false;
			this.x2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.x2Box.ForeColor = System.Drawing.Color.Black;
			this.x2Box.Location = new System.Drawing.Point(412, 150);
			this.x2Box.Name = "x2Box";
			this.x2Box.Size = new System.Drawing.Size(122, 44);
			this.x2Box.TabIndex = 6;
			this.x2Box.Text = "";
			// 
			// eqBox
			// 
			this.eqBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.eqBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.eqBox.Enabled = false;
			this.eqBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eqBox.ForeColor = System.Drawing.Color.Black;
			this.eqBox.Location = new System.Drawing.Point(176, 241);
			this.eqBox.Name = "eqBox";
			this.eqBox.Size = new System.Drawing.Size(224, 58);
			this.eqBox.TabIndex = 7;
			this.eqBox.Text = "";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 25);
			this.label1.TabIndex = 8;
			this.label1.Text = "a";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(36, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 25);
			this.label2.TabIndex = 9;
			this.label2.Text = "b";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(36, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 25);
			this.label3.TabIndex = 10;
			this.label3.Text = "c";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(336, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 25);
			this.label4.TabIndex = 11;
			this.label4.Text = "delta";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(360, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 25);
			this.label5.TabIndex = 12;
			this.label5.Text = "x1";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(360, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 25);
			this.label6.TabIndex = 13;
			this.label6.Text = "x2";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(21, 241);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(136, 50);
			this.label7.TabIndex = 14;
			this.label7.Text = "equazione:\r\nax²+bx+c = 0";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(564, 24);
			this.menuStrip1.TabIndex = 15;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferenzeToolStripMenuItem,
            this.parabolaToolStripMenuItem,
            this.stampaToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// preferenzeToolStripMenuItem
			// 
			this.preferenzeToolStripMenuItem.Name = "preferenzeToolStripMenuItem";
			this.preferenzeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
			this.preferenzeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.preferenzeToolStripMenuItem.Text = "Preferenze";
			this.preferenzeToolStripMenuItem.Click += new System.EventHandler(this.preferenzeToolStripMenuItem_Click);
			// 
			// parabolaToolStripMenuItem
			// 
			this.parabolaToolStripMenuItem.Name = "parabolaToolStripMenuItem";
			this.parabolaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
			this.parabolaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.parabolaToolStripMenuItem.Text = "Parabola";
			this.parabolaToolStripMenuItem.Click += new System.EventHandler(this.parabolaToolStripMenuItem_Click);
			// 
			// stampaToolStripMenuItem
			// 
			this.stampaToolStripMenuItem.Name = "stampaToolStripMenuItem";
			this.stampaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.stampaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.stampaToolStripMenuItem.Text = "Stampa";
			this.stampaToolStripMenuItem.Click += new System.EventHandler(this.stampaToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiornamentiToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.segnalaUnErroreToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
			this.toolStripMenuItem1.Text = "?";
			// 
			// aggiornamentiToolStripMenuItem
			// 
			this.aggiornamentiToolStripMenuItem.Name = "aggiornamentiToolStripMenuItem";
			this.aggiornamentiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
			this.aggiornamentiToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.aggiornamentiToolStripMenuItem.Text = "Aggiornamenti";
			this.aggiornamentiToolStripMenuItem.Click += new System.EventHandler(this.aggiornamentiToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// segnalaUnErroreToolStripMenuItem
			// 
			this.segnalaUnErroreToolStripMenuItem.Name = "segnalaUnErroreToolStripMenuItem";
			this.segnalaUnErroreToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.segnalaUnErroreToolStripMenuItem.Text = "Segnala un errore";
			this.segnalaUnErroreToolStripMenuItem.Click += new System.EventHandler(this.segnalaUnErroreToolStripMenuItem_Click);
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(23, 213);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(307, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "NB= se vuoi usare numeri decimali, usa la virgola, NON il punto!";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(564, 311);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.eqBox);
			this.Controls.Add(this.x2Box);
			this.Controls.Add(this.x1Box);
			this.Controls.Add(this.deltaBox);
			this.Controls.Add(this.cBox);
			this.Controls.Add(this.bBox);
			this.Controls.Add(this.aBox);
			this.Controls.Add(this.bottoneCalcola);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(580, 350);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Risolutore equazioni di secondo grado";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bottoneCalcola;
		private System.Windows.Forms.RichTextBox aBox;
		private System.Windows.Forms.RichTextBox bBox;
		private System.Windows.Forms.RichTextBox cBox;
		private System.Windows.Forms.RichTextBox deltaBox;
		private System.Windows.Forms.RichTextBox x1Box;
		private System.Windows.Forms.RichTextBox x2Box;
		private System.Windows.Forms.RichTextBox eqBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem preferenzeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem aggiornamentiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem parabolaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stampaToolStripMenuItem;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.ToolStripMenuItem segnalaUnErroreToolStripMenuItem;
		private System.Windows.Forms.Label label8;
	}
}

