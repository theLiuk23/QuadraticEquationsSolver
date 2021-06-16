using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Eq.grado2
{
	public partial class ParabolaForm : Form
	{
		#region variabili
		public double a, b, c, delta;
		public int xCentro, yCentro; // centro schermo grafico
		public double xVertice, yVertice;
		public double xFuoco, yFuoco;
		public double direttrice;
		public double zoom = 50;
		public double precisione = 0.5f;
		public int step;
		public bool isParabola = false;

		Pen parabola = new Pen(Color.Red, 3);
		Control ctrl = new Control();

		private List<Point> listaPuntiSx = new List<Point>();
		private List<Point> listaPuntiDx = new List<Point>();

		PrintDocument printDoc = new PrintDocument();
		PrintPreviewDialog previewdlg = new PrintPreviewDialog();

		Label lbl_vertice_pannello;
		Label lbl_x1;
		Label lbl_x2;

		Graphics g;
		Bitmap MemoryImage;
		#endregion

		private void bottoneDisegna_Click(object sender, EventArgs e)
		{
			// annulla linee pannello
			pannello.Refresh();
			// elimina punti precedenti
			listaPuntiDx.Clear();
			listaPuntiSx.Clear();

			try
			{
				a = Convert.ToDouble(box_a.Text);
				b = Convert.ToDouble(box_b.Text);
				c = Convert.ToDouble(box_c.Text);
				delta = b * b - 4 * a * c;
			}
			catch
			{
				MessageBox.Show("Non è stato possibile convertire in variabile 'double' uno dei valori a, b o c", "Errore");
			}

			// centro dello schermo
			xCentro = pannello.Width / 2;
			yCentro = pannello.Height / 2;
			// coordinate
			xVertice = -b / (2 * a);
			yVertice = delta / (4 * a);
			xFuoco = -b / (2 * a);
			yFuoco = (1 - delta) / (4 * a);
			direttrice = (1 + delta) / (-4 * a);

			Assi();
			Griglia();
			Parabola();
		}

		public ParabolaForm()
		{
			InitializeComponent();
			printDoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
		}

		private void bottoneStampa_Click(object sender, EventArgs e)
		{
			GetPrintArea(pannello);
			previewdlg.Document = printDocument1;
			previewdlg.ShowDialog();
		}

		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			Rectangle pageArea = e.PageBounds;
			e.Graphics.DrawImage(MemoryImage, (pageArea.Width / 2) - (pannello.Width / 2), pannello.Location.Y);
		}

		public void GetPrintArea(Panel pannello)
		{
			MemoryImage = new Bitmap(pannello.Width, pannello.Height);
			Rectangle rectangle = new Rectangle(0, 0, pannello.Width, pannello.Height);
			pannello.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pannello.Width, pannello.Height));
		}

		private void bottonePrederenze_Click(object sender, EventArgs e)
		{
			Settings settings = new Settings();
			settings.ShowDialog();
		}

		// MessageBox con coordinate click
		private void pannello_MouseClick(object sender, MouseEventArgs e)
		{
			double xMouse = (double)(e.X - xCentro) / step;
			double yMouse = (double)(-e.Y + yCentro) / step;

			if (Math.Abs(yMouse - Convert.ToInt32(a * xMouse * xMouse + b * xMouse + c)) <= precisione)
			{
				isParabola = true;
			}

			MessageBox.Show("Hai clickato su: (" + Convert.ToString(Math.Round(xMouse, Settings.cifreDecimali)) + "; " + Convert.ToString(Math.Round(yMouse, Settings.cifreDecimali)) + ").\nQuesto punto appartiene alla parabola: " + isParabola);
			isParabola = false;
		}

		private void trackBar_Scroll(object sender, EventArgs e)
		{
			// elimina labels
			if (lbl_vertice_pannello != null)
			{
				lbl_vertice_pannello.Dispose();
			}
			if (lbl_x1 != null)
			{
				lbl_x1.Dispose();
			}
			if (lbl_x2 != null)
			{
				lbl_x2.Dispose();
			}

			zoom = 101 - trackBar.Value;
			zoomLabel.Text = "Zoom=" + zoom;

			step = Convert.ToInt32(pannello.Width / zoom);
			// MessageBox.Show(Convert.ToString(zoom));

			// annulla linee pannello
			pannello.Refresh();
			// elimina punti precedenti
			listaPuntiDx.Clear();
			listaPuntiSx.Clear();

			Assi();
			Griglia();
			Parabola();
		}

		private void Parabola_Load(object sender, EventArgs e)
		{
			// pannello.Name = "Grafico - Luca Dalla Villa";

			// ottiene variabili dal MainForm
			a = MainForm.a;
			b = MainForm.b;
			c = MainForm.c;
			delta = MainForm.delta;

			box_a.Text = Convert.ToString(a);
			box_b.Text = Convert.ToString(b);
			box_c.Text = Convert.ToString(c);

			/* // centro dello schermo
			xCentro = pannello.Width / 2;
			yCentro = pannello.Height / 2;
			// coordinate vertice
			xVertice = -b / (2 * a);
			yVertice = delta / (4 * a);
			xFuoco = -b / (2 * a);
			yFuoco = (1 - delta) / (4 * a);
			direttrice = (1 + delta) / (-4 * a);*/

			step = Convert.ToInt32(pannello.Width / zoom);

			// MessageBox.Show("Questa opzione è ancora in corso d'opera. Non considerarla troppo affidabile", "Errore");

			trackBar.Minimum = 1;
			trackBar.Maximum = 100;
			trackBar.SmallChange = 10;
			trackBar.LargeChange = 10;
			trackBar.Value = (int)zoom;
		}

		public void Assi()
		{
			pannello.Refresh();

			g = pannello.CreateGraphics();
			Pen assi = new Pen(Color.Black, 3);			
			
			g.DrawLine(assi, 0, yCentro, pannello.Width, yCentro);
			g.DrawLine(assi, xCentro, 0, xCentro, pannello.Height);
		}

		public void Griglia()
		{
			g = pannello.CreateGraphics();
			Pen griglia = new Pen(Color.Black, 1);

			if (zoom == 0) { return; }

			//disegna griglia
			for (int i = step; i <= (int)(pannello.Width / 2); i += step)
			{
				// verticali
				g.DrawLine(griglia, i + xCentro, 0, i + xCentro, pannello.Height);
				g.DrawLine(griglia, -i + xCentro, 0, -i + xCentro, pannello.Height);
			}
			for (int i = step; i <= (int)(pannello.Height / 2); i+= step)
			{
				// orizzontali
				g.DrawLine(griglia, 0, i + yCentro, pannello.Width, i + yCentro);
				g.DrawLine(griglia, 0, -i + yCentro, pannello.Width, -i + yCentro);
			}
		}

		public void Parabola()
		{
			// elimina labels
			if (lbl_vertice_pannello != null)
			{
				lbl_vertice_pannello.Dispose();
			}
			if (lbl_x1 != null)
			{
				lbl_x1.Dispose();
			}
			if (lbl_x2 != null)
			{
				lbl_x2.Dispose();
			}

			g = pannello.CreateGraphics();

			// coordinate vertice
			// MessageBox.Show("Vertice={x: " + Convert.ToString(xVertice) + "; y:" + Convert.ToString(yVertice) + "}.");

			// punti dx del vertice
			for (double x = 0; x < xCentro; x++)
			{
				double y = -(a * x * x + b * x + c) / step;

				Point punto = new Point(Convert.ToInt32(x + xCentro + xVertice * step), Convert.ToInt32(y + yCentro + yVertice * step));
				listaPuntiDx.Add(punto);
			}

			// punti sx del vertice
			for (double x = 0; x > -xCentro; x--)
			{
				double y = -(a * x * x + b * x + c) / step;

				Point punto = new Point(Convert.ToInt32(x + xCentro + xVertice * step), Convert.ToInt32(y + yCentro + yVertice * step));
				listaPuntiSx.Add(punto);
			}

			// disegna a dx
			
			for (int i = 0; i < listaPuntiDx.Count; i++)
			{
				if (i+1 == listaPuntiDx.Count) { break; }
				g.DrawLine(parabola, listaPuntiDx[i], listaPuntiDx[i + 1]);
			}

			// disegna a sx
			for (int i = 0; i < listaPuntiSx.Count; i++)
			{
				if (i + 1 == listaPuntiSx.Count) { break; }
				g.DrawLine(parabola, listaPuntiSx[i], listaPuntiSx[i + 1]);
			}

			// modifica label
			lbl_fuoco.Text = "Fuoco: (" + Math.Round(xFuoco, Settings.cifreDecimali) + "; " + Math.Round(-yFuoco, Settings.cifreDecimali) + ")";
			lbl_vertice.Text = "Vertice: (" + Math.Round(xVertice, Settings.cifreDecimali) + "; " + Math.Round(-yVertice, Settings.cifreDecimali) + ")";
			lbl_direttrice.Text = "Direttice: y = " + Math.Round(direttrice, Settings.cifreDecimali);

			if (Settings.boolShowLabels == true)
			{
				// label coordinate vertice - sul pannello
				if (xVertice * step + xCentro <= pannello.Width && yVertice * step + yCentro <= pannello.Height)
				{
					lbl_vertice_pannello = new Label();
					lbl_vertice_pannello.Text = "Vertice";
					lbl_vertice_pannello.Location = new Point(Convert.ToInt32(xVertice * step + xCentro), Convert.ToInt32(yVertice * step + yCentro));
					lbl_vertice_pannello.AutoSize = true;
					pannello.Controls.Add(lbl_vertice_pannello);
				}

				// labels punti sull'asse x
				Point point_x1 = new Point(Convert.ToInt32((-b - Math.Sqrt(delta)) / (2 * a) * step + xCentro), yCentro);
				if (point_x1.X <= pannello.Width && point_x1.Y <= pannello.Height)
				{
					lbl_x1 = new Label();
					lbl_x1.Text = "X₁";
					lbl_x1.Location = point_x1;
					lbl_x1.AutoSize = true;
					pannello.Controls.Add(lbl_x1);
				}

				Point point_x2 = new Point(Convert.ToInt32((-b + Math.Sqrt(delta)) / (2 * a) * step + xCentro), yCentro);
				if (point_x2.X <= pannello.Width && point_x2.Y <= pannello.Height)
				{
					lbl_x2 = new Label();
					lbl_x2.Text = "X₂";
					lbl_x2.Location = point_x2;
					lbl_x2.AutoSize = true;
					pannello.Controls.Add(lbl_x2);
				}

				this.Controls.Add(pannello);
			}
			if (Settings.boolShowLabels == false && lbl_vertice_pannello != null && lbl_x1 != null && lbl_x2 != null)
			{
				lbl_vertice_pannello.Dispose();
				lbl_x1.Dispose();
				lbl_x2.Dispose();
			}

			// MessageBox.Show(Convert.ToString(Settings.cifreDecimali));
		}
	}
}