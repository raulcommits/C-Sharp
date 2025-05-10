/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 09/05/2025
 * Hora: 21:11
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Windows.Forms;

namespace Aula_1__2_Bimestre____Herança
{
	/// <summary>
	/// Description of Inimigo.
	/// </summary>
	public class Inimigo : Personagem
	{
		public Inimigo()
		{
			Height = 95;
			Width = 120;
			Top = 120;
			Left = 560;
			Load("dragonEsq2.gif");
			direcao = -1;
			timerMovimento.Enabled = true;
			timerMovimento.Interval = 80;
			timerMovimento.Tick += Movimento;
		}
		
		int direcaoVertical = 1;
		public Timer timerMovimento = new Timer();
		
		void Movimento(object sender, EventArgs e)
		{
			Top += speed * direcaoVertical;
		
			if (Top >= 180)
			direcaoVertical = -1;
		
			if (Top <= 0)
			direcaoVertical = 1;
		}
		
		public void Destruir()
		{
			timerMovimento.Enabled = false;
			Left = 6000;
			this.Dispose();
		}
	}
}
