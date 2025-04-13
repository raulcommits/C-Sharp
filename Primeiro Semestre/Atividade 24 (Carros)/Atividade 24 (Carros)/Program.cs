/*
 * Criado por Fabianinho
 * Usuário: FABIANO
 * Data: 26/11/2024
 * Hora: 21:33
 */
using System;
using System.Windows.Forms;

namespace Atividade_24__Carros_
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
