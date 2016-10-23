using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachingAssistant
{
	public partial class QuadraticEquation : UserControl
	{
		public QuadraticEquation()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Решение квадратных уравнений.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click(object sender, EventArgs e)
		{
			String strA = textBoxA2.Text;
			String strB = textBoxB2.Text;
			String strC = textBoxC.Text;
			Double a = Convert.ToDouble(strA);
			Double b = Convert.ToDouble(strB);
			Double c = Convert.ToDouble(strC);
			Double D = b * b - 4 * a * c;
			if (D > 0)
			{
				Double X1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
				Double X2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
				MessageBox.Show("X1= " + X1 + " ; X2= " + X2);
			}
			if (D == 0)
			{
				Double X1 = (-b / 2 * a);
				MessageBox.Show("X1= X2= " + X1);
			}
			if (D < 0)
			{
				MessageBox.Show("Корней нет");
			}
		}
	}
}
