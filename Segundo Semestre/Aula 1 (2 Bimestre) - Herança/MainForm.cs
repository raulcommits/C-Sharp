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
		static Inimigo inimigo = new Inimigo();
		
		void MainFormLoad(object sender, EventArgs e)
		{
			fundo.Parent = this;
			fundo.Height = this.Height - 120;
			fundo.Width = this.Width;
			fundo.Load("cenario0.gif");
			fundo.SizeMode = PictureBoxSizeMode.StretchImage;
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.D)
			{
				heroi.MoveDir();
			}
			if (e.KeyCode == Keys.A)
			{
				heroi.MoveEsq();
			}
			if (e.KeyCode == Keys.W)
			{
				heroi.MoveCima();
			}
			if (e.KeyCode == Keys.S)
			{
				heroi.MoveContrarioDeCima();
			}
			if (e.KeyCode == Keys.Space)
			{
				
			}
		}
	}
}
