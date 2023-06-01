/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 14/05/2023
 * Hora: 04:43 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ProyectoFinal.Clases.Inventario
{
	[Serializable]
	public class DVD
	{
		private string _codigo;
		public string Codigo {get { return _codigo; }set { _codigo = value; }}
		
		private string _titulo;
		public string Titulo {get { return _titulo; }set { _titulo = value; }}
		
		private DateTime _añoemision;
		public DateTime Añoemision {get { return _añoemision; }set { _añoemision = value; }}
		
		private int _tipomedio;
		public int Tipomedio {get { return _tipomedio; }set { _tipomedio = value; }}
		
		private string _descripcion;
		public string Descripcion {get { return _descripcion; }set { _descripcion = value; }}
		
		private int existencia;
		public int Existencia {get { return existencia; }set { existencia = value; }}
		
		private DateTime _fechaingreso;
		public DateTime Fechaingreso {get { return _fechaingreso; }set { _fechaingreso = value; }}
		
		private bool _prestamo;
		public bool Prestamo {get { return _prestamo; }set { _prestamo = value; }}
		
		private string _imagen;
		public string Imagen {get { return _imagen; }set {_imagen = value;}}
		
		private float _precio;
		public float Precio {get { return _precio;}set { _precio = value; }}
		
		private bool _activo;
		public bool Activo {get { return _activo; }set { _activo = value; }}
		
		
		
		
		public DVD()
		{
			Codigo="";Titulo="";Añoemision=new DateTime(2000,2,28); Tipomedio=-1;Descripcion="";existencia=0;
			Fechaingreso=DateTime.Now; Prestamo=false; Imagen="";Precio=0;Activo=true; 
		}
		public DVD(string codigo,string titulo,string descripcion,DateTime añoemosion,int tipomedio,string imagen,int existencia,
		           float precio,bool prestamo,DateTime fechaingreso)
		{
			Codigo=codigo;Titulo=titulo;Añoemision=añoemosion;Tipomedio=tipomedio;Descripcion=descripcion;Existencia=existencia;
			Fechaingreso=fechaingreso;Prestamo=prestamo;Imagen=imagen;Precio=precio;Activo=true; 
		}
		
		
		public override string ToString()
		{
			string Estado=(Prestamo==true? "Puede prestarse.":"No puede prestarse.");
			return string.Format("{0}",Estado);
		}
		
		
		public string TipoDVD()
		{
			string medio="";
			switch (Tipomedio) {
				case 0:
					medio="PISTA DE AUDIO MP3.";
					break;
				case 1:
					medio="PELICULA EN DVD.";
					break;
				case 2:
					medio="VIDEOJUEGO.";
					break;
				default:
					break;
			}
			return medio;
		}
		public string EstadoProduco()
		{
			string EstaActivo=(Activo==true?"Activo":"Desactivado");
			return EstaActivo;
		
		}

	}
}
