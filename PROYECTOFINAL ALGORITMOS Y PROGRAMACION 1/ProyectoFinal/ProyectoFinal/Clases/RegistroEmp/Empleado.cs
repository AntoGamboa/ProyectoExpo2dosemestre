/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 03/05/2023
 * Hora: 12:00 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
// 
using System;

namespace ProyectoFinal.Clases.RegistroEmp
{
	[Serializable]
	public class Empleado
	{
		private string nombre;
		private string apellido;
		private string usuario;
		private string correo;
		private string contraseña;
		private bool aceptarTerminos;

		public string _nombre{get{return nombre;}set{nombre=value;}}
		public string _apellido{get{return apellido;}set{apellido=value;}}
		public string _usuario{get{return usuario;}set{usuario=value;}}
		public string _correo{get{return correo;}set{correo=value;}}
		public string _contraseña{get{return contraseña;}set{contraseña=value;}}
		public bool  _aceptarterminos {get{return aceptarTerminos;}set{aceptarTerminos=value;}}

		
		public Empleado()
		{
			nombre="";apellido="";usuario="";correo="";contraseña="";aceptarTerminos=false;
		
		}
		public Empleado(string nombre,string apellido,string usuario,string correo,string contraseña,bool aceptarterminos)
		{
			this.nombre=nombre;this.apellido=apellido;this.usuario=usuario;this.correo=correo;
			this.contraseña=contraseña;this.aceptarTerminos=aceptarterminos;
		
		}
	}
}
