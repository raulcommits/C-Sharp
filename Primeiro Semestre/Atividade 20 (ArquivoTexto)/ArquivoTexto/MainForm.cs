/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 22/10/2024
 * Time: 21:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArquivoTexto
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			

		}
		void Button1Click(object sender, EventArgs e)
		{
			richTextBox1.SaveFile("teste.rtf");
		}
		void Button2Click(object sender, EventArgs e)
		{
			richTextBox1.LoadFile("teste.rtf");
		}
		void Button3Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}
	}
}
