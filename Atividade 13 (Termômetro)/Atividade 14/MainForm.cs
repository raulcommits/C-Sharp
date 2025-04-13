/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 17/09/2024
 * Time: 21:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_14
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
		// 0- = Frio Congelante
		// 0/10 = Muito Frio
		// 10/18 = Frio
		// 18/24 = Agradável
		// 24/32 = Calor
		// 32/38 = Muito Quente
		// 38+ = Calor Escaldante
		}
		void Button1Click(object sender, EventArgs e)
		{
			float n1 = float.Parse (textBox1.Text);
			
			if (n1 < 0) {
				label2.Text = "Aviso de Temperatura: " + "Frio Congelante";
				this.BackColor = Color.DarkBlue;
				label2.ForeColor = Color.Red;
				
			}
			else
				if (n1 <= 10) {
				label2.Text = "Aviso de Temperatura: " + "Muito Frio";
				this.BackColor = Color.Blue;
				label2.ForeColor = Color.DarkRed;
			}
			else
				if (n1 <= 18) {
				label2.Text = "Aviso de Temperatura: " + "Frio";
				this.BackColor = Color.SkyBlue;
				label2.BackColor = Color.OrangeRed;
			}
			else
				if (n1 <= 24) {
				label2.Text = "Aviso de Temperatura: " + "Agradável";
				this.BackColor = Color.Yellow;
				label2.BackColor = Color. 
			}
			else
				if (n1 <= 32) {
				label2.Text = "Aviso de Temperatura: " + "Calor";
				this.BackColor = Color.OrangeRed;
			}
			else
				if (n1 <= 38) {
				label2.Text = "Aviso de Temperatura: " + "Muito Calor";
				this.BackColor = Color.DarkRed;
			}
			else
				if (n1 > 38) {
				label2.Text = "Aviso de Temperatura: " + "Calor Escaldante";
				this.BackColor = Color.Red;
			}
		}
	}
}
