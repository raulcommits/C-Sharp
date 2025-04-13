/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 12/08/2024
 * Hora: 19:36
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			

		}
		void Button1Click(object sender, EventArgs e)
		{
			int	n1, n2, n3, multiply;
			n1 = int.Parse (textBox1.Text);
			n2 = int.Parse (textBox2.Text);
			n3 = int.Parse (textBox3.Text);
			multiply = (n1*365) + (n2*30) + (n3);
			textBox4.Text = multiply.ToString();
		}
	}
}
