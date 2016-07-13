using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachingAssistant
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void treeView1_AfterSelect( object sender, TreeViewEventArgs e )
		{
			LinearEquation.Visible = false;
			Factorial.Visible = false;
			QuadraticEquation.Visible = false; 
			if (e.Node.Name == "SimpleEquation")
			{
				LinearEquation.Visible = true;
			}
			if ( e.Node.Name == "Factorial" )
			{
				Factorial.Visible = true;
			}
			if (e.Node.Name == "QuadraticEquation")
			{
				QuadraticEquation.Visible = true;
			}
		}

		
		/// <summary>
		/// Решение линейных уравнений.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click( object sender, EventArgs e )
		{
			String strA = textBoxA.Text;
			String strB = textBoxB.Text;
			Double a = Convert.ToDouble(strA);
			Double b = Convert.ToDouble(strB);
			if ( a == 0 && b == 0 )
			{
				MessageBox.Show( "Уравнение имеет бесконечное множество решений" );
			}
			if ( a == 0 && b != 0 )
			{
				MessageBox.Show( "Уравнение не имеет решений" );
			}
			if ( a != 0 )
			{
				MessageBox.Show( "x= " + ( -b / a ) );
			}
		}

		/// <summary>
		/// Находим факториал.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click( object sender, EventArgs e )
		{
			String strF = textBoxF.Text;
			int F = Convert.ToInt32(strF);
			int Result = 1;
			for ( int i = 2; i <= F; i++ )
			{
				Result = Result * i;
			}
			MessageBox.Show( "Ответ: " + Result );
		}
		/// <summary>
		/// Решение квадратных уравнений.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click( object sender, EventArgs e )
		{
			String strA = textBoxA2.Text;
			String strB = textBoxB2.Text;
			String strC = textBoxC.Text;
		    Double a = Convert.ToDouble(strA);
			Double b = Convert.ToDouble(strB);
			Double c = Convert.ToDouble(strC);
			Double D = b*b - 4*a*c;
			if (D > 0)
			{
				Double X1 = (-b + Math.Sqrt(b*b - 4*a*c)) /2*a;
				Double X2 = (-b - Math.Sqrt(b*b - 4*a*c)) /2*a;
				MessageBox.Show("X1= " + X1 +  " ; X2= " + X2);
			}
			if ( D == 0 )
			{
				Double X1 = (-b/2*a);
				MessageBox.Show( "X1= X2= " + X1 );
			}
			if (D < 0)
			{
				MessageBox.Show( "Корней нет" );
			}

		}
	}
}
