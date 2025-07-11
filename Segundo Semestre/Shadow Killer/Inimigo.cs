/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 30/05/2025
 * Hora: 21:31
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Shadow_Killer
{
	public class Inimigo : Personagem
	{
		public Inimigo()
		{
			Height = 320;
			Width = 390;
			Top = 475;
			Left = 1120;
			Load("In01-Walk-unscreen.gif");
			direcao = -1;
			timerMovimento.Enabled = true;
			timerMovimento.Interval = 80;
			timerMovimento.Tick += Movimento;
			vida = 50;
		}
		public Timer timerMovimento = new Timer();
		
		void Movimento(object sender, EventArgs e)
		{
			Left -= velocidade;
			Load("In01-Walk-unscreen.gif");
			
		}
		
		public void Estoporar()
		{
			timerMovimento.Enabled = false;
			Left = 6000;
			Dispose();
		}
	}
}
