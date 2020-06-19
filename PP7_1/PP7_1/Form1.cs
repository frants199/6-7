using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP7_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void calculate_button_Click(object sender, EventArgs e)
		{
			int rezult = 0;
			try
			{
				rezult = Convert.ToInt32(dividend_box.Text) / Convert.ToInt32(divider_box.Text);
				rezult_label.Text = rezult.ToString();
			}
			catch(DivideByZeroException ex)
			{
				DivideByZero_item.Text = ex.Message;
			}
			catch
			{
				rezult_label.Text = "Error!";
			}
			
		}

		private void Ststus_strip_MouseClick(object sender, MouseEventArgs e)
		{
			MessageBox.Show("Clicked ststus bar");
		}

		private void Ststus_strip_Resize(object sender, EventArgs e)
		{
			Ststus_strip.Items[0].Width = Ststus_strip.Width - 200;
		}

		private void Paint_item_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawEllipse(new Pen(Color.Blue, width: 2), 2, 2, 15, 15);
		}
	}
}
