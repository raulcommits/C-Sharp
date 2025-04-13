/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 28/03/2025
 * Hora: 21:11
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_2___Joguin
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		ClassPersonagens pers1 = new ClassPersonagens(); // Propriedades da ClassPersonagens
		ClassPersonagens pers2 = new ClassPersonagens(); // Propriedades da ClassPersonagens
		bool ePossivel = true;
		bool ePossivel2 = true;
		PictureBox pw = new PictureBox();
		PictureBox pwOP = new PictureBox();
		Random dn = new Random();
		
		void MainFormLoad(object sender, EventArgs e)
		{
			label1.Text = "HP: " + pers1.hp; // VIDA DO PERSONAGEM
			label2.Text = "HP: " + pers2.hp; // VIDA DO PERSONAGEM
		}
		
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
			if (e.KeyCode == Keys.D)
			{
				pictureBox1.Left += 10;
			}
			if (e.KeyCode == Keys.A)
			{
				pictureBox1.Left -= 10;
			}
			if (e.KeyCode == Keys.R && ePossivel)
			{
				pw.Parent = this;
				pw.Left = pictureBox1.Left + pictureBox1.Width;
				pw.Top = pictureBox1.Top;
				pw.Height = 50;
				pw.Width = 50;
				pw.Load("boladeraio.png");
				pw.SizeMode = PictureBoxSizeMode.StretchImage;
				pw.BackColor = Color.Transparent;
				ePossivel = false;
				timer1.Enabled = true;
			}
			if (e.KeyCode == Keys.Down)
			{
				pictureBox2.Top += 10;
			}
			if (e.KeyCode == Keys.Up)
			{
				pictureBox2.Top -= 10;
			}
			if (e.KeyCode == Keys.Right)
			{
				pictureBox2.Left += 10;
			}
			if (e.KeyCode == Keys.Left)
			{
				pictureBox2.Left -= 10;
			}
			if (e.KeyCode == Keys.P && ePossivel2)
			{
				pwOP.Parent = this;
				pwOP.Left = pictureBox2.Left - pictureBox2.Width;
				pwOP.Top = pictureBox2.Top;
				pwOP.Height = 50;
				pwOP.Width = 50;
				pwOP.Load("boladeraioop.png");
				pwOP.SizeMode = PictureBoxSizeMode.StretchImage;
				pwOP.BackColor = Color.Transparent;
				ePossivel2 = false;
				timer2.Enabled = true;
			}
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			pw.Left += 30;
			if (pw.Left > 520)
			{
				ePossivel = true;
				timer1.Enabled = false;
			}
			if (pw.Bounds.IntersectsWith(pictureBox2.Bounds) )
			{
				ePossivel = true;
				timer1.Enabled = false;
				pers1.hp -= dn.Next(5, 20);
				label2.Text = "HP: " + pers1.hp;
				pw.Left = this.Width;
				if (pers1.hp <= 0)
				{
					label2.Text = "HP: " + 0;
					pictureBox2.Load("imsplozao.gif");
					NaveEstoporada(pictureBox1, "O Jogador 1 é o campeão!");
				}
			}
		}
		
		void Timer2Tick(object sender, EventArgs e)
		{
			pwOP.Left -= 30;
			if (pwOP.Left < 20)
			{
				ePossivel2 = true;
				timer2.Enabled = false;
			}
			if (pwOP.Bounds.IntersectsWith(pictureBox1.Bounds) )
			{
				ePossivel2 = true;
				timer2.Enabled = false;
				pers2.hp -= dn.Next(3, 20);
				label1.Text = "HP: " + pers2.hp;
				pw.Left = this.Width;
				if (pers2.hp <= 0)
				{
					label1.Text = "HP: " + 0;
					pictureBox1.Load("imsplozao.gif");
					NaveEstoporada(pictureBox2, "O Jogador 2 é o campeão!");
				}
			}
		}
		void NaveEstoporada(PictureBox carac, string celebracao)
		{
			timer1.Enabled = false;
			timer2.Enabled = false;
			carac.Visible = false;
			BotaoDeNovo();
		}
		void BotaoDeNovo()
		{
			Button restart = new Button();
			restart.Text = "DE NOVO";
			restart.Left = this.Width/2 - restart.Width/2;
			restart.Top = this.Height/2 - restart.Height/2;
			restart.Width = 100;
			restart.Height = 40;
			restart.Click += RestartClick;
			this.Controls.Add(restart);
		}
		void RestartClick(object sender, EventArgs e)
		{
			Button restart = sender as Button;
			this.Controls.Remove(restart);
			ComecaDeNovo();
		}
		void ComecaDeNovo()
		{
			Application.Restart();
		}
	}
}