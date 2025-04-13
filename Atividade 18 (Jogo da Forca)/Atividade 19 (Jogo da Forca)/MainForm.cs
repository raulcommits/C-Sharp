/*
 * Criado por SharpDevelop.
 * Usuário: raul
 * Data: 12/10/2024
 * Hora: 00:26
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_19__Jogo_da_Forca_
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			

		}
		
		int erros = 0;
		
		void Button1Click(object sender, EventArgs e)
		{
			// RECEBE E OCULTA A PALAVRA
			button1.Visible = false;
			textBox1.Visible = false;
			button2.Enabled = true;
			button3.Enabled = true;
			label1.Visible = true;
			label1.Text = "A palavra tem " + textBox1.Text.Length + " letras";
		}
		void Button2Click(object sender, EventArgs e)
		{
			// BOTÃO PARA VERIFICAR A OCORRÊNCIA
			string palavra = textBox1.Text;
			char letra = textBox2.Text[0];
			
			// VERIFICA QUANTAS VEZES A LETRA APARECE NA PALAVRA
			int i = 0, cont = 0;
			while (i < palavra.Length)
			{
				if (letra == palavra[i])
				{
					cont++;
				}
				i++; // NUNCA ESQUEÇER!!!!!!
			}
			
			// INFORMA O RESULTADO DA VERIFICAÇÃO
			if (cont == 0)
			{
				erros++;
				listBox1.Items.Add(letra + ": não aparece. Erros: " + erros);
			}
			else
			{
				listBox1.Items.Add(letra + ": aparece " + cont + " vezes");
			}
			
			// VERIFICANDO SE EXCEDEU O LIMITE DE ERROS
			if (erros == 6)
			{
				MessageBox.Show("Atenção!!!\n" +
				                "Ultrapassou o limite de chutes errados. \n" +
				                "Você deve informar a palavra");
				button2.Enabled = false;
				textBox2.Enabled = false;
			}
			
			textBox2.Clear();
			textBox2.Focus();
			
		}
		void Button3Click(object sender, EventArgs e)
		{
			// EXIBE O RESULTADO FINAL
			if (textBox3.Text == textBox1.Text)
			{
				label2.ForeColor = Color.Green;
				label2.Text = "Resultado: Acertou";
			}
			else
			{
				label2.ForeColor = Color.Red;
				label2.Text = "Resultado: Errou";
			}
			button3.Enabled = false;
		}
		
	}
}
