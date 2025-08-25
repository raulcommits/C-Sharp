/*
 * Criado por SharpDevelop.
 * Usuário: Rnote
 * Data: 15/06/2025
 * Hora: 21:55
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
	/// Description of Boss.
	/// </summary>
	public class Boss : Personagem
	{
		public Boss()
		{
			Height = 350;
			Width = 560;
			Top = 485;
			Left = 1120;
			Load("In_02_Stay.gif");
			direcao = -1;
		}
	}
}
