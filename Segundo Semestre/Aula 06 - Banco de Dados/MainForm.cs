/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 13/06/2025
 * Hora: 21:20
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Banco_de_Dados
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		MySqlConnection minhaConexao;
		string meuServidor = "localhost";
		string meuBanco = "banco_csharp";
		string minhaTabela = "cadastro";
		string meuUsuario = "root";
		string minhaSenha = "etecembu@123";
		
		public void Conecte(string servidor, string bancoDados, string usuarioBD, string senhaBD)
		{
			minhaConexao = new MySqlConnection("server=" + servidor +
			                                   "; database=" + bancoDados +
			                                   "; uid=" + usuarioBD +
			                                   "; password=" + senhaBD);
		}
		
		void Abrir()
		{
			minhaConexao.Open();
		}
		void Fechar()
		{
			minhaConexao.Close();
		}
		public void PreencheTabela(System.Windows.Forms.DataGridView dataGridView)
		{
			Abrir();
			
			MySqlDataAdapter meuAdaptador = new MySqlDataAdapter("Select * from "
			                                                     + minhaTabela, minhaConexao);
			System.Data.DataSet dataSet = new System.Data.DataSet();
			dataSet.Clear();
			meuAdaptador.Fill(dataSet, minhaTabela);
			dataGridView.DataSource = dataSet;
			dataGridView.DataMember = minhaTabela;
			
			Fechar();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (button1.Text == "Conectar")
				try 
				{
				Conecte(meuServidor, meuBanco, meuUsuario, minhaSenha);
				PreencheTabela(dataGridView1);
				button1.BackColor = Color.Green;
				button1.Text = "Desconectar";
				MessageBox.Show("Conectado com sucesso");
				}
				catch
				{
					button1.BackColor = Color.LightSalmon;
					button1.Text = "Conectar";
					MessageBox.Show("Não Conectado");
				}
			else
			{
				Fechar();
				button1.BackColor = Color.DarkSalmon;
				button1.Text = "Conectar";
				MessageBox.Show("Desconectado");
			}
			
		}
	}
}
