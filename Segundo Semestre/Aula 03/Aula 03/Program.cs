/*
 * Criado por Fabianinho
 * Usuário: FABIANO
 * Data: 07/03/2025
 * Hora: 21:05
 */
using System;
using System.Windows.Forms;

namespace Aula_03
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
