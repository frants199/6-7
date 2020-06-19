﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP7_20__30_
{
	public partial class Form1 : Form
	{
		Font userFont = DefaultFont;
		public Form1()
		{
			InitializeComponent();
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.DrawString("Test", userFont, Brushes.Blue, 20, 20);
			base.OnPaint(e);
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (fontDialog1.ShowDialog() == DialogResult.OK)
			{
				// Получение шрифта из диалогового окна.
				userFont = fontDialog1.Font;
				// Перерисовка формы.
				Invalidate();
			}
		}
	}
}
