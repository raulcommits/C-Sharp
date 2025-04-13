/*
 * Criado por Fabianinho
 * Usuário: FABIANO
 * Data: 26/11/2024
 * Hora: 21:33
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_24__Carros_
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			try
			{
				rtb1.LoadFile("PlacaCarros.txt",RichTextBoxStreamType.PlainText);
			} 	catch
				{
					MessageBox.Show("Erro ao carregar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
		}
		void Button1Click(object sender, EventArgs e)
		{
			// Limpa o ListBox antes de adicionar novos itens
            listBox1.Items.Clear();

			
			//Obtém o dia selecionado no ComboBox
			string dia = comboBox1.SelectedItem.ToString();
			
			// Ignora linhas vazias
			if (string.IsNullOrEmpty(dia))
            {
                MessageBox.Show("Selecione um dia no ComboBox!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
			
			
			foreach (string linha in rtb1.Lines)
			{
				if (!string.IsNullOrWhiteSpace(linha)) // Ignora linhas vazias
				{
					// Divide a linha nos campos esperados (Motorista, Placa)
					string[]dados = linha.Split('\t');
					if (dados.Length >=2) // Garante que a linha tem pelo menos Motorista e Placa
					{
						string placa = dados [0].Trim();
						string motorista = dados[1].Trim();
						 // Valida se a placa possui caracteres suficientes
                      
						 if (placa.Length >= 7)
                        {
                        	char UltimoChar = placa[placa.Length -1];
                          // Verifica se é um número válido
                            if (char.IsDigit(UltimoChar))
                            {
                                int numFinal = int.Parse(UltimoChar.ToString());
	
                                // Verifica o dia de folga com base no último número
                                if ((dia == "Segunda" && (numFinal == 1 || numFinal == 2)) ||
                                    (dia == "Terça" && (numFinal == 3 || numFinal == 4)) ||
                                    (dia == "Quarta" && (numFinal == 5 || numFinal == 6)) ||
                                    (dia == "Quinta" && (numFinal == 7 || numFinal == 8)) ||
                                    (dia == "Sexta" && (numFinal == 9 || numFinal == 0)))
                                   
                                {
                                    listBox1.Items.Add(motorista); // Adiciona o motorista à lista
                                }
                            }
						}
                         else
                        	{
                            MessageBox.Show("A placa está incompleta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        	}
                    }	
                    else
                   	 	{
                        MessageBox.Show("Linha mal formatada no RichTextBox.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    	}
					
					} 
				}
		
					// Caso nenhum motorista seja encontrado
           			 if (listBox1.Items.Count == 0)
           				 {
                			listBox1.Items.Add("Nenhum motorista está de folga nesse dia.");
           				 }
		}
	}
}
