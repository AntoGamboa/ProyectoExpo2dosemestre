/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 17/05/2023
 * Hora: 02:28 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ProyectoFinal.Clases.RegistroClient
{
	public class coleccionClientes:IDisposable
	{
		private List<Clientes> _listaclientes;
		public List<Clientes> Listaclientes {get { return _listaclientes; }set { _listaclientes = value; }}
		string Ruta="bdClientes.txt";
		
		public coleccionClientes()
		{
			_listaclientes= new List<Clientes>();
		}
		
		public void AgregarCliente(Clientes Agregado)
		{
			using(FileStream stream= new FileStream(Ruta,FileMode.Append))
			{
				BinaryFormatter serializar = new BinaryFormatter();
				serializar.Serialize(stream,Agregado);
			}
		}
		
		public void CargarClientes()
		{
			if(File.Exists(Ruta))
			{
				using(FileStream stream=new FileStream(Ruta,FileMode.Open))
				{
					BinaryFormatter Deserializar= new BinaryFormatter();
					while(stream.Position<stream.Length)
					{
						Clientes Cargado= Deserializar.Deserialize(stream) as Clientes;
						_listaclientes.Add(Cargado);
					}
				}
			}
		}
		private void Sobrescribir()
		{
			using(FileStream stream = new FileStream(Ruta,FileMode.Create))
			{
				BinaryFormatter Serializar= new BinaryFormatter();
				foreach(Clientes x in Listaclientes)
				{
					Serializar.Serialize(stream,x);
				
				}
			}
		}
		
		public void Actualizar(Clientes Actualizado, string ci)
		{
			int PosicionenLista=Buscar(ci);
			_listaclientes[PosicionenLista]=Actualizado;
			Sobrescribir();
		}
		
		
		
		public bool Encontrar(string CI)
		{
			bool Encontrado=false;
			foreach(Clientes X in _listaclientes)
			{
				if(X.CI==CI)
				{
					Encontrado=true;
				}
			}
			return Encontrado;
		}
		public int Buscar(string ci)
		{
			int Contador=0,Posicion=-1;
			foreach(Clientes x in _listaclientes)
			{
				if(x.CI==ci)
				{
					Posicion=Contador;
					break;
				}
				Contador++;
			}
			return Posicion;
		}
		
		
		
		
		
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		
		}
		
	}
}
