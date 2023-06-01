/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 01/05/2023
 * Hora: 12:13 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace ProyectoFinal.Clases
{
	/// <summary>
	/// Desctiption of Validaciones.
	/// </summary>
	public class Validaciones : Exception
	{
		public Validaciones()
		{
		}

	 	public Validaciones(string message) : base(message)
		{
		}

		public Validaciones(string message, Exception innerException) : base(message, innerException)
		{
		}
		public static void EnviarMensajes(string Codigo_Mensaje)
		{
			int CodigoError=0;
			try
			{
				CodigoError=int.Parse(Codigo_Mensaje);
				CodigoError= Convert.ToInt16(CodigoError);
			}
			catch
			{
				CodigoError=-1;			
			}
			finally
			{
				string MensajeError= GenerarError(CodigoError);
				MessageBox.Show(MensajeError,"Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				
			
			}
		
		}
		public static string GenerarError(int Codigo_Error)
		{
			string Texto_Error="";
			switch (Codigo_Error) 
			{
				case 0:
					Texto_Error="El Nombre no puede estar en blanco.";
					break;
				case 1:
					Texto_Error="El Apellido no puede estar en blanco.";
					break;
				case 2:
					Texto_Error="El Usuario no puede Estar en blanco.";
					break;
				case 3:
					Texto_Error="El Correo no puede Estar en blanco.";
					break;
				case 4:
					Texto_Error="La Contraseña no puede Estar en blanco.";
					break;
				case 5:
					Texto_Error="Debe aceptar los términos y condiciones del servicio.";
					break;
				case 6:
					Texto_Error="El nombre debe llevar letras y debe estar entre 3 y 12 caracteres";
					break;
				case 7:
					Texto_Error="No puede existir números, solo letras.";
					break;
				case 8:
					Texto_Error="Las contraseñas no coinciden.";
					break;
				case 9:
					Texto_Error="Este nombre de usuario ya se encuentra registrado.";
					break;
				case 10:
					Texto_Error="Por favor introduzca un Email correcto.";
					break;
				case 11:
					Texto_Error="El código no puede estar vacio.";
					break;
				case 12:
					Texto_Error="El título no puede estar vacio.";
					break;
				case 13:
					Texto_Error="La descripción no puede estar vacio.";
					break;
				case 14:
					Texto_Error="La emisión del medio no puede ser mayor a la fecha actual.";
					break;
				case 15:
					Texto_Error="Debe seleccionar un tipo de medio.";
					break;
				case 16:
					Texto_Error="La existencia no puede ser negativa.";
					break;
				case 17:
				Texto_Error="El precio no puede ser negativo.";
				break;
				case 18:
					Texto_Error="Error campos vacios o invalidos";
				break;
				case 19:
					Texto_Error="Ya existe un producto con el mismo código.";
				break;
				case 20:
					Texto_Error="No puede registrar un cliente con la cédula de uno ya existente.";
				break;
				case 21:
					Texto_Error="La cédula no puede llevar letras.";
				break;
				case 22:
					Texto_Error="No pueden haber campos en blanco.";
				break;
				case 23:
					Texto_Error="No pueden haber letras en la cédula.";
				break;;
				case 24:
					Texto_Error="La fecha de nacimiento es inválida.";
				break;
			case 25:
				 	Texto_Error="si no hay DVD producto no registrado con ese nombre";
				 break;
			case 26:
				 	Texto_Error="Este cliente no está registrado";
				 
				 break;
		
			
				default:
					Texto_Error="Error no identificado.";
					break;
				
				
			
			}
			return Texto_Error;
		
		}
	}
}