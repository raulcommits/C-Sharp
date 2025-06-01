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
		
		public static ListBox listaTiros = new ListBox();
		public static ProgressBar barra = new ProgressBar();
		
		void MainFormLoad(object sender, EventArgs e)
		{
			fundo.Parent = this;
			fundo.Height = this.Height;
			fundo.Width = this.Width;
			fundo.Load("cenario0.gif");
			fundo.SizeMode = PictureBoxSizeMode.StretchImage;
			
			barra.Parent = this;
			barra.Left = 200;
			barra.Top = this.Height - 90;
			barra.Width = 200;
			barra.Maximum = 6;
			barra.Minimum = 0;
			barra.Step = 1;
			barra.Value = 6;
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
				if(barra.Value > 0)
				{
					Shot shot = new Shot();
					listaTiros.Items.Add(shot);
					shot.direcao = heroi.direcao;
					shot.Load("fireball2.gif");
					shot.Top = (int) heroi.Top + (heroi.Height/2) - shot.Height;
					shot.Left = heroi.Left;
					shot.personagemAlvo = inimigo;
					barra.Value -= 1;
				}
			}
		}
	}
}
