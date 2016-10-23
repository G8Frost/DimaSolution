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
	public partial class Factorial : UserControl
	{
		public Factorial()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Находим факториал.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, EventArgs e)
		{
			String strF = textBoxF.Text;
			int F = Convert.ToInt32(strF);
			int Result = 1;
			for (int i = 2; i <= F; i++)
			{
				Result = Result * i;
			}
			MessageBox.Show("Ответ: " + Result);
		}
	}
}
