/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 07/02/2025
 * Hora: 19:29
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ExplorandoPOO
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		Button bt1 = new Button();
		Button bt2 = new Button();
		Button bt3 = new Button();
		PictureBox fotinha = new PictureBox();
		Timer tempo = new Timer();
		
		void MainFormLoad(object sender, EventArgs e)
		{
			this.Width = 800;
			this.Height = 500;
			//BOTÃO 1
			bt1.Parent = this;
			bt1.Left = 600;
			bt1.Top = 400;
			bt1.Width = 100;
			bt1.Height = 30;
			bt1.Text = "Mudar de Cor";
			bt1.Click += bt1Click;
			
			//BOTÃO 2
			bt2.Parent = this;
			bt2.Left = 200;
			bt2.Top = 400;
			bt2.Width = 100;
			bt2.Height = 30;
			bt2.Text = "Ande";
			bt2.Click += bt2Click;
			
			//BOTÃO 3
			bt3.Parent = this;
			bt3.Left = 400;
			bt3.Top = 400;
			bt3.Width = 100;
			bt3.Height = 30;
			bt3.Text = "Imagine";
			bt3.Click += bt3Click;
		}
		
		void bt1Click(object sender, EventArgs e)
		{
			this.BackColor = Color.FromArgb(220, 250, 120);
			TextBox teixto = new TextBox();
			teixto.Parent = this;
			teixto.Left = 600;
			teixto.Top = 340;
			Label titulo = new Label();
			titulo.Parent = this;
			titulo.Left = 360;
			titulo.Top = 40;
			titulo.Text = "O TÍTULO";
		}
		
		int x = 1;
		void bt2Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Blue;
			bt2.Left += 30 * x;
			x = -x;
		}
		
		void bt3Click(object sender, EventArgs e)
		{
			fotinha.Parent = this;
			fotinha.Left = 350;
			fotinha.Top = 250;
			fotinha.Width = 300;
			fotinha.Height = 200;
			fotinha.SizeMode = PictureBoxSizeMode.StretchImage;
			fotinha.Load ("ponty.png");
			tempo.Enabled = ! tempo.Enabled;
			tempo.Tick += tempoTick;
		}
		
		void tempoTick(object sender, EventArgs e)
		{
			fotinha.Left += 30;
			if (fotinha.Left > this.Width-300)
				tempo.Enabled = false;
		}
		
	}
}
