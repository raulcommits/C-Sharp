/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 30/09/2024
 * Time: 20:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade_17__For_
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(305, 73);
			this.listBox1.Name = "listBox1";
			this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.listBox1.Size = new System.Drawing.Size(273, 204);
			this.listBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(87, 240);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(148, 75);
			this.button1.TabIndex = 1;
			this.button1.Text = "LETRA";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(104, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "Uma Palavra";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(52, 73);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(208, 26);
			this.textBox1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(122, 131);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "Letra";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(122, 176);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(51, 26);
			this.textBox2.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 359);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
			this.Name = "MainForm";
			this.Text = "Atividade 17 (For)";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
