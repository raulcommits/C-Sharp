/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 09/05/2025
 * Hora: 21:49
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Aula_1__2_Bimestre____Herança
{
	public class Shot : PictureBox
	{
		public Shot()
		{
			Width = 60;
			Height = 60;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Parent = MainForm.fundo;
			timerTiro.Enabled = true;
			timerTiro.Interval = 40;
			timerTiro.Tick += timerTick;
		}
		public int direcao = 50;
		public int speed = 20;
		public int dano = 10;
		public Personagem personagemAlvo;
		public Timer timerTiro = new Timer();
		
		void timerTick(object sender, EventArgs e)
		{
			Left += speed * direcao;
			
			if(Left > MainForm.fundo.Width || Left < 0)
			{
				Destruir();
			}
			else if(personagemAlvo.Bounds.IntersectsWith(this.Bounds))
			{
				(personagemAlvo as Inimigo).Destruir();
				this.Destruir();
			}
			
		}
		public void Destruir()
		{
			timerTiro.Enabled = false;
			Left = 6000;
			MainForm.listaTiros.Items.Remove(this);
			MainForm.barra.Value += 1;
			Dispose();
		}
	}
}
