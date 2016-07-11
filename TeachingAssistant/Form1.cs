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
			if (e.Node.Name == "SimpleEquation")
			{
				LinearEquation.Visible = true;
			}
			if ( e.Node.Name == "Factorial" )
			{
				Factorial.Visible = true;
			}
		}

		

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

		
	}
}
