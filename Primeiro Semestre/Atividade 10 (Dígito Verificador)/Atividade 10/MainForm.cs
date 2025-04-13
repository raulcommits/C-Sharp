/*
 * Criado por SharpDevelop.
 * Usuário: raul
 * Data: 07/09/2024
 * Hora: 22:40
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_10
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			

		}
		void Button1Click(object sender, EventArgs e)
		{
	        string s = textBox1.Text;
			int n1 = int.Parse (s[0].ToString() ) *1;
			int n2 = int.Parse (s[1].ToString() ) *2;
			int n3 = int.Parse (s[2].ToString() ) *3;
			int n4 = int.Parse (s[3].ToString() ) *4;
			int n5 = int.Parse (s[4].ToString() ) *5;
			int soma = (n1 + n2 + n3 + n4 + n5);
			string aux = soma.ToString();
			char dv = aux[0];
			label2.Text = dv.ToString();
		}
		//void Label3Click(object sender, EventArgs e)
		//{
	
		//}
		//void Label2Click(object sender, EventArgs e)
		//{
	
		//}
		//void Label3Click(object sender, EventArgs e)
		//{
	
		//}
	}
}
