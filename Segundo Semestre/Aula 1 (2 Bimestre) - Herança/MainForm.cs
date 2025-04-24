/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 11/04/2025
 * Hora: 21:54
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aula_1__2_Bimestre____Herança
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		public static PictureBox fundo = new PictureBox(); // VARIÁVEL ESTÁTICA
		Heroi heroi = new Heroi();
		
		void MainFormLoad(object sender, EventArgs e)
		{
			fundo.Parent = this;
			fundo.Height = this.Height - 120;
			fundo.Width = this.Width;
			fundo.Load("");
			fundo.SizeMode = PictureBoxSizeMode.StretchImage;
		}
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
	
		}
	}
}
