using System;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;

namespace PP7_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			for (int i = 0; i < 100; i++)
			{
				backgroundWorker.ReportProgress(i);
				Thread.Sleep(millisecondsTimeout: 100);
			}
		}

		private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.Text = e.ProgressPercentage.ToString();
		}

		private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			MessageBox.Show("Finished!");
			Start_button.Enabled = true;
		}

		private void Start_button_Click(object sender, EventArgs e)
		{
			if (backgroundWorker.IsBusy) backgroundWorker.RunWorkerAsync();
			Start_button.Enabled = false;
		}

		private void MsgBox_button_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Some action");
		}
	}
}
