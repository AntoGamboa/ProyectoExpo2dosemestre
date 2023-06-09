/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 17/05/2023
 * Hora: 05:27 p.m.
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
	/// Description of ActualizarCliente.
	/// </summary>
	public partial class ActualizarCliente : Form
	{
		coleccionClientes Coleccion;
		public ActualizarCliente()
		{
			InitializeComponent();
			Coleccion=new coleccionClientes();
		}
		void BtnActualizarClick(object sender, EventArgs e)
		{
			try {
				ValidarCampos();
				using(coleccionClientes ActualizarC = new coleccionClientes())
				{
					ActualizarC.CargarClientes();
					foreach (Clientes r in ActualizarC.Listaclientes) 
					{
						if (r.CI == cedula.Textos.Trim()) 
						{
							ActualizarC.Actualizar(CapturarDatos(), cedula.Textos.Trim());
						break;
						}	
					}
					MessageBox.Show("Se ha realizado la actualización exitosamente!","Aviso");
					this.Dispose();
				}
			
			} catch (ArgumentException Error) {
				
				MessageBox.Show(Error.Message);
			}
			
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
			DateTime FecIngreso=Convert.ToDateTime(lblFechaingreso.Text);
			Clientes registrado= new Clientes(Cedula,Nombre,Apellido,Direccion,NroResidencia,Telefono,FechaNac,Correo,FecIngreso);
			return registrado;
		}
		void ValidarCampos()
		{	
			nombre.Textos.Trim().CadenaNoVacia("Nombre");
			apellido.Textos.Trim().CadenaNoVacia("Apellido");
			cedula.Textos.Trim().CadenaNoVacia("Cedula");
			direccion.Textos.Trim().CadenaNoVacia("Direccion");
			nroResidencia.Textos.Trim().CadenaNoVacia("Numero Residencia");
			if(nacimiento.Value>DateTime.Now) throw new ArgumentException("Fecha invalida");
			nombre.Textos.Trim().SoloLetras("Nombre");
			apellido.Textos.Trim().SoloLetras("Apellido");
			cedula.Textos.Trim().ValidarSolonumero("Cedula");
		}
		void validarEmail()
		{
			string PatronBusqueda="[a-zA-Z0-9._%+-]+@[a-zA-Z0-9-]+.+.[a-zA-Z]{2,4}";
			if(!Regex.IsMatch(correo.Textos.Trim(),PatronBusqueda)) throw new ArgumentException("Introduza un Email Correcto");
			
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
	}
}
