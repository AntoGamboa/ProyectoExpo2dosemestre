/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 03/05/2023
 * Hora: 12:28 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProyectoFinal.Clases.RegistroEmp
{
	public class coleccionE
	{
		List<Empleado> Lista;
		public coleccionE()
		{
			Lista=new List<Empleado>();
		}
		
		#region Funciones para serializar el objeto y cargarlos a la lista
		
		public void AgregarUsuario(Empleado Agregado)
		{
			using(FileStream stream= new FileStream("Empleados.bin",FileMode.Append))
			{
				
				BinaryFormatter serializar = new BinaryFormatter();
				serializar.Serialize(stream,Agregado);                                                                 
			}
		}
		
		
		
		
		public void CapturarRegistros()
		{
			if(File.Exists("Empleados.bin"))
			{
				using(FileStream stream = File.Open("Empleados.bin",FileMode.Open))
				{
					BinaryFormatter Deserializar= new BinaryFormatter();
					while(stream.Position<stream.Length)
					{
						Empleado Cargado= Deserializar.Deserialize(stream) as Empleado;
						Lista.Add(Cargado);
					}
				}
			}
		}
		
		#endregion 
		
		
		#region funciones de buscar y encontrar 
		//aqui verificamos si existe un usuario el ciclo recorre toda la lista
		// y si el atributo usuario coincide con el parametro es por que el usuario introducido existe
		
		public bool VerificarUsuario(string usuario)
		{
			bool Existe=false;
			foreach(Empleado x in Lista)
			{
				if(x._usuario==usuario)
				{
					Existe= true;
					break;
				}
			}
			return Existe;
		}
		
		
		
		public bool VerificarEmail(string email)
		{
			bool Existe=false;
			foreach(Empleado x in Lista)
			{
				if(x._correo==email)
				{
					Existe= true;
					break;
				
				}
			
			}
			return Existe;
		}
		
	

		public bool VerificarDatosRegistro(string UserEmail,string Contraseña)
		{
			bool Permitido=false;
			foreach(Empleado x in Lista)
			{
				if(VerificarUsuario(UserEmail)&&x._contraseña==Contraseña)
				{
					Permitido=true;		
					break;
				}
				else if(VerificarEmail(UserEmail)&&x._contraseña==Contraseña)
				{
					Permitido=true;		
					break;
				}
			}
			return Permitido;
		}
		#endregion 
	}
}
