using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP7_21__30_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private string fileName="";
		private void button1_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				fileName = openFileDialog1.FileName;
				Text = fileName;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string[] fileNames;
				fileNames = openFileDialog1.FileNames;
				foreach (string s in fileNames)
				{
					listBox1.Items.Add(s);
				}
			}
		}
	}
}
