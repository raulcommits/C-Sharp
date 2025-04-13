/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 20/08/2024
 * Time: 19:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_5
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			

		}
		void Button1Click(object sender, EventArgs e)
		{
			float p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, soma;
			int qI, qI2, qI3, qI4, qI5, qI6, qF, qF2, qF3, qF4, qF5, qF6, qV, qV2, qV3, qV4, qV5, qV6;
			
			// brinquedo 1
			p1 = float.Parse (textBox2.Text);
			qI = int.Parse (textBox3.Text);
			qF = int.Parse (textBox4.Text);
			qV = qI - qF;
			p2 = p1 * qV;
			
			// brinquedo 2
			p3 = float.Parse (textBox8.Text);
			qI2 = int.Parse (textBox9.Text);
			qF2 = int.Parse (textBox10.Text);
			qV2 = qI2 - qF2;
			p4 = p3 * qV2;
			
			// brinquedo 3
			p5 = float.Parse (textBox14.Text);
			qI3 = int.Parse (textBox15.Text);
			qF3 = int.Parse (textBox16.Text);
			qV3 = qI3 - qF3;
			p6 = p5 * qV3;
			
			// brinquedo 4
			p7 = float.Parse (textBox20.Text);
			qI4 = int.Parse (textBox21.Text);
			qF4 = int.Parse (textBox22.Text);
			qV4 = qI4 - qF4;
			p8 = p7 * qV4;
			
			// brinquedo 5
			p9 = float.Parse (textBox26.Text);
			qI5 = int.Parse (textBox27.Text);
			qF5 = int.Parse (textBox28.Text);
			qV5 = qI5 - qF5;
			p10 = p9 * qV5;
			
			// brinquedo 6
			p11 = float.Parse (textBox32.Text);
			qI6 = int.Parse (textBox33.Text);
			qF6 = int.Parse (textBox34.Text);
			qV6 = qI6 - qF6;
			p12 = p11 * qV6;
			
			soma = p2 + p4 + p6 + p8 + p10 + p12;
			
			textBox5.Text = qV.ToString();
			textBox6.Text = p2.ToString("C");
			textBox11.Text = qV2.ToString ();
			textBox12.Text = p4.ToString("C");
			textBox17.Text = qV3.ToString();
			textBox18.Text = p6.ToString("C");
			textBox23.Text = qV4.ToString();
			textBox24.Text = p8.ToString("C");
			textBox29.Text = qV5.ToString();
			textBox30.Text = p10.ToString("C");
			textBox35.Text = qV6.ToString();
			textBox36.Text = p12.ToString("C");
			label13.Text = soma.ToString("C");
			
		}
		//void TextBox26TextChanged(object sender, EventArgs e)
		//{
	
		//}
		//void TextBox33TextChanged(object sender, EventArgs e)
		//{
	
		//}
		//void TextBox34TextChanged(object sender, EventArgs e)
		//{
	
		//}
		//void TextBox25TextChanged(object sender, EventArgs e)
		//{
	
		//}
		//void Label11Click(object sender, EventArgs e)
		//{
	
		//}
		//void Label12Click(object sender, EventArgs e)
		//{
	
		//}
		//void TextBox3TextChanged(object sender, EventArgs e)
		//{
	
		//}
		//void TextBox3TextChanged(object sender, EventArgs e)
		//{
	
		//}
		//void TextBox3TextChanged(object sender, EventArgs e)
		//{
	
		//}
		//void Label8Click(object sender, EventArgs e)
		//{
	
		//}
		// void TextBox1TextChanged(object sender, EventArgs e)
		//{
	
		//}
	}
}
