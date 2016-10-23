namespace TeachingAssistant
{
	partial class QuadraticEquation
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button3 = new System.Windows.Forms.Button();
			this.textBoxC = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxB2 = new System.Windows.Forms.TextBox();
			this.textBoxA2 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.l = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(104, 286);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 16;
			this.button3.Text = "Ответ";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBoxC
			// 
			this.textBoxC.Location = new System.Drawing.Point(104, 202);
			this.textBoxC.Name = "textBoxC";
			this.textBoxC.Size = new System.Drawing.Size(100, 20);
			this.textBoxC.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(33, 205);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Введите c";
			// 
			// textBoxB2
			// 
			this.textBoxB2.Location = new System.Drawing.Point(104, 146);
			this.textBoxB2.Name = "textBoxB2";
			this.textBoxB2.Size = new System.Drawing.Size(100, 20);
			this.textBoxB2.TabIndex = 13;
			// 
			// textBoxA2
			// 
			this.textBoxA2.Location = new System.Drawing.Point(104, 89);
			this.textBoxA2.Name = "textBoxA2";
			this.textBoxA2.Size = new System.Drawing.Size(100, 20);
			this.textBoxA2.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(33, 149);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Введите b";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(33, 92);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Введите a";
			// 
			// l
			// 
			this.l.AutoSize = true;
			this.l.Location = new System.Drawing.Point(281, 31);
			this.l.Name = "l";
			this.l.Size = new System.Drawing.Size(82, 13);
			this.l.TabIndex = 9;
			this.l.Text = "axx + bx + c = 0";
			// 
			// QuadraticEquation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBoxC);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBoxB2);
			this.Controls.Add(this.textBoxA2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.l);
			this.Name = "QuadraticEquation";
			this.Size = new System.Drawing.Size(437, 517);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBoxC;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxB2;
		private System.Windows.Forms.TextBox textBoxA2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label l;
	}
}
