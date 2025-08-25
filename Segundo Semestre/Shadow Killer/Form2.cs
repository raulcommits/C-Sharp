using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shadow_Killer
{
    public class Form2 : Form
    {
        public Form2()
        {
            // Definindo posição da tela de Inicio
        	StartPosition = FormStartPosition.CenterScreen;
            Width = 1800;
            Height = 1250;
			this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;            	
            
            // Fundo com GIF animado
            PictureBox backgroundGif = new PictureBox();
            backgroundGif.Image = Image.FromFile("BkgTelaInicial.gif");
            backgroundGif.SizeMode = PictureBoxSizeMode.StretchImage;
            backgroundGif.Dock = DockStyle.Fill;
            this.Controls.Add(backgroundGif);

            // Título do Jogo
            PictureBox title = new PictureBox();
            title.Image = Image.FromFile("TitleGame01.jpeg");
            title.Size = new Size(600, 150);
            title.SizeMode = PictureBoxSizeMode.StretchImage;
            title.Location = new Point(
                (this.ClientSize.Width - title.Width) / 2,
                50
            );
            this.Controls.Add(title);

            // Botão "Iniciar"
            Button iniciar = new Button();
            iniciar.BackColor = Color.Cornsilk;
            iniciar.FlatStyle = FlatStyle.Flat;
            iniciar.FlatAppearance.BorderSize = 3;
            iniciar.Font = new Font("Arial", 20, FontStyle.Bold);
            iniciar.Text = "Iniciar Jogo";
            iniciar.Size = new Size(300, 80);
            iniciar.Location = new Point(
                (this.ClientSize.Width - iniciar.Width) / 2,
                (this.ClientSize.Height - 250)
            );
            iniciar.Click += new EventHandler(iniciarClick);
            this.Controls.Add(iniciar);

            // Para os controles ficarem acima do GIF
            backgroundGif.SendToBack();
        }
		
        // Método para o aperto do botão e iniciar o Jogo
        void iniciarClick(object sender, EventArgs e)
        {
            MainForm.abrirJogo = true;
            this.Close();
        }
    }
}