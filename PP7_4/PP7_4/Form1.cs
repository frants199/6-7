using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP7_4
{
	public partial class Form1 : Form
	{
		public int num = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void Begin_button_Click(object sender, EventArgs e)
		{
			num++;
			ToolStripMenuItem mi = new ToolStripMenuItem(num.ToString());
			mi.Click += this.menuToolStripMenuItem_Click;
			menuToolStripMenuItem.DropDownItems.Add(mi);
		}
		private void menuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string s = ((ToolStripMenuItem)sender).Text;
			MessageBox.Show(s);
		}
		
	}
}
