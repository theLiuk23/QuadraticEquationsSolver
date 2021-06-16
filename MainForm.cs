using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;

namespace Eq.grado2
{
	public partial class MainForm : Form
	{
		#region variabili
		public static double a, b, c;
		public static double delta, x1, x2;
		public int cifreDecimali = 2;
		public bool changedPath = false;
		private bool boolLog = false;

		Form mainForm;
		Settings settings = new Settings();
		ParabolaForm parabola = new ParabolaForm();

		public List<string> fileText = new List<string>();
		Bitmap bm;

		public string fileName = "log_" + DateTime.Now.ToString("yyyy-M-dd-H-mm-ss") + ".txt";
		public string filePath = @"F:\C#\Logs";
		public string blog = "https://lucadallavilla.altervista.org";
		public string mathSite = "https://www.youmath.it/lezioni/algebra-elementare/equazioni/68-equazioni-di-secondo-grado-ad-unincognita-come-si-risolvono.html#:~:text=Risolvere%20un%27equazione%20in%20questa,calcolo%20diretto%20delle%20eventuali%20soluzioni.&text=A%20voi%20il%20compito%20di,esattamente%20le%20soluzioni%20appena%20scritte.";

		public byte[] info; // testo finale log
		public string testo1;
		public string testo2;
		public string testo3;
		public string testo4;
		public string testo5;
		#endregion

		public MainForm()
		{
			InitializeComponent();

			// imposta il cursore al centro dello schermo
			Cursor.Position = new Point((int)System.Windows.SystemParameters.WorkArea.Width / 2, (int)System.Windows.SystemParameters.WorkArea.Height / 2);
		}

		// click bottone - CALCOLA
		private void bottoneCalcola_Click(object sender, EventArgs e)
		{
			Calcolo();
		}

		// Menu contestuale - PREFERENZE
		private void preferenzeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AskSettings();
		}

