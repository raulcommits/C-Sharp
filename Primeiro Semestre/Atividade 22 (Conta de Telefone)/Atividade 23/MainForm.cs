/*
 * Criado por SharpDevelop.
 * Usuário: raul
 * Data: 14/11/2024
 * Hora: 14:39
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_23
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			// foreach utiliza cada "dado"
			//

		}
		void Button1Click(object sender, EventArgs e)
		{
			richTextBox1.Text += textBox1.Text + " | " + textBox2.Text + " | " + textBox3.Text + "\n";
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
		}
		void Button2Click(object sender, EventArgs e)
		{
			richTextBox1.SaveFile("funcionarios.txt", RichTextBoxStreamType.PlainText);
		}
		void Button3Click(object sender, EventArgs e)
		{
			richTextBox1.LoadFile("funcionarios.txt", RichTextBoxStreamType.PlainText);
		}
		void Button4Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}
		void Button5Click(object sender, EventArgs e)
		{
			string[] linhas = richTextBox1.Lines;
			
			double media;
			if (!double.TryParse(textBox5.Text.Trim(), out media))
			{
				MessageBox.Show("Não é possível utilizar este botão antes do cálculo da média!");
				return;
			}
			
			string dadosAcmedia = "";
			
			for (int i=0; i < linhas.Length; i++)
			{
				// IGNORAR LINHAS VAZIAS
				if (string.IsNullOrWhiteSpace(linhas[i]))
					continue;
				
				string[] partes = linhas[i].Split('|');
				
				if (partes.Length >= 3)
				{
					try
					{
						double valor = double.Parse(partes[2].Trim());
						
						if (valor > media)
						{
							dadosAcmedia += linhas[i] + Environment.NewLine;
						}
					}
						catch
						{
							// IGNORAR ERROS DE CONVERSÃO
							MessageBox.Show("Erro ao processar o valor na linha {i + 1}: {linhas[i]}");
						}
				}
				richTextBox2.Text = dadosAcmedia;
				
			}
		}
		void Button6Click(object sender, EventArgs e)
		{
			double somaTotal = 0;
			int contador = 0;
			
			string[] linhas = richTextBox1.Lines;
			
			for (int i = 0; i < linhas.Length; i++)
			{
				if (string.IsNullOrWhiteSpace(linhas[i]))
					continue;
				
				string[] partes = linhas[i].Split('|');
				
				if (partes.Length >= 3)
				{
					try
					{
						double valor = double.Parse(partes[2].Trim());
						
						somaTotal += valor;
						
						contador++;
					}
					catch
					{
						MessageBox.Show("Erro ao processar o valor na linha {i + 1}: {linhas[i]}");
					}
				}
				else
				{
					MessageBox.Show("Linha inválida encontrada: {linhas[i]}");
				}
			}
			
			textBox4.Text = somaTotal.ToString("F2");
			
			double media = contador > 0 ? somaTotal / contador : 0;
			
			textBox5.Text = media.ToString("F2");
		}
	}
}
