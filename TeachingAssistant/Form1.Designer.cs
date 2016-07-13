namespace TeachingAssistant
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Уравнения первой степени");
			System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Квадратные уравнения");
			System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Решение уравнений", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22});
			System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Нахождение факториала");
			System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Алгебра", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24});
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.LinearEquation = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxB = new System.Windows.Forms.TextBox();
			this.textBoxA = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Factorial = new System.Windows.Forms.Panel();
			this.QuadraticEquation = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.textBoxC = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxB2 = new System.Windows.Forms.TextBox();
			this.textBoxA2 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.l = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.textBoxF = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.LinearEquation.SuspendLayout();
			this.Factorial.SuspendLayout();
			this.QuadraticEquation.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			treeNode21.Name = "SimpleEquation";
			treeNode21.Text = "Уравнения первой степени";
			treeNode22.Name = "QuadraticEquation";
			treeNode22.Text = "Квадратные уравнения";
			treeNode23.Name = "TheSolutionOfEquations";
			treeNode23.Text = "Решение уравнений";
			treeNode24.Name = "Factorial";
			treeNode24.Text = "Нахождение факториала";
			treeNode25.Name = "Algebra";
			treeNode25.Text = "Алгебра";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode25});
			this.treeView1.Size = new System.Drawing.Size(200, 641);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// LinearEquation
			// 
			this.LinearEquation.Controls.Add(this.button1);
			this.LinearEquation.Controls.Add(this.textBoxB);
			this.LinearEquation.Controls.Add(this.textBoxA);
			this.LinearEquation.Controls.Add(this.label3);
			this.LinearEquation.Controls.Add(this.label2);
			this.LinearEquation.Controls.Add(this.label1);
			this.LinearEquation.Dock = System.Windows.Forms.DockStyle.Right;
			this.LinearEquation.Location = new System.Drawing.Point(-941, 0);
			this.LinearEquation.Name = "LinearEquation";
			this.LinearEquation.Size = new System.Drawing.Size(586, 641);
			this.LinearEquation.TabIndex = 1;
			this.LinearEquation.Visible = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(98, 220);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Ответ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxB
			// 
			this.textBoxB.Location = new System.Drawing.Point(74, 102);
			this.textBoxB.Name = "textBoxB";
			this.textBoxB.Size = new System.Drawing.Size(100, 20);
			this.textBoxB.TabIndex = 4;
			// 
			// textBoxA
			// 
			this.textBoxA.Location = new System.Drawing.Point(74, 38);
			this.textBoxA.Name = "textBoxA";
			this.textBoxA.Size = new System.Drawing.Size(100, 20);
			this.textBoxA.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Введите b: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Введите a: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ax+b=0";
			// 
			// Factorial
			// 
			this.Factorial.Controls.Add(this.button2);
			this.Factorial.Controls.Add(this.textBoxF);
			this.Factorial.Controls.Add(this.label5);
			this.Factorial.Controls.Add(this.label4);
			this.Factorial.Dock = System.Windows.Forms.DockStyle.Right;
			this.Factorial.Location = new System.Drawing.Point(-355, 0);
			this.Factorial.Name = "Factorial";
			this.Factorial.Size = new System.Drawing.Size(561, 641);
			this.Factorial.TabIndex = 2;
			this.Factorial.Visible = false;
			// 
			// QuadraticEquation
			// 
			this.QuadraticEquation.Controls.Add(this.button3);
			this.QuadraticEquation.Controls.Add(this.textBoxC);
			this.QuadraticEquation.Controls.Add(this.label8);
			this.QuadraticEquation.Controls.Add(this.textBoxB2);
			this.QuadraticEquation.Controls.Add(this.textBoxA2);
			this.QuadraticEquation.Controls.Add(this.label7);
			this.QuadraticEquation.Controls.Add(this.label6);
			this.QuadraticEquation.Controls.Add(this.l);
			this.QuadraticEquation.Dock = System.Windows.Forms.DockStyle.Right;
			this.QuadraticEquation.Location = new System.Drawing.Point(206, 0);
			this.QuadraticEquation.Name = "QuadraticEquation";
			this.QuadraticEquation.Size = new System.Drawing.Size(586, 641);
			this.QuadraticEquation.TabIndex = 4;
			this.QuadraticEquation.Visible = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(254, 424);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 8;
			this.button3.Text = "Ответ";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBoxC
			// 
			this.textBoxC.Location = new System.Drawing.Point(74, 180);
			this.textBoxC.Name = "textBoxC";
			this.textBoxC.Size = new System.Drawing.Size(100, 20);
			this.textBoxC.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 183);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Введите c";
			// 
			// textBoxB2
			// 
			this.textBoxB2.Location = new System.Drawing.Point(74, 124);
			this.textBoxB2.Name = "textBoxB2";
			this.textBoxB2.Size = new System.Drawing.Size(100, 20);
			this.textBoxB2.TabIndex = 5;
			// 
			// textBoxA2
			// 
			this.textBoxA2.Location = new System.Drawing.Point(74, 67);
			this.textBoxA2.Name = "textBoxA2";
			this.textBoxA2.Size = new System.Drawing.Size(100, 20);
			this.textBoxA2.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 127);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Введите b";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 70);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Введите a";
			// 
			// l
			// 
			this.l.AutoSize = true;
			this.l.Location = new System.Drawing.Point(251, 9);
			this.l.Name = "l";
			this.l.Size = new System.Drawing.Size(82, 13);
			this.l.TabIndex = 0;
			this.l.Text = "axx + bx + c = 0";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(134, 151);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Ответ";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBoxF
			// 
			this.textBoxF.Location = new System.Drawing.Point(109, 60);
			this.textBoxF.Name = "textBoxF";
			this.textBoxF.Size = new System.Drawing.Size(100, 20);
			this.textBoxF.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Введите число: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Факториал";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.LinearEquation);
			this.panel1.Controls.Add(this.Factorial);
			this.panel1.Controls.Add(this.QuadraticEquation);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(792, 641);
			this.panel1.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.treeView1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 641);
			this.panel2.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 641);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.LinearEquation.ResumeLayout(false);
			this.LinearEquation.PerformLayout();
			this.Factorial.ResumeLayout(false);
			this.Factorial.PerformLayout();
			this.QuadraticEquation.ResumeLayout(false);
			this.QuadraticEquation.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Panel LinearEquation;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxB;
		private System.Windows.Forms.TextBox textBoxA;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel Factorial;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBoxF;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel QuadraticEquation;
		private System.Windows.Forms.Label l;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBoxC;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxB2;
		private System.Windows.Forms.TextBox textBoxA2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}

