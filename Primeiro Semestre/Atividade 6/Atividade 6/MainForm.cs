/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 26/08/2024
 * Time: 19:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_6
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			// (c1) 15 miçangas - 18 reais;
			// (c2) 20 miçangas - 25 reais;
			// (c3) 35 miçangas - 32 reais;
			// (k) custo > miçanga = $0,15 / fio com feixe = $2,40;
			// informar = estoque no inicio e no final do dia. Quantidade de unidades vendidas de cada, valor bruto e liquido separado, e o total do anterior;

		}
		void Button1Click(object sender, EventArgs e)
		{
			float pr1, pr2, pr3, vB, vB2, vB3, c, c2, c3, vL, vL2, vL3, bT, cT, lT;
			int qI, qI2, qI3, qF, qF2, qF3, qV, qV2, qV3;
			
			// tipo 1 de colar
			pr1 = float.Parse (textBox1.Text);
			qI = int.Parse (textBox2.Text);
			qF = int.Parse (textBox3.Text);
			qV = qI - qF;
			vB = pr1 * qV;
			c = (0.15f * 15 + 2.40f) * qV;
			vL = vB - c;
			
			// tipo 2 de colar
			pr2 = float.Parse (textBox8.Text);
			qI2 = int.Parse (textBox9.Text);
			qF2 = int.Parse (textBox10.Text);
			qV2 = qI2 - qF2;
			vB2 = pr2 * qV2;
			c2 = (0.15f * 20 + 2.40f) * qV2;
			vL2 = vB2 - c2;
			
			// tipo 3 de colar
			pr3 = float.Parse (textBox15.Text);
			qI3 = int.Parse (textBox16.Text);
			qF3 = int.Parse (textBox17.Text);
			qV3 = qI3 - qF3;
			vB3 = pr3 * qV3;
			c3 = (0.15f * 35 + 2.40f) * qV3;
			vL3 = vB3 - c3;
			
			// somatórias finais
			bT = vB + vB2 + vB3;
			cT = c + c2 + c3;
			lT = vL + vL2 + vL3;
			
			textBox4.Text = qV.ToString();
			textBox5.Text = vB.ToString("C");
			textBox6.Text = c.ToString("C");
			textBox7.Text = vL.ToString("C");
			textBox11.Text = qV2.ToString();
			textBox12.Text = vB2.ToString("C");
			textBox13.Text = c2.ToString("C");
			textBox14.Text = vL2.ToString("C");
			textBox18.Text = qV3.ToString();
			textBox19.Text = vB3.ToString("C");
			textBox20.Text = c3.ToString("C");
			textBox21.Text = vL3.ToString("C");
			textBox22.Text = bT.ToString("C");
			textBox23.Text = cT.ToString("C");
			textBox24.Text = lT.ToString("C");
			
		}
		//void TextBox10TextChanged(object sender, EventArgs e)
		//{
	
		//}
		//void TextBox2TextChanged(object sender, EventArgs e)
		//{
	
		//}
		//void TextBox6TextChanged(object sender, EventArgs e)
		//{
	
		//}
		//void TextBox7TextChanged(object sender, EventArgs e)
		//{
	
		//}
		//void TextBox21TextChanged(object sender, EventArgs e)
		//{
	
		//}
	}
}
