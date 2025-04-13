/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 03/09/2024
 * Time: 21:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_9
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			// EXERCICIO 10
			//string s = "cavalo", t = "feliz";
			//label1.Text = s[0].ToString() + t[0] + s[1] + t[1] + s[2] + t[2] + s[3] + t[3] + s[4] + t[4] + s[5];
			
			
			// EXERCICIO 12
			//string s = textBox1.Text;
			//label2.Text = s[0].ToString() + s[2] + s[4] + s[6] + s[8];
		}
		void Button1Click(object sender, EventArgs e)
		{
			// EXERCICIO 11
			string s = textBox1.Text;
			int n1 = int.Parse (s[0].ToString());
			int n2 = int.Parse (s[1].ToString());
			int n3 = int.Parse (s[2].ToString());
			int n4 = int.Parse (s[3].ToString());
			int n5 = int.Parse (s[4].ToString());
			int soma = n1 + n2 + n3 + n4 + n5;
			label2.Text = soma.ToString();
		}
	}
}
