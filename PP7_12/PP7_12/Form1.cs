using System;
using System.Windows.Forms;

namespace PP7_12
{

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Получаем тип по имени.
			Type t = Type.GetType("PP7_12" + textBox1.Text);
			// Создаем переменную по типу.
			ISomeInterface w = (PP7_12.ISomeInterface)Activator.CreateInstance(t);
			// Вызываем метод.
			w.SomeMethod();
		}
	}
	public interface ISomeInterface
	{
		void SomeMethod();
	}
	public class Class1 : ISomeInterface
	{
		public void SomeMethod()
		{
			MessageBox.Show("Class1");
		}
	}
	public class Class2 : ISomeInterface
	{
		public void SomeMethod()
		{
			MessageBox.Show("Class2");
		}
	}
}
