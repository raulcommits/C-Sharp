/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 02/09/2024
 * Time: 19:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_8
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			
			//double r = Math.Ceiling (x/y);
			//textBox3.Text = r.ToString();
			// mão de obra = $60,00 > m2;
			// quantidade de lajotas = qtde por largura * qtde por comprimento (parede 1) + 
			// qtde por largura * qtde por comprimento (parede 2) * 1,15 (15%);
			// qtde por largura = x/60

		}
		void Button1Click(object sender, EventArgs e)
		{
			int tL;
			float hP1, hP2, cP1, cP2, pL;
			tL = int.Parse (textBox1.Text);
			pL = float.Parse (textBox6.Text);
			
			cP1 = float.Parse (textBox2.Text);
			hP1 = float.Parse (textBox3.Text);
			double qtdeLc = Math.Ceiling (cP1/tL);
			double qtdeLh = Math.Ceiling (hP1/tL);
			label7.Text = qtdeLc.ToString();
			label9.Text = qtdeLh.ToString();
			double qtdeT1 = qtdeLc * qtdeLh;
			
			cP2 = int.Parse (textBox4.Text);
			hP2 = int.Parse (textBox5.Text);
			double qtde2Lc = Math.Ceiling (cP2/tL);
			double qtde2Lh = Math.Ceiling (hP2/tL);
			label14.Text = qtde2Lc.ToString();
			label15.Text = qtde2Lh.ToString();
			double qtdeT2 = qtde2Lc * qtde2Lh;
			
			label18.Text = (qtdeT1 * 2 * 1.15f).ToString();
			label20.Text = (qtdeT2 * 2 * 1.15f).ToString();
			
			double pP = pL * (qtdeT1 * 2 * 1.15f);
			double pP2 = pL * (qtdeT2 * 2 * 1.15f);
			label22.Text = pP.ToString("C");
			label24.Text = pP2.ToString("C");
			
			double pTL = pP + pP2;
			label26.Text = pTL.ToString("C");
			
			double pMO = (cP1/100 + hP1/100 + cP2/100 + hP2/100) * 60.00f;
			label28.Text = pMO.ToString("C");
			
			
		}
	}
}
