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

			if (string.IsNullOrWhiteSpace(strA) || string.IsNullOrWhiteSpace(strB) || string.IsNullOrWhiteSpace(strC))
			{
				MessageBox.Show("Введите a, b, c");
				return;
			}

			Double a = Convert.ToDouble(strA);
			Double b = Convert.ToDouble(strB);
			Double c = Convert.ToDouble(strC);
			MessageBox.Show("Если х = 0, то y= " + (-c / b));
			MessageBox.Show("Если у = 0, то x= " + (-c/a));

			DrawGraphic();
		}

		private void DrawGraphic()
		{
			var halfX = Graphic.ClientRectangle.Width / 2;
			var halfY = Graphic.ClientRectangle.Height / 2;

			
			drawLine(halfX + -100, halfY, halfX + 100, halfY);



			drawLine(halfX, halfY -100, halfX, halfY + 100);

			DrawText("x", halfX+ 100, halfY);
			DrawText("y", halfX, halfY - 100);


			var offsetX = 0;
			var offsetY = 0;



			drawPoint(halfX + offsetX, halfY + offsetY);

			
		}
		public void drawPoint(int x, int y)
		{
			Graphics g = Graphics.FromHwnd(Graphic.Handle);
			SolidBrush brush = new SolidBrush(Color.LimeGreen);
			Point dPoint = new Point(x, (Graphic.Height - y));
			dPoint.X = dPoint.X - 2;
			dPoint.Y = dPoint.Y - 2;
			Rectangle rect = new Rectangle(dPoint, new Size(4, 4));
			g.FillRectangle(brush, rect);

			g.Dispose();
		}

		public void DrawText(string text, int x, int y)
		{
			Graphics g = Graphics.FromHwnd(Graphic.Handle);
			using (Font myFont = new Font("Arial", 8))
			{
				g.DrawString(text, myFont, Brushes.Black, new Point(x, y));
			}
			g.Dispose();
		}


		public void drawLine(int x1, int y1, int x2, int y2)
		{
			Graphics g = Graphics.FromHwnd(Graphic.Handle);
			Pen mypen = new Pen(Brushes.Black);

			Point dPoint1 = new Point(x1, (Graphic.Height - y1));
			dPoint1.X = dPoint1.X - 2;
			dPoint1.Y = dPoint1.Y - 2;

			Point dPoint2 = new Point(x2, (Graphic.Height - y2));
			dPoint2.X = dPoint2.X - 2;
			dPoint2.Y = dPoint2.Y - 2;

			g.DrawLine(mypen, dPoint1, dPoint2);
			g.Dispose();
		}
	}
}
