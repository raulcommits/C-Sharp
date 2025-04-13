-/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 16/09/2024
 * Time: 20:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_13
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			// pictureBox4.Load ("multa.png");
		}
		void Button1Click(object sender, EventArgs e)
		{
			double p1, p2, t, vm;
			
			p1 = double.Parse (textBox1.Text);
			t = double.Parse (textBox2.Text);
			p2 = double.Parse (textBox3.Text);
			vm = (p2 - p1)/t;
			
			if (vm > 80) {
				label7.Text = "Velocidade Alta! Você será multado";
				pictureBox4.Load ("policial.jpg");
			} else {
				label7.Text = "A Velocidade está Adequada";
				pictureBox4.Load ("stitch.png");
			}
			
			label6.Text = "Velocidade Média: " + vm;
		}
	}
}
