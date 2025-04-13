/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 21/10/2024
 * Time: 19:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_20__Vetores___Nomes_
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			

		}
		void Button1Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			string [] nomes = {"Ãnah", "Brouno", "Kharlos", "Dyiogo", "Luiz", "Marcos", "Rauhl", "Uesllei", "Djhenyffer", "Hesmeralda", "Firmino", "Hector", "Gustavo", "Ysadora", "Kauã", "Lorehnna", "Matilda", "Nycolaz", "Otávyo", "Pedro"};
			float [] salarios = {2000.00f, 2115.00f, 3000.00f, 1450.00f, 9000.00f, 4000.00f, 7600.00f, 8000.00f, 3500.00f, 4030.00f, 5000.21f, 6000.10f, 6400.00f, 2800.00f, 7100.70f, 5040.00f, 8000.00f, 1100.00f, 2900.08f, 3300.40f};
			for (int i=0; i<20; i++)
			{
				listBox1.Items.Add((i+1) + " - " + nomes[i] + ": " + "Salário " + " - " + salarios[i].ToString("C"));
			}
		}
	}
}
