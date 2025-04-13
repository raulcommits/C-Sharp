/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 09/12/2024
 * Hora: 19:26
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_26__Varejo_
{
	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			// PREÇO DE VAREJO = (pF * 1,2 = pV);
			// IMPOSTOS = pV * 1,25;
			// 20 produtos em um RichTextBox = produtos.txt;
			// varejo.txt = Produtos & pF + pV + imP;

		}
		int linha;
		void Button1Click(object sender, EventArgs e)
		{
			linha = dataGridView1.RowCount;
			dataGridView1.RowCount++;
			
			
		}
	}
}
