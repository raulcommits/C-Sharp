/*
 * Criado por Fabianinho
 * Usuário: FABIANO
 * Data: 07/03/2025
 * Hora: 21:05
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aula_03
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		Class1 pers = new Class1();
		Class1 pers2 = new Class1();
		Random dn = new Random();
		
		void Button1Click(object sender, EventArgs e)
		{
			pers.nome = "Layla";
			pers.hp = dn.Next();
			pers.forca = dn.Next();
			pers.nomeImagem = "fada2.png";
			
			pers2.nome = "Patholyno";
			pers2.hp = dn.Next();
			pers2.forca = dn.Next();
			pers2.nomeImagem = "mago.jpg";
			
			label1.Text = "Nome: " + pers.nome;
			label2.Text = "HP: " + pers.hp;
			label3.Text = "Força: " + pers.forca;
			pictureBox1.Load(pers.nomeImagem);
			
			label4.Text = "Nome: " + pers2.nome;
			label5.Text = "HP: " + pers2.hp;
			label6.Text = "Força: " + pers2.forca;
			pictureBox2.Load(pers2.nomeImagem);
		}
	}
}
