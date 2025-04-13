/*
 * Criado por SharpDevelop.
 * Usuário: raul
 * Data: 13/08/2024
 * Hora: 00:18
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_3
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			double sal, inss, salarioLiquido;
			int descontoFaltas, faltas;

		}
		// inss = sal * 0,12
		// descontoFaltas = (sal/30) * faltas
		// salarioLiquido = sal > descontoFaltas > inss
		
		void Button1Click(object sender, EventArgs e)
		{
			double sal = double.Parse (textBox1.Text);
			int faltas = int.Parse (textBox2.Text);
			double inss = sal * 0.12;
			textBox3.Text = inss.ToString("C");
			double descontoFaltas = (sal/30) * faltas;
			textBox4.Text = descontoFaltas.ToString("C");
			double salarioLiquido = sal - descontoFaltas - inss;
			textBox5.Text = salarioLiquido.ToString("C");
			
		}
		//void MainFormLoad(object sender, EventArgs e)
		//{
	
		//}
		//void TextBox4TextChanged(object sender, EventArgs e)
		//{
	
		//}
	}
}
