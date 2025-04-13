/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 29/10/2024
 * Time: 21:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_22__Uso_de_RichTextBox_
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			

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
			richTextBox1.SaveFile("dados.txt", RichTextBoxStreamType.PlainText);
		}
		void Button3Click(object sender, EventArgs e)
		{
			richTextBox1.LoadFile("dados.txt", RichTextBoxStreamType.PlainText);
		}
		void Button4Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			richTextBox1.SaveFile("dados.txt", RichTextBoxStreamType.PlainText);
		}
		void Button5Click(object sender, EventArgs e)
		{
			// CONSULTAR
			int nLinha = int.Parse(textBox4.Text);
			if (nLinha < richTextBox1.Lines.Length-1)
			{
				// PEGAR A LINHA ESPECIFICADA
				string linha = richTextBox1.Lines[nLinha];
				
				// SEPARAÇÃO
				string[] dados = linha.Split('|');
				
				// MOSTRAR
				textBox1.Text = dados[0];
				textBox2.Text = dados[1];
				textBox3.Text = dados[2];
			}
			else 
			{
				MessageBox.Show("registro não cadastrado");
			}
		}
	}
}
