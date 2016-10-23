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
	public partial class Equation : UserControl
	{
		public Equation()
		{
			InitializeComponent();
		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			String strA = textBox1.Text;
			String strB = textBox2.Text;
			String strC = textBox3.Text;
			Double a = Convert.ToDouble(strA);
			Double b = Convert.ToDouble(strB);
			Double c = Convert.ToDouble(strC);
			MessageBox.Show("Если х = 0, то y= " + (-c / b));
			MessageBox.Show("Если у = 0, то x= " + (-c/a));
		}
	}
}
