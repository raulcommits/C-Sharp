/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 17/06/2025
 * Hora: 19:46
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shadow_Killer
{
	public class Tiro : PictureBox
	{
		public Tiro()
		{
			Width = 80;
			Height = 80;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Parent = MainForm.cenario;
			timerTiro.Enabled = true;
			timerTiro.Interval = 40;
			timerTiro.Tick += timerTick;
		}
		public int direcao = 50;
		public int velocidade = 30;
		public int dano = 10;
		public Personagem perAlvo;
		public Timer timerTiro = new Timer();
		
		void timerTick(object sender, EventArgs e)
		{
			Left += velocidade * direcao;
			
			if(Left > MainForm.cenario.Width || Left < 0)
			{
				Estoporar();
			}
			else if(perAlvo.Bounds.IntersectsWith(this.Bounds))
			{
				(perAlvo as Inimigo).Estoporar();
				this.Estoporar();
			}
		}
		public void Estoporar()
		{
			timerTiro.Enabled = false;
			Left = 6000;
			MainForm.listaTiros.Items.Remove(this);
			MainForm.barraTiro.Value += 1;
			Dispose();
		}
	}
}