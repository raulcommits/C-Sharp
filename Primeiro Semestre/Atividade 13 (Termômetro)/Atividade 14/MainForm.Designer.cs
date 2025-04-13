/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 17/09/2024
 * Time: 21:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade_14
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(58, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(257, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Insira a temperatura atual";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(352, 63);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(128, 26);
			this.textBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Location = new System.Drawing.Point(575, 112);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 93);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(58, 238);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(211, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Aviso de Temperatura:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(809, 350);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Atividade 14";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
