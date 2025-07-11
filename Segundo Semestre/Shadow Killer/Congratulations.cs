/*
 * Criado por SharpDevelop.
 * Usuário: Rnote
 * Data: 17/06/2025
 * Hora: 02:15
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Shadow_Killer
{

	public class Congratulations : Form
	{
		public Congratulations()
		{
			// DEFININDO O TAMANHO DA TELA
			StartPosition = FormStartPosition.CenterScreen;
			Width = 1800;
			Height = 1250;
			this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            
            // COLOCANDO UM GIF DE FUNDO
            PictureBox backgroundGif = new PictureBox();
            backgroundGif.Image = Image.FromFile("cenario3.gif");
            backgroundGif.SizeMode = PictureBoxSizeMode.StretchImage;
            backgroundGif.Dock = DockStyle.Fill;
            this.Controls.Add(backgroundGif);
            
            // BOTÃO PARA SAIR
            Button sair = new Button();
            

		}
	}
}
