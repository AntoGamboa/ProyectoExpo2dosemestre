/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 30/04/2023
 * Hora: 06:22 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;
using ControlesPersonalizados;

namespace ProyectoFinal
{
	
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
			Application.Run(new InicioSesion());
		}
		
	}
}
