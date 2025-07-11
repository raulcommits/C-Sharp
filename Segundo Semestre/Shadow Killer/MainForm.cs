/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 30/05/2025
 * Hora: 21:24
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Shadow_Killer
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		// INSTÂNCIAS NECESSÁRIAS PARA O JOGO
		public static PictureBox cenario = new PictureBox();
		Heroi heroi = new Heroi();
		Inimigo inimigo = new Inimigo();
		public int contCenario = 1;
		public static bool abrirJogo = false;
		public static ListBox listaTiros = new ListBox();
		public static ProgressBar barraTiro = new ProgressBar();
		bool disponivel = true;
		Timer timerDisponivel = new Timer();
		public Label hp = new Label();
		public Random dn = new Random();
		
		// O QUE O MAINFORM DEVE CARREGAR
		void MainFormLoad(object sender, EventArgs e)
		{
			// TELA INICIAL ANTES DO JOGO
			Form2 login = new Form2();
			this.Hide();
			login.ShowDialog();
			if (abrirJogo)
				this.Show();
			else
				Application.Exit();
			
			// COLOCANDO O CENÁRIO DO JOGO
			cenario.Parent = this;
			cenario.Height = this.Height;
			cenario.Width = this.Width;
			cenario.Load("cenario0.gif");
			cenario.SizeMode = PictureBoxSizeMode.StretchImage;
			
			// BARRA QUE CONTABILIZA OS ATAQUES À DISTÂNCIA
			barraTiro.Parent = this;
			barraTiro.Left = 100;
			barraTiro.Top = 80;
			barraTiro.Width = 60;
			barraTiro.Maximum = 1;
			barraTiro.Minimum = 0;
			barraTiro.Step = 1;
			barraTiro.Value = 1;
			
			hp.Parent = this;
			hp.BackColor = Color.Transparent;
			hp.ForeColor = Color.White;
			hp.Top = 50;
			hp.Left = 1500;
			hp.Height = 80;
			hp.Width = 100;
			
		}
		// MÉTODO PARA CONTROLE DE DIREÇÃO
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.D)
			{
				heroi.MoveDir();
				if(heroi.Left > (this.Width-200))
				{
					cenario.Load("cenario"+contCenario+".gif");
					heroi.Left = 0;
					contCenario++;
				}
				if(contCenario == 3)
				{
					inimigo.Hide();
					Boss boss = new Boss();
				}
				else if(contCenario == 4)
				{
					Congratulations final = new Congratulations();
					this.Hide();
					final.ShowDialog();
				}
			}
			if(e.KeyCode == Keys.A)
			{
				heroi.MoveEsq();
			}
			if(e.KeyCode == Keys.W)
			{
				heroi.MoveCima();
			}
			if(e.KeyCode == Keys.Space && disponivel)
			{
				heroi.Atacar();
				Tiro tiro = new Tiro();
				listaTiros.Items.Add(tiro);
				tiro.direcao = heroi.direcao;
				tiro.Load("Shuriken.gif");
				tiro.Top = (int) heroi.Top + (heroi.Height/2) - tiro.Height;
				tiro.Left = heroi.Left;
				tiro.perAlvo = inimigo;
				tiro.dano = dn.Next(5, 20);
				barraTiro.Value -= 1;
			}
		}
		
	}
}
