/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 11/04/2025
 * Hora: 22:22
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace Aula_1__2_Bimestre____Herança
{
	/// <summary>
	/// Description of Heroi.
	/// </summary>
	public class Heroi : Personagem
	{
		public Heroi()
		{
			Left = 50;
			Top = 100;
			speed = 20;
			Load("");
			direcao = 1;
		}
		
		public void MoveDir()
		{
			Left += speed;
			if (Left >- 1000)
			{
				Left = 0;
			}
			
			if (direcao == -1)
			{
				direcao = 1;
				Load("");
				
			}
		}
		public void MoveEsq()
		{
			Left -= speed;
			if (Left <= 0)
			{
				Left = 1000;
			}
			
			if (direcao == 1)
			{
				direcao = -1;
				Load();
			}
		}
	}
}