		// ?-Aggiornamenti
		private void aggiornamentiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start(blog);
		}

		// ?-Help
		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start(mathSite);
		}

		private void parabolaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (a != 0)
			{
				parabola.ShowDialog();
				// can't show twice
			}
			else
			{
				MessageBox.Show("Valore di a non valido", "Riprova");
			}
		}

		private void stampaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Stampa();
		}

		// quando l'applicazione principale si chiude
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (boolLog == true)
			{
				DialogResult dialog = MessageBox.Show("Chiudo il programma.\nSe hai già eseguito dei calcoli, le variabili sono salvate in un file nella directory: " + filePath + ".\nAprire la cartella?", "Sei sicuro?", MessageBoxButtons.YesNoCancel);
				if (dialog == DialogResult.Yes)
				{
					CloseLog();
					Process.Start(filePath);
				}
				else if (dialog == DialogResult.Cancel)
				{
					e.Cancel = true;
					return;
				}
				else if (dialog == DialogResult.No)
				{
					CloseLog();
				}
			}
		}

		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(bm, 0, 0);
		}

		private void segnalaUnErroreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result3 = MessageBox.Show("Invia una mail a 'ldv.coding@gmail.com'!", "Grazie per la segnalazione", MessageBoxButtons.OKCancel);

			if (result3 == DialogResult.OK)
			{
				Process.Start("https://mail.google.com/mail/u/0/?ogbl#inbox?compose=GTvVlcSKhcDgGxkNrgLSJLSQxKPKjxHvZKqZWmgwjPKDTHchLvWbLsvmxBKFpjgGBzbLTtPJBxFTm");
			}
			if (result3 == DialogResult.Cancel)
			{
				return;
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			DialogResult result2 = MessageBox.Show("Do you want a log to register all the actions made during the usage of the application?", "Settings", MessageBoxButtons.YesNo);
			if (result2 == DialogResult.Yes)
			{
				boolLog = true;
				NativeMethods.AllocConsole();
			}
			else if (result2 == DialogResult.No)
			{
				boolLog = false;
			}
		}

		private void Calcolo()
		{
			// variabili a, b, c
			try
			{
				a = Convert.ToDouble(aBox.Text);
				b = Convert.ToDouble(bBox.Text);
				c = Convert.ToDouble(cBox.Text);
			}
			catch
			{
				MessageBox.Show("Errore durante la conversione dell'input in un numero di tipo 'double'", "Errore");
				aBox.Text = "";
				bBox.Text = "";
				cBox.Text = "";

				return;
			}

			// delta
			delta = Math.Round(Math.Pow(b, 2) - 4 * a * c, cifreDecimali);
			deltaBox.Text = Convert.ToString(delta);

			//scrivo l'equazione
			eqBox.Text = a + "x² + " + b + "x + " + c + " = 0";

			// tutti i casi del valore di delta
			#region delta
			if (delta > 0)
			{
				// x1, x2
				x1 = Math.Round((-b - Math.Sqrt(delta)) / (2 * a), cifreDecimali);
				x2 = Math.Round((-b + Math.Sqrt(delta)) / (2 * a), cifreDecimali);

				// scrivo i risultati
				x1Box.Text = Convert.ToString(x1);
				x2Box.Text = Convert.ToString(x2);
			}
			else if (delta < 0)
			{
				MessageBox.Show("Delta < 0. Non ci sono soluzioni esistenti in campo reale", "Errore durante il calcolo della radice del delta");
				x1Box.Text = "delta < 0!";
				x2Box.Text = "delta < 0!";
				x1 = -2147483647;
				x2 = -2147483647;
			}
			else if (delta == 0)
			{
				x1 = Math.Round((-b - Math.Sqrt(delta)) / (2 * a), cifreDecimali);
				x2 = Math.Round((-b + Math.Sqrt(delta)) / (2 * a), cifreDecimali);

				MessageBox.Show("Delta = 0. Le due soluzioni saranno coincidenti", "Informazione sul delta");
				x1Box.Text = Convert.ToString(x1);
				x2Box.Text = Convert.ToString(x2);
			}
			else
			{
				MessageBox.Show("Errore imprevisto. Il delta non risulta né maggiore né minore né uguale a zero", "Errore durante il calcolo della radice del delta");
				x1Box.Text = "Errore, riprova!";
				x2Box.Text = "Errore, riprova!";
			}
			#endregion

			if (delta < 0)
			{
				testo1 = "Ho calcolato x1=nullo e x2=nullo (delta < 0) con le variabili inserite: a=" + a + "; b=" + b + "; c=" + c + "; - " + DateTime.Now;
			}
			else
			{
				testo1 = "Ho calcolato x1=" + x1 + " e x2=" + x2 + " con le variabili inserite: a=" + a + "; b=" + b + "; c=" + c + "; - " + DateTime.Now;
			}

			if (boolLog == true)
			{
				Console.WriteLine(testo1);
				fileText.Add(testo1);
			}
		}

		private void AskSettings()
		{
			if (boolLog == true)
			{
				testo3 = "Ho aperto le impostazioni - " + DateTime.Now;
				Console.WriteLine(testo3);
				fileText.Add(testo3);
			}

			settings.ShowDialog();
			if (settings.DialogResult == DialogResult.OK)
			{
				cifreDecimali = Settings.cifreDecimali;
				filePath = Settings.filePath;
				changedPath = Settings.changedPath;
				fileName = Settings.fileName;
			}

			if (changedPath && boolLog == true)
			{
				testo4 = "Ho cambiato la directory - " + DateTime.Now;
				Console.WriteLine(testo4);
				fileText.Add(testo4);

				changedPath = false;
			}
		}

		private void CloseLog()
		{
			if (boolLog == true)
			{
				testo2 = "Sto chiudendo il log - " + DateTime.Now;
				Console.WriteLine();
				fileText.Add(testo2);

				try
				{
					if (Directory.Exists(filePath))
					{
						using (FileStream fs = File.Create(filePath + "\\" + fileName))
						{
							int indexNum = fileText.Count;

							for (int i = 0; i < indexNum; i++)
							{
								info = new UTF8Encoding(true).GetBytes(fileText[i] + "\n");
								fs.Write(info, 0, info.Length);
							}
						}
					}
					else
					{
						Directory.CreateDirectory(filePath);

						using (FileStream fs = File.Create(filePath + "\\" + fileName))
						{
							int indexNum = fileText.Count;

							for (int i = 0; i < indexNum; i++)
							{
								info = new UTF8Encoding(true).GetBytes(fileText[i] + "\n");
								fs.Write(info, 0, info.Length);
							}
						}
					}
				}
				catch (Exception e)
				{
					MessageBox.Show(e.Message);
					return;
				}

				testo3 = "Ho salvato i comandi nel file di nome: " + fileName + " nella cartella di directory: " + filePath + " - " + DateTime.Now;
				Console.WriteLine();
				fileText.Add(testo3);

				NativeMethods.FreeConsole();
			}
		}

		private void Stampa()
		{
			mainForm = Form.ActiveForm;
			bm = new Bitmap(mainForm.Width, mainForm.Height);

			mainForm.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
			printPreviewDialog1.ShowDialog();
		}
	}

	// aprire e chiudere console per il log
	internal sealed class NativeMethods
	{
		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();

		[DllImport("kernel32.dll")]
		public static extern bool FreeConsole();
	}
}