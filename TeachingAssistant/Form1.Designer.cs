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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Уравнения первой степени");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Решение уравнений", new System.Windows.Forms.TreeNode[] {
            treeNode1});
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Нахождение факториала");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Алгебра", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.LinearEquation = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxA = new System.Windows.Forms.TextBox();
			this.textBoxB = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.Factorial = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxF = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.LinearEquation.SuspendLayout();
			this.Factorial.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "SimpleEquation";
			treeNode1.Text = "Уравнения первой степени";
			treeNode2.Name = "TheSolutionOfEquations";
			treeNode2.Text = "Решение уравнений";
			treeNode3.Name = "Factorial";
			treeNode3.Text = "Нахождение факториала";
			treeNode4.Name = "Algebra";
			treeNode4.Text = "Алгебра";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
			this.treeView1.Size = new System.Drawing.Size(403, 647);
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
			this.LinearEquation.Location = new System.Drawing.Point(409, 12);
			this.LinearEquation.Name = "LinearEquation";
			this.LinearEquation.Size = new System.Drawing.Size(385, 617);
			this.LinearEquation.TabIndex = 1;
			this.LinearEquation.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ax+b=0";
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Введите b: ";
			// 
			// textBoxA
			// 
			this.textBoxA.Location = new System.Drawing.Point(74, 38);
			this.textBoxA.Name = "textBoxA";
			this.textBoxA.Size = new System.Drawing.Size(100, 20);
			this.textBoxA.TabIndex = 3;
			// 
			// textBoxB
			// 
			this.textBoxB.Location = new System.Drawing.Point(74, 102);
			this.textBoxB.Name = "textBoxB";
			this.textBoxB.Size = new System.Drawing.Size(100, 20);
			this.textBoxB.TabIndex = 4;
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
			// Factorial
			// 
			this.Factorial.Controls.Add(this.button2);
			this.Factorial.Controls.Add(this.textBoxF);
			this.Factorial.Controls.Add(this.label5);
			this.Factorial.Controls.Add(this.label4);
			this.Factorial.Location = new System.Drawing.Point(409, 11);
			this.Factorial.Name = "Factorial";
			this.Factorial.Size = new System.Drawing.Size(382, 618);
			this.Factorial.TabIndex = 2;
			this.Factorial.Visible = false;
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Введите число: ";
			// 
			// textBoxF
			// 
			this.textBoxF.Location = new System.Drawing.Point(109, 60);
			this.textBoxF.Name = "textBoxF";
			this.textBoxF.Size = new System.Drawing.Size(100, 20);
			this.textBoxF.TabIndex = 2;
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 641);
			this.Controls.Add(this.Factorial);
			this.Controls.Add(this.LinearEquation);
			this.Controls.Add(this.treeView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.LinearEquation.ResumeLayout(false);
			this.LinearEquation.PerformLayout();
			this.Factorial.ResumeLayout(false);
			this.Factorial.PerformLayout();
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
	}
}

