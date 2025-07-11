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
    public class Heroi : Personagem
    {
        // DECLARANDO INSTÂNCIAS PARA O HERÓI
    	Timer timerVoltarPose;
        Timer timerPulo;
        string estadoAtual = "";
        string direcaoAtual = "direita";
        bool estaPulando = false;
        int alturaInicial = 610;
        int fasePulo = 0;

        public Heroi()
        {
            // ATRIBUTOS DO HERÓI
        	Left = -10;
            Top = alturaInicial;
            velocidade = 40;
            LoadPoseDireita();
            pulo = 1;

            // TIMER PARA DIREÇÃO
            timerVoltarPose = new Timer();
            timerVoltarPose.Interval = 300;
            timerVoltarPose.Tick += (s, e) =>
            {
                if (direcaoAtual == "direita")
                    LoadPoseDireita();
                else
                    LoadPoseEsquerda();

                timerVoltarPose.Stop();
            };
            
			// TIMER PARA PULO
            timerPulo = new Timer();
            timerPulo.Interval = 40;
            timerPulo.Tick += TimerPulo_Tick;
        }

        public void MoveDir()
        {
            Left += velocidade;
            direcaoAtual = "direita";
            if (estadoAtual != "correr_dir")
            {
                Load("CorreNinja.gif");
                estadoAtual = "correr_dir";
            }

            if (Left >= 1600)
                Left = 0;

            timerVoltarPose.Stop();
            timerVoltarPose.Start();
        }

        public void MoveEsq()
        {
            Left -= velocidade;
            direcaoAtual = "esquerda";
            if (estadoAtual != "correr_esq")
            {
                Load("CorreNinja1.gif");
                estadoAtual = "correr_esq";
            }

            if (Left <= 0)
                Left = 0;

            timerVoltarPose.Stop();
            timerVoltarPose.Start();
        }

        public void MoveCima()
        {
            if (estaPulando) return;

            estaPulando = true;
            fasePulo = 0;
            Load("PuloNinja1.gif");
            timerPulo.Start();
        }

        void TimerPulo_Tick(object sender, EventArgs e)
        {
            if (fasePulo < 5)
            {
                Top -= velocidade;
            }
            else if (fasePulo < 10)
            {
                Top += velocidade;
            }

            fasePulo++;

            if (fasePulo >= 10)
            {
                timerPulo.Stop();
                estaPulando = false;

                if (direcaoAtual == "direita")
                    LoadPoseDireita();
                else
                    LoadPoseEsquerda();

                Top = alturaInicial;
            }
        }
        void LoadPoseDireita()
        {
            Load("PoseNinja.gif");
            estadoAtual = "parado_dir";
        }

        void LoadPoseEsquerda()
        {
            Load("PoseNinja1.gif");
            estadoAtual = "parado_esq";
        }
        public void Atacar()
		{
		    if (direcaoAtual == "direita")
		        Load("AtaqueNinjaDistancia.gif");
		    else
		        Load("AtaqueNinjaDistancia2.gif");
		
		    estadoAtual = "atacando";
		
		    Timer timerAtaque = new Timer();
		    timerAtaque.Interval = 180;
		    timerAtaque.Tick += (s, e) =>
		    {
		        if (direcaoAtual == "direita")
		            LoadPoseDireita();
		        else
		            LoadPoseEsquerda();
		
		        timerAtaque.Stop();
		        timerAtaque.Dispose();
		    };
		    timerAtaque.Start();
		}
    }
}
