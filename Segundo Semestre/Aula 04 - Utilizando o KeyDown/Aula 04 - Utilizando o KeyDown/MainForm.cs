/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 14/03/2025
 * Hora: 20:29
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aula_04___Utilizando_o_KeyDown
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		PictureBox fb = new PictureBox();
		bool acessivel = true;
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.S)
			{
				pictureBox1.Top += 10;
			}
			if (e.KeyCode == Keys.W)
			{
				pictureBox1.Top -= 10;
			}
			if (e.KeyCode == Keys.Space && acessivel)
			{
				fb.Parent = this;
				fb.Left = pictureBox1.Left + pictureBox1.Width;
				fb.Top = pictureBox1.Top;
				fb.Height = 70;
				fb.Width = 70;
				fb.Load("boladefire.png");
				fb.SizeMode = PictureBoxSizeMode.StretchImage;
				acessivel = false;
				timer1.Enabled = true;
			}
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			fb.Left += 30;
			if (fb.Left > 630)
			{
				acessivel = true;
				timer1.Enabled = false;
			}
			if (fb.Left == pictureBox2.Left)
			{
				pictureBox2.Load("boladefire.png");
			}
		}
		
	}
}
