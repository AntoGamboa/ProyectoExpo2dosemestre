/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 17/05/2023
 * Hora: 02:20 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ProyectoFinal.Clases.RegistroClient
{
	[Serializable]
	public class Clientes
	{
		protected string _CI;
		protected string _Nombre;
		protected string _Apellidos;
		protected DateTime _FechaDN;
		protected string _DireccionHabitacion;
		protected string _Correo;
		protected string _NumeroTLF;
		protected bool _Activo;
		protected string _numeroresidencia;
		protected DateTime _fechaingreso;
		
		public DateTime Fechaingreso {get { return _fechaingreso; }set { _fechaingreso = value; }}
		public string Numeroresidencia {get { return _numeroresidencia; }set { _numeroresidencia = value; }}
		public bool Activo {get { return _Activo; }set { _Activo = value; }}
		public string CI {get{return _CI;}set{_CI=value;}}
		public string Nombre{get{return _Nombre;}set{_Nombre=value;}}
		public string Apellidos {get{return _Apellidos;}set{_Apellidos=value;}}
		public DateTime FechaDN {get{return _FechaDN;}set{_FechaDN=value;}}
		public string DireccionHabitacion {get{return _DireccionHabitacion;}set{_DireccionHabitacion=value;}}
		public string Correo {get{return _Correo;}set{_Correo= value;}}
		public string NumeroTLF {get{return _NumeroTLF;}set{_NumeroTLF= value;}}
		
		public Clientes()
		{
		 _CI= ""; 
		 _Nombre= "";
		 _Apellidos= "";
		 FechaDN= DateTime.Now;
		 
		_DireccionHabitacion= "";
		_Correo= "";
		_NumeroTLF="";
		Activo=true;

		Numeroresidencia="";
		Fechaingreso=DateTime.Now;

		
		}
		
		public 	Clientes( string ci , string name, string apellidos ,   string direccion, string numeroresidencia, string Numerotlf,DateTime fechadn,string correo,DateTime fecingreso)
		{
			this.CI= ci;
			this.Nombre= name;
			this.Apellidos= apellidos;
			FechaDN=fechadn;
			
			this.DireccionHabitacion= direccion;
			this.Correo= correo;
			this.NumeroTLF= Numerotlf;
			Activo=true;
			Fechaingreso=fecingreso;
			Numeroresidencia=numeroresidencia;
		}
		public override string ToString()
		{
			string Estado=(Activo==true?"Activo":"Inactivo");
			return Estado;
		}

		
		
	}
}
