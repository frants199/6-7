﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP7_13
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			linkLabel1.Links[0].LinkData = "https://microsoft.com";
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Запускаем браузер и открываем в нем страницу.
			System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
		}
	}
}
