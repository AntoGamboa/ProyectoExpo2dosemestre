/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 17/05/2023
 * Hora: 03:07 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoFinal.Clases.RegistroClient;
using ProyectoFinal.Clases;
using System.Text.RegularExpressions;

namespace ProyectoFinal.Formularios.Modulos.Gestion_Clientes.cudclientes
{
	/// <summary>
	/// Description of FormRegistrar.
	/// </summary>
	public partial class FormRegistrar : Form
	{
		coleccionClientes Coleccion;
		public FormRegistrar()
		{
		
			InitializeComponent();
			Coleccion= new coleccionClientes();
			lblFechaingreso.Text="cliente registrado el día: "+ DateTime.Now.ToShortDateString();
			btnAgregar.Click+= new EventHandler(btnAgregar_Click);
		}

		void btnAgregar_Click(object sender, EventArgs e)
		{
			try
			{
				Coleccion.CargarClientes();
				ValidarCampos();
				validarEmail();
				validarcedulaexistente(cedula.Textos);
				Coleccion.AgregarCliente(CapturarDatos());
				LimpiarForm();
				MessageBox.Show("Cliente Registrado Exitosamente");
				Coleccion.Listaclientes.Clear();
			
			}
			catch(Validaciones ex)
			{
				Validaciones.EnviarMensajes(ex.Message);
			
			}
		}
	

		void validarcedulaexistente(string cedula)
		{
			if(Coleccion.Encontrar(cedula)) throw new Validaciones("20");
		}
	
		void validarsololetras(string campo)
		{
			string PatronBusqueda="[a-zA-zñÑ]";
			if(!Regex.IsMatch(campo.Trim(),PatronBusqueda)) {throw new Validaciones("6");}
		
		}
		void validarsolonumeros(string campo)
		{
			string PatronBusqueda="[0-9]";
			if(!Regex.IsMatch(campo.Trim(),PatronBusqueda)) {throw new Validaciones("23");}
		
		}
		Clientes CapturarDatos()
		{
			string Cedula= cedula.Textos;
			string Nombre= nombre.Textos;
			string Apellido= apellido.Textos;
			string Direccion= direccion.Textos;
			string NroResidencia = nroResidencia.Textos;
			string Correo= correo.Textos;
			string Telefono= telefono.Textos;
			DateTime FechaNac=nacimiento.Value;
			DateTime FecIngreso= DateTime.Now;
			Clientes registrado= new Clientes(Cedula,Nombre,Apellido,Direccion,NroResidencia,Telefono,FechaNac,Correo,FecIngreso);
			return registrado;
		}
		void ValidarCampos()
		{	
			if(nombre.Textos.Trim()=="") throw new Validaciones("0");
			else if(apellido.Textos.Trim()=="") throw new Validaciones("1");
			else if(cedula.Textos.Trim() == "") throw new Validaciones("22");
			else if(direccion.Textos.Trim() =="") throw new Validaciones("22");
			else if(nroResidencia.Textos.Trim() == "") throw new Validaciones("22");
			else if(nroResidencia.Textos.Trim() == "") throw new Validaciones("22");
			else if(nacimiento.Value>DateTime.Now) throw new Validaciones("24");
			validarsololetras(nombre.Textos.Trim());
			validarsololetras(apellido.Textos.Trim());
			validarsolonumeros(cedula.Textos.Trim());


			
		}
		void validarEmail()
		{
			string PatronBusqueda="[a-zA-Z0-9._%+-]+@[a-zA-Z0-9-]+.+.[a-zA-Z]{2,4}";
			if(!Regex.IsMatch(correo.Textos.Trim(),PatronBusqueda)) throw new Validaciones("10");
			
		}
		void LimpiarForm()
		{
			nombre.Textos="";
			apellido.Textos="";
			cedula.Textos="";
			direccion.Textos="";
			nroResidencia.Textos="";
			correo.Textos="";
			telefono.Textos= "";
			nacimiento.Value= DateTime.Now;
			
		}
		
		void CedulaKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == Convert.ToChar(Keys.Enter)) nombre.Focus();
			
		}
		
		void NombreKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == Convert.ToChar(Keys.Enter)) apellido.Focus();
		}
		
		void ApellidoKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == Convert.ToChar(Keys.Enter)) direccion.Focus();
		}
		
		void DireccionKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == Convert.ToChar(Keys.Enter)) correo.Focus();
		}
		
		void CorreoKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == Convert.ToChar(Keys.Enter)) nroResidencia.Focus();
		}
		
		void NroResidenciaKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == Convert.ToChar(Keys.Enter)) telefono.Focus();
		}
	}
}
