/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 20/05/2023
 * Hora: 10:52 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
namespace ProyectoFinal.Clases.Prestamos
{
	/// <summary>
	/// Description of ClasePrestamos.
	/// </summary>
	public class ClasePrestamos
	{
		private string _cedula;
		public string Cedula {get { return _cedula; }set { _cedula = value; }}
		
		private string _nombre;
		public string Nombre {get { return _nombre; }set { _nombre = value; }}
		
		private	string _apellido;
		public string Apellido {get { return _apellido; }set { _apellido = value; }}
		
		private string _direccion;
		public string Direccion {get { return _direccion; }set { _direccion = value; }}
		
		private float _total;
		public float Total {get { return _total; }set { _total = value; }}
		
		private DateTime _fechaentrega;
		public DateTime Fechaentrega {get { return _fechaentrega; }set { _fechaentrega = value; }}
		
		
		private List<ProductoVendido> _productosfact;
		public List<ProductoVendido> Productosfact {get { return _productosfact; }set { _productosfact = value; }}
		
		public ClasePrestamos()
		{
			Cedula="";
			Nombre="";
			Apellido="";
			Direccion="";
			Total=0;
			Fechaentrega=DateTime.Now;
			Productosfact=new List<ProductoVendido>();

				
		}
		public ClasePrestamos(string cedula,string nombre,string apellido,string direccion,float total,List<ProductoVendido> vendidos)
		{
			Cedula=cedula;
			Nombre=nombre;
			Apellido=apellido;
			Direccion=direccion;
			Total=total;
			Fechaentrega=DateTime.Now;
			Productosfact=vendidos;

		
		}
		
	}
	public class ProductoVendido
	{
		private string _codigo;
		public string Codigo {get { return _codigo; }set { _codigo = value; }}
			
		private string _titulo;
		public string Titulo {get { return _titulo; }set { _titulo = value; }}
			
		private string _tipomedio;
		public string Tipomedio {get { return _tipomedio; }set { _tipomedio = value; }}
			
		private float _precio;
		public float Precio {get { return _precio; }set { _precio = value; }}
		
		private int _cantidad;
		public int Cantidad {get { return _cantidad; }set { _cantidad = value; }}
		
		DateTime _fechaentrega;
		public DateTime Fechaentrega {get { return _fechaentrega; }set { _fechaentrega = value; }}
		
		DateTime _fechadevolucion;
		public DateTime Fechadevolucion {get { return _fechadevolucion; }set { _fechadevolucion = value; }}
			
		
		public ProductoVendido()
		{
			Codigo="";
			Titulo="";
			Tipomedio="";
			Precio=0;
			Fechaentrega=DateTime.Now;
			Fechadevolucion=new DateTime(200,1,1);
		}
		public ProductoVendido(string codigo,string titulo,string tipomedio,float precio,DateTime fechadevolucion,int cantidad)
		{
			Codigo=codigo;
			Titulo=titulo;
			Tipomedio=tipomedio;
			Precio=precio;
			Fechaentrega=DateTime.Now;
			Fechadevolucion=fechadevolucion;
			Cantidad=cantidad;
		}
		
	}	
}
