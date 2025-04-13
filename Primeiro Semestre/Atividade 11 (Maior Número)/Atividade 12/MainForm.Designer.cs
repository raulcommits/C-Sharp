/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 10/09/2024
 * Hora: 20:56
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Atividade_12
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(281, 72);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(129, 26);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(281, 137);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(129, 26);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(281, 204);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(129, 26);
			this.textBox3.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 22);
			this.label1.TabIndex = 3;
			this.label1.Text = "Digite um Número:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(36, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(235, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "Digite um Segundo Número:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(36, 205);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(230, 22);
			this.label3.TabIndex = 5;
			this.label3.Text = "Digite um Terceiro Número:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(537, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(150, 26);
			this.label4.TabIndex = 6;
			this.label4.Text = "Maior Número";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.GhostWhite;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Location = new System.Drawing.Point(525, 161);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(184, 31);
			this.label5.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Plum;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(343, 284);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 54);
			this.button1.TabIndex = 8;
			this.button1.Text = "O Maior é:";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaShell;
			this.ClientSize = new System.Drawing.Size(789, 374);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "Atividade 12";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
