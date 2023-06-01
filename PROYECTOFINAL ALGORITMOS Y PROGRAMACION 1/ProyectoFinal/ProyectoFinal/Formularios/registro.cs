/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 30/04/2023
 * Hora: 10:00 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using ProyectoFinal.Clases;
using ControlesPersonalizados;
using ProyectoFinal.Clases.RegistroEmp;


namespace ProyectoFinal.Formularios
{

	public partial class registro : Form
	{
		coleccionE ColeRegistros;
		public registro()
		{
			#region Constructores
			InitializeComponent();
			
			//Eventos Keypress
			nombre.KeyPress += new KeyPressEventHandler(nombre_KeyPress);
			apellido.KeyPress+= new KeyPressEventHandler(apellido_KeyPress);
			usuario.KeyPress += new KeyPressEventHandler(usuario_KeyPress);
			correo.KeyPress += new KeyPressEventHandler(correo_KeyPress);
			contraseña.KeyPress += new KeyPressEventHandler(contraseña_KeyPress);
			confirmarContraseña.KeyPress += new KeyPressEventHandler(confirmarContraseña_KeyPress);
			AceptarTerminos.KeyPress+= new KeyPressEventHandler(AceptarTerminos_KeyPress);
			
			//Eventos Click de los botones y mouseDown para poder mover el formulario sin bordes 	
			btnsalir.Click+= new EventHandler(btnsalir_Click);
			this.MouseDown += new MouseEventHandler(registro_MouseDown);
			btnRegistro.Click += new EventHandler(btnRegistro_Click);
			//lista que maneja el registro de usuario mas la anexion al archivo de los usurarios 
			ColeRegistros= new coleccionE();
			#endregion
		}

		#region Funcionalidad para mover el form
		//Api para poder mover el formulario sin bordes
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
		
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		void registro_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion
       
		#region Eventos para que al pulsar enter envie a la siguiente textbox
		//Eventos de teclado e interactividad
        
        void AceptarTerminos_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar==Convert.ToChar(Keys.Enter)) ValidarFormulario();
			else if(e.KeyChar==Convert.ToChar(Keys.Escape)) this.Dispose();
		}
        
        
        void confirmarContraseña_KeyPress(object sender, KeyPressEventArgs e)
		{
        	if(e.KeyChar==Convert.ToChar(Keys.Enter)) ValidarFormulario();
		}

		void contraseña_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar==Convert.ToChar(Keys.Enter)) confirmarContraseña.Focus();
			else if(e.KeyChar==Convert.ToChar(Keys.Escape)) this.Dispose();
			
		}

		void correo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar==Convert.ToChar(Keys.Enter)) contraseña.Focus();
			else if(e.KeyChar==Convert.ToChar(Keys.Escape)) this.Dispose();
			
		}

		void usuario_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar==Convert.ToChar(Keys.Enter)) correo.Focus();	
			else if(e.KeyChar==Convert.ToChar(Keys.Escape)) this.Dispose();
			
		}

		void apellido_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar==Convert.ToChar(Keys.Enter)) usuario.Focus();
			else if(e.KeyChar==Convert.ToChar(Keys.Escape)) this.Dispose();
			
	
		}

		void nombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar==Convert.ToChar(Keys.Enter)) apellido.Focus();
			else if(e.KeyChar==Convert.ToChar(Keys.Escape)) this.Dispose();
			
		}
		#endregion 
		
		#region eventos click del formulario
		//Eventos click
		void btnRegistro_Click(object sender, EventArgs e)
		{
			ValidarFormulario();
			
		}

		void btnsalir_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}		
		
		//validaciones y menanejo de las textbox
		#endregion
		
		#region Bloque para validar los controles del formulario de registro y poder crear el usuario en el archivo
		void ValidarFormulario()
		{
			try
				{
					ColeRegistros.CapturarRegistros();
					ValidarCamposVacios();
					ValidarTextos(nombre.Textos);
					ValidarTextos(apellido.Textos);
					ValidarConfirmacionContraseña();
					VAlidarUsuario(usuario.Textos);
					validarEmail();
					CrearUsuario();
					MessageBox.Show("Registro Exitoso","¡Mensaje!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					LimpiarForm();
				}
				catch(Validaciones ex)
				{
					Validaciones.EnviarMensajes(ex.Message);
					nombre.Focus();
				}	
		
		}
		#endregion
		
		#region Funcion para tomar los datos de las textbox y poder mandarlas al archivo de los registros
		
		// esta funcion captura los datos de las textbox del regisro y crea una instacia de tipo empleado
		// la cual se retorna para poder enviarla al contructor que crea el registro
		void CrearUsuario()
		{
			//captura el dato que esta puesto en la textbox y la enviar a la variables las cuales 
			// seran enviadas al contructor del empleado
			string Nombre= nombre.Textos;
			string Apellido= apellido.Textos;
			string Usuario= usuario.Textos.Trim();
			string Correo= correo.Textos;
			string Contraseña= contraseña.Textos;
			bool aceptarTerminos=AceptarTerminos.Checked;
			Empleado Datos = new Empleado(Nombre,Apellido,Usuario.ToLower(),Correo.ToLower(),Contraseña,aceptarTerminos);
			ColeRegistros.AgregarUsuario(Datos);
			
		}
		#endregion
		
		#region funciones para el manejo de excepciones y validaciones del formulario de registro
		void ValidarCamposVacios()
		{
			
			if(nombre.Textos.Trim()=="") throw new Validaciones("0");
			else if(apellido.Textos.Trim()=="") throw new Validaciones("1");
			else if(usuario.Textos.Trim()=="") throw new Validaciones("2");
			else if(correo.Textos.Trim()=="") throw new Validaciones("3");
			else if(contraseña.Textos.Trim()=="") throw new Validaciones("4");	
			else if(AceptarTerminos.Checked==false) throw new Validaciones("5");	
		}
		//valida que los textos no tengan numeros y tengan entre 3 y 12 caracteres
		void ValidarTextos(string Texto)
		{
			string PatronBusqueda="[a-zA-zñÑ]{3,12}";
			if(!Regex.IsMatch(Texto.Trim(),PatronBusqueda)) {throw new Validaciones("6");}
			
		}
		
		//esta funcion verifica si la contraseña coincide con la confrimacion
		void ValidarConfirmacionContraseña()
		{
			if(!contraseña.Textos.Equals(confirmarContraseña.Textos)) throw new Validaciones("8");
		
		}
		//esta funcion verifica si se esta creando una cuenta cuyo usuario ya existe
		void VAlidarUsuario(string Usuario)
		{
			if(ColeRegistros.VerificarUsuario(Usuario)) throw new Validaciones("9");
		}
		
		void validarEmail()
		{
			string PatronBusqueda="[a-zA-Z0-9._%+-]+@[a-zA-Z0-9-]+.+.[a-zA-Z]{2,4}";
			if(!Regex.IsMatch(correo.Textos.Trim(),PatronBusqueda)) throw new Validaciones("10");
			
		}
		#endregion
		
		#region funcion para vaciar los campos del formulario
		void LimpiarForm()
		{
			nombre.Textos="";
			apellido.Textos="";
			usuario.Textos="";
			correo.Textos="";
			contraseña.Textos="";
			confirmarContraseña.Textos="";
			AceptarTerminos.Checked=false;
		}
		#endregion
	}
}
