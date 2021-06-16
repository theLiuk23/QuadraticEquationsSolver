using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Eq.grado2
{
	public partial class Settings : Form
	{
		#region variables
		public static int cifreDecimali = 2;
		public static string filePath = @"F:\C#\Logs";
		public static bool changedPath = false;
		public static string fileName = "log_" + DateTime.Now.ToString("yyyy-M-dd-H-mm-ss") + ".txt";
		public static bool boolShowLabels = true;
		#endregion

		public Settings()
		{
			InitializeComponent();
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			changedPath = false;
			cdBox.Text = Convert.ToString(cifreDecimali);
			if (boolShowLabels == true)
			{
				yes_label.Checked = true;
			}
			else
			{
				no_label.Checked = true;
			}
		}

		private void cdBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				cifreDecimali = Convert.ToInt32(cdBox.Text);
			}
			catch
			{
				MessageBox.Show("Errore durante la conversione dell'input in una variabile di tipo 'int'", "Errore");
			}
		}

		private void bottoneOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void directoryButton_Click(object sender, EventArgs e)
		{
			CommonOpenFileDialog dialog = new CommonOpenFileDialog();
			dialog.InitialDirectory = filePath;
			dialog.IsFolderPicker = true;

			if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
			{
				filePath = dialog.FileName;
				directoryLabel.Text = filePath;
				changedPath = true;
			}
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			fileName = richTextBox1.Text + ".txt";
		}

		private void yes_label_CheckedChanged(object sender, EventArgs e)
		{
			boolShowLabels = true;
		}

		private void no_label_CheckedChanged(object sender, EventArgs e)
		{
			boolShowLabels = false;
		}
	}
}