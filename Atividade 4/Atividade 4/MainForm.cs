/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 13/08/2024
 * Hora: 20:05
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_4
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			float km1 = float.Parse (textBox1.Text);
			float km2 = float.Parse (textBox2.Text);
			float p1 = km1 + (km2 - km1)/4;
			float p2 = km1 + (km2 - km1)/4 * 2;
			float p3 = km1 + (km2 - km1)/4 * 3;
			label6.Text = p1.ToString();
			label7.Text = p2.ToString();
			label8.Text = p3.ToString();
		}
	}
}
