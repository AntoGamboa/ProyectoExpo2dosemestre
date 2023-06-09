/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 14/05/2023
 * Hora: 07:14 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
namespace ProyectoFinal.Clases.Inventario
{
	public class ColeccionDVD: IDisposable
	{
		private List<DVD> lista;
		public List<DVD> Lista {get { return lista; }set { lista = value; }}
		string Ruta="BdDVD.txt";
		public ColeccionDVD()
		{
			lista=new List<DVD>();
		}
		
		public void AgregarDVD(DVD Agregado)
		{
			using(FileStream stream= new FileStream(Ruta,FileMode.Append))
			{
				BinaryFormatter serializar = new BinaryFormatter();
				serializar.Serialize(stream,Agregado);
			}
		}
		
		public void CargarDVD()
		{
			if(File.Exists(Ruta))
			{
				using(FileStream stream=new FileStream(Ruta,FileMode.Open))
				{
					BinaryFormatter Deserializar= new BinaryFormatter();
					while(stream.Position<stream.Length)
					{
						DVD Cargado= Deserializar.Deserialize(stream) as DVD;
						Lista.Add(Cargado);
					}
				}
			}
		}
		
		private void Sobrescribir()
		{
			using(FileStream stream = new FileStream(Ruta,FileMode.Create))
			{
				BinaryFormatter Serializar= new BinaryFormatter();
				foreach(DVD x in Lista)
				{
					Serializar.Serialize(stream,x);
				
				}
			}
		}
		
		
		public void Actualizar(DVD Actualizado, string Codigo)
		{
			int PosicionenLista=Buscar(Codigo);
			Lista[PosicionenLista]=Actualizado;
			Sobrescribir();
		}
		
		
		
		public bool Encontrar(string codigo)
		{
			bool Encontrado=false;
			foreach(DVD X in Lista)
			{
				if(X.Codigo==codigo)
				{
					Encontrado=true;
					break;
				}
			
			}
			return Encontrado;
		}
		
		
		public int Buscar(string codigo)
		{
			int Contador=0,Posicion=-1;
			foreach(DVD x in Lista)
			{
				if(x.Codigo==codigo)
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
		public void Desactivar(string Codigo)
		{
			
		
		}
			
		
	}
	
}
