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
	public partial class LinearEquation : UserControl
	{
		public LinearEquation()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Решение линейных уравнений.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			String strA = textBoxA.Text;
			String strB = textBoxB.Text;
			Double a = Convert.ToDouble(strA);
			Double b = Convert.ToDouble(strB);
			if (a == 0 && b == 0)
			{
				MessageBox.Show("Уравнение имеет бесконечное множество решений");
			}
			if (a == 0 && b != 0)
			{
				MessageBox.Show("Уравнение не имеет решений");
			}
			if (a != 0)
			{
				MessageBox.Show("x= " + (-b / a));
			}
		}
	}
}
