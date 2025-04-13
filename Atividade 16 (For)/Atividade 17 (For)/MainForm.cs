/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 30/09/2024
 * Time: 20:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_17__For_
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			/*int n = int.Parse (textBox1.Text);
			listBox1.Items.Clear();
			
			for (int i = 1; i <= 10; i++)
			{
				listBox1.Items.Add(n + " x " + i + " = " + n * i);
			}*/
			
			/*string s = "c" + "a" + "v" + "a" + "l" + "o";

			
			for (int i = 0; i < 6; i++)
			{
				listBox1.Items.Add (s[i]);
			}*/
		}
		void Button1Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			
			// COLETA DE DADOS
			string palavra = textBox1.Text;
			char letra = textBox2.Text[0];
			int cont = 0;
			
			// PESQUISA
			for (int i=0; i < palavra.Length; i++)
			{
				if (palavra[i] == letra)
				{
					listBox1.Items.Add("A letra " + letra + " aparece na posição " + (i + 1));
					cont++;
				}
			}
			
			listBox1.Items.Add("");
			listBox1.Items.Add("A letra " + letra + " aparece " + cont + " vez(es)");
		}
	}
}
