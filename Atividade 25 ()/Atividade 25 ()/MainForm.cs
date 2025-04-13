/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 03/12/2024
 * Hora: 20:58
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_25___
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			timer1.Enabled = ! timer1.Enabled;
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			pictureBox1.Left += 20;
			if (pictureBox1.Left > this.Width-150)
				timer1.Enabled = false;
		}
	}
}
