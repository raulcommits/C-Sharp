/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 27/08/2024
 * Time: 20:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_7__para_entregar_
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			// volume = altura * largura * comprimento

		}
		void Button1Click(object sender, EventArgs e)
		{
			int h, l, c;
			float vl, sv;
			
			h = int.Parse (textBox1.Text);
			l = int.Parse (textBox2.Text);
			c = int.Parse (textBox3.Text);
			vl = h * l * c;
			sv = 49.99f * vl + 250.00f;
			label8.Text = vl.ToString();
			textBox4.Text = sv.ToString("C");
		}
		//void Label8Click(object sender, EventArgs e)
		//{
	
		//}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
	}
}
