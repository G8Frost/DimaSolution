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
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Квадратные уравнения");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Линейные уравнения с двумя переменными");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Решение уравнений", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Нахождение факториала");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Алгебра", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.LeftPanel = new System.Windows.Forms.Panel();
			this.RightPanel = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.LeftPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "SimpleEquation";
			treeNode1.Text = "Уравнения первой степени";
			treeNode2.Name = "QuadraticEquation";
			treeNode2.Text = "Квадратные уравнения";
			treeNode3.Name = "Equation";
			treeNode3.Text = "Линейные уравнения с двумя переменными";
			treeNode4.Name = "TheSolutionOfEquations";
			treeNode4.Text = "Решение уравнений";
			treeNode5.Name = "Factorial";
			treeNode5.Text = "Нахождение факториала";
			treeNode6.Name = "Algebra";
			treeNode6.Text = "Алгебра";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
			this.treeView1.Size = new System.Drawing.Size(263, 641);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.RightPanel);
			this.panel1.Controls.Add(this.LeftPanel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(792, 641);
			this.panel1.TabIndex = 5;
			// 
			// LeftPanel
			// 
			this.LeftPanel.Controls.Add(this.treeView1);
			this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.LeftPanel.Location = new System.Drawing.Point(0, 0);
			this.LeftPanel.Name = "LeftPanel";
			this.LeftPanel.Size = new System.Drawing.Size(263, 641);
			this.LeftPanel.TabIndex = 5;
			// 
			// RightPanel
			// 
			this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.RightPanel.Location = new System.Drawing.Point(269, 0);
			this.RightPanel.Name = "RightPanel";
			this.RightPanel.Size = new System.Drawing.Size(523, 641);
			this.RightPanel.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 641);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.LeftPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel LeftPanel;
		private System.Windows.Forms.Panel RightPanel;
	}
}

