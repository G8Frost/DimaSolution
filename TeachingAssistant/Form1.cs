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
			if (e.Node.Name == "SimpleEquation")
			{
				SetPanel(new LinearEquation());
			}
			if ( e.Node.Name == "Factorial" )
			{
				SetPanel(new Factorial());
			}
			if (e.Node.Name == "QuadraticEquation")
			{
				SetPanel(new QuadraticEquation());
			}
			if (e.Node.Name == "Equation")
			{
				SetPanel(new Equation());
			}
		}

		private void SetPanel(UserControl uc)
		{
			RightPanel.Controls.Clear();
			RightPanel.Controls.Add(uc);
		}

	}
}
