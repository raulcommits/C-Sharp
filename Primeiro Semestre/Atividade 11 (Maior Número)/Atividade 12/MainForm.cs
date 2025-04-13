/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 10/09/2024
 * Hora: 20:56
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_12
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			// O usuário tem de digitar 3 números, e ao clicar o botão, o "label5" deve mostrar qual...
			//...deles é o maior
			//nm1 = n1 < n2 && n3;
			//nm2 = n2 < n3 && n1;
			//nm3 = n3 < n1 && n2;
		}
		void Button1Click(object sender, EventArgs e)
		{
			int n1, n2, n3;
			n1 = int.Parse (textBox1.Text);
			n2 = int.Parse (textBox2.Text);
			n3 = int.Parse (textBox3.Text);
			
			if (n1 > n2 && n1 > n3)
			{
				label5.Text = n1.ToString();
			}
			else
				if (n2 > n1 && n2 > n3)
			{
				label5.Text = n2.ToString();
			}
			else
				if (n3 > n1 && n3 > n2)
			{
				label5.Text = n3.ToString();
			}
		}
	}
}
