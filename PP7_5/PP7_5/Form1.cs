using System;
using System.Windows.Forms;
using System.Drawing;

namespace PP7_5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void cut_Item_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Cut");
		}
		private void copy_Item_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Copy");
		}
		private void paste_Item_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Paste");
		}

		private void Add_button_Click(object sender, EventArgs e)
		{
			ContextMenuStrip cms = new ContextMenuStrip();
			cms.Items.AddRange(new ToolStripItem[]
			{
				this.cut_Item,
				this.copy_Item,
				this.paste_Item
			});
			this.ContextMenuStrip = cms;
		}

		private void get_info_button_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Size: {SystemInformation.PrimaryMonitorSize.ToString()}\n" +
							$"Name: {SystemInformation.ComputerName}\n" +
							$"Mouse buttons: {SystemInformation.MouseButtons}\n" +
							$"Font: {SystemInformation.MenuFont} {SystemInformation.MenuFont.Name}\n" +
							$"Network: {SystemInformation.Network}\n" +
							$"User name: {SystemInformation.UserName}\n");
		}
	}
}
