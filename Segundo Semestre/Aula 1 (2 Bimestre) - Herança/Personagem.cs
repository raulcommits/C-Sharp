/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 11/04/2025
 * Hora: 22:11
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace Aula_1__2_Bimestre____Herança
{
	/// <summary>
	/// Description of Personagem.
	/// </summary>
	public class Personagem : PictureBox
	{
		public Personagem()
		{
			Width = 90;
			Height = 90;
			SizeMode = 
			BackColor = 
			Parent = MainForm.fundo;
		}
		public int ataque = 15;
		public int defesa = 15;
		public int hp = 100;
		public int speed = 25;
		public int direcao = 1;
	}
}
