using System;
using System.Xml;
using System.Windows.Forms;

namespace PP7_3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void get_elements_button_Click(object sender, EventArgs e)
		{
			XmlDocument xml = new XmlDocument();
			xml.Load("1.xml");
			XmlNode d = xml.DocumentElement;
			XmlNodeList xnl = d.ChildNodes;
			for (int i = 0; i < d.ChildNodes.Count; i++)
			{
				MessageBox.Show(xnl[i].Attributes["text"].Value + " " +
				xnl[i].Attributes["rustext"].Value);
			}
		}
	}
}
