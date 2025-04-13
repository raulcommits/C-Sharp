/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 12/08/2024
 * Hora: 19:36
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Atividade_1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(61, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Idade (anos):";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(61, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Idade (meses):";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(245, 67);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(186, 26);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(245, 129);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(186, 26);
			this.textBox2.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(626, 237);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(166, 42);
			this.button1.TabIndex = 4;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(245, 196);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(186, 26);
			this.textBox3.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(61, 197);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 26);
			this.label3.TabIndex = 6;
			this.label3.Text = "Idade (dias):";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(626, 126);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(166, 26);
			this.textBox4.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(626, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(166, 27);
			this.label4.TabIndex = 8;
			this.label4.Text = "Idade em Dias:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.ClientSize = new System.Drawing.Size(905, 359);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Atividade 1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
