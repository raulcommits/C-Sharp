/*
 * Criado por SharpDevelop.
 * Usuário: raul
 * Data: 29/09/2024
 * Hora: 23:42
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_15__Mafagafos_
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			

		}
		void Button1Click(object sender, EventArgs e)
		{
	 		// VALORES DA COMPRA
	 		int mA = int.Parse (textBox1.Text);
	 		int mF = int.Parse (textBox2.Text);
	 		int mG = int.Parse (textBox3.Text);
	 		double qtdeMF = (mA * 1000) + (mF * 1000) + (mG * 1500);
	 		double qtdeMF2 = (mA * 1000 * 0.93) + (mF * 1000) + (mG * 1500);
	 		double qtdeMF3 = (mA * 1000) + (mF * 1000 * 0.93) + (mG * 1500);
	 		double qtdeMF23 = (mA * 1000 * 0.93) + (mF * 1000 * 0.93) + (mG * 1500);
	 		float vmA = (mA * 1000);
	 		float vmF = (mF * 1000);
	 		float vmG = (mG * 1500);
	 		
	 		// APARECENDO O DESCONTO
	 		float dmA = vmA - (vmA * 0.93f);
	 		float dmF = vmF - (vmF * 0.93f);
	 		label8.Text = vmA.ToString("C");
	 		label9.Text = vmF.ToString("C");
	 		label10.Text = vmG.ToString("C");
	 		
	 		// CÁLCULO DO ESTOQUE
	 		float esA = 12000 - mA;
	 		float esF = 7000 - mF;
	 		float esG = 3000 - mG;
	 		label2.Text = "Estoque (Adultos): " + esA;
	 		label3.Text = "Estoque (Filhotes): " + esF;
	 		label4.Text = "Estoque (Grávidos): " + esG;
	 		
	 		// LIMITE DE COMPRA
	 		if (mA >= 12000) {
	 			MessageBox.Show("Quantidade Excedida");
	 		}
	 		if (mF >= 7000) {
	 			MessageBox.Show("Quantidade Excedida");
	 		}
	 		
	 		// CÁLCULO DO DESCONTO
	 		if (mA > 7)
	 		{
	 			label15.Text = qtdeMF2.ToString("C");
	 			label11.Text = dmA.ToString("C");
	 		} else {
	 			label15.Text = qtdeMF.ToString("C");
	 		}
	 		if (mF > 14) {
	 			label15.Text = qtdeMF3.ToString("C");
	 			label12.Text = dmF.ToString("C");
	 		} else {
	 			label15.Text = qtdeMF.ToString("C");
	 		}
	 		if (mA > 7 && mF > 14)
	 		{
	 			label15.Text = qtdeMF23.ToString("C");
	 		} else {
	 			label15.Text = qtdeMF.ToString("C");
	 		}
		}
	}
}
