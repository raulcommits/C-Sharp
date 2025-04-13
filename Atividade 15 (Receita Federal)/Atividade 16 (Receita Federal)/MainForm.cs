/*
 * Criado por SharpDevelop.
 * Usuário: raul
 * Data: 30/09/2024
 * Hora: 01:49
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_16__Receita_Federal_
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			/* else if (sa > 5000) {
				label2.Text = i2.ToString("C");
				label3.Text = sL2.ToString("C");
			} else if (sa > 12000) {
				label2.Text = i3.ToString("C");
				label3.Text = sL3.ToString("C");
			} else if (sa > 20000) {
				label2.Text = i4.ToString("C");
				label3.Text = sL4.ToString("C");
			} */

		}
		void Button1Click(object sender, EventArgs e)
		{
			// SALÁRIO
			float sa = float.Parse (textBox1.Text);
			
			// DESCONTOS DO IMPOSTO
			float i1 = sa * 0.10f;
			float i2 = sa * 0.15f;
			float i3 = sa * 0.20f;
			float i4 = sa * 0.25f;
			
			float sL1 = sa - i1;
			float sL2 = sa - i2;
			float sL3 = sa - i3;
			float sL4 = sa - i4;
			
			if (sa > 1500 && sa <= 5000)
			{
				label2.Text = i1.ToString("C");
				label3.Text = sL1.ToString("C");
				label4.Text = "10% de imposto";
				label4.ForeColor = Color.PaleVioletRed;
			}
			if (sa > 5000 && sa <= 12000)
			{
				label2.Text = i2.ToString("C");
				label3.Text = sL2.ToString("C");
				label4.Text = "15% de imposto";
				label4.ForeColor = Color.IndianRed;
			}
			if (sa > 12000 && sa <= 20000) {
				label2.Text = i3.ToString("C");
				label3.Text = sL3.ToString("C");
				label4.Text = "20% de imposto";
				label4.ForeColor = Color.DarkRed;
			}
			if (sa > 20000) {
				label2.Text = i4.ToString("C");
				label3.Text = sL4.ToString("C");
				label4.Text = "25% de imposto";
				label4.ForeColor = Color.Red;
			} else {
				label3.Text = sa.ToString("C");
			}
			
		}
	}
}
