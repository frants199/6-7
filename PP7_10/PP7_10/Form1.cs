﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP7_10
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (Control c in Controls)
			{
				// Если элемент есть потомок класса ButtonBase,
				if (c is ButtonBase)
				{
					// то применяем стиль Системы.
					((ButtonBase)c).FlatStyle = FlatStyle.System;
				}
			}
		}
	}
}
