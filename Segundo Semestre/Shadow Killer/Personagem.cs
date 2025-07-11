/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 30/05/2025
 * Hora: 21:30
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Shadow_Killer
{
	/// <summary>
	/// Description of Personagem.
	/// </summary>
	public class Personagem : PictureBox
	{
		public Personagem()
		{
			Width = 200;
			Height = 200;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Parent = MainForm.cenario;
		}
		public int ataque = 20;
		public int defesa = 20;
		public int velocidade = 10;
		public int direcao = 1;
		public int vida = 100;
		public int pulo = 1;
		
	}
}
