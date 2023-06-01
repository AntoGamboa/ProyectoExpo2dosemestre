using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProyectoFinal.Formularios;
using ControlesPersonalizados;
using System.IO;
using ProyectoFinal.Clases.RegistroEmp;

namespace ProyectoFinal
{

	public partial class InicioSesion : Form
	{
		coleccionE UsuariosSistema;
		public InicioSesion()
		{
			#region Eventos y constructores del formulario 
			InitializeComponent();
		

			//Eventos Click del formulario
			btnSalir.Click+= new EventHandler(btnSalir_Click);
			BtnRegistrarse.Click += new EventHandler(BtnRegistrarse_Click);
			btnIniciarSesion.Click += new EventHandler(btnIniciarSesion_Click);
			
			//Eventos para mover el formulario sin bordes
			panelPic.MouseDown+= new MouseEventHandler(panelPic_MouseDown);
			panel2.MouseDown += new MouseEventHandler(panel2_MouseDown);
			
			//Evento para manejar la hora del lado inferior izquierdo
			horaactual.Tick += new EventHandler(horaactual_Tick);
			
			//Evento de animacion del boton salir
			btnSalir.MouseHover += new EventHandler(btnSalir_MouseHover);
			btnSalir.MouseLeave += new EventHandler(btnSalir_MouseLeave);
			
			//Evento de pulsacion de teclas 
			Usuario.KeyPress+= new KeyPressEventHandler(Usuario_KeyPress);
			Contraseña.KeyPress += new KeyPressEventHandler(Contraseña_KeyPress);
			//esta linea crea la lista donde se van a cargar los registros
			
			// para poder verificar si la contraseña o el usuario son correctos
			UsuariosSistema= new coleccionE();
			
			// aqui mandamos los objetos que estan el archivo para la lista
			UsuariosSistema.CapturarRegistros();
			#endregion
		}
	
		#region FuncionalidadesFormulario
		
		//Api para poder mover el formulario sin bordes
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
		
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
       
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
        void panelPic_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		
        #endregion
        
		#region Eventos de pulsacion tecla enter
        //Eventos keypress para interactividad 
        void Contraseña_KeyPress(object sender, KeyPressEventArgs e)
		{
        	if(e.KeyChar==Convert.ToChar(Keys.Enter))
        	{
        		string UserEmail=Usuario.Textos.ToLower().Trim();
				string UserPassword=Contraseña.Textos.ToLower();
			
				if(UsuariosSistema.VerificarDatosRegistro(UserEmail,UserPassword)){
				AbrirFormInicioSesion();
				}
				else
				{
					MessageBox.Show("Usuario o Contraseña invalidos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
        	}
        	
        	else if(e.KeyChar==Convert.ToChar(Keys.Escape)) this.Dispose();

			
		}
		

		void Usuario_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar==Convert.ToChar(Keys.Enter)) Contraseña.Focus();
			else if(e.KeyChar==Convert.ToChar(Keys.Escape)) this.Dispose();
			
		}
		#endregion 
		
		#region eventos click del formulario
	
		//Animacion al pasar el mouse por encima del boton de salir(hace que el fondo se ponga rojo)
		void btnSalir_MouseLeave(object sender, EventArgs e)
		{
			btnSalir.BackColor= Color.WhiteSmoke;
		}

		void btnSalir_MouseHover(object sender, EventArgs e)
		{
			btnSalir.BackColor= Color.FromArgb(245,74,80);
		}

		
		//Eventos Click del formulario de inicio de sesion 
		void BtnRegistrarse_Click(object sender, EventArgs e)
		{
			this.Visible=false;
			registro Formulario= new registro();
			Formulario.ShowDialog();
			Formulario=null;
			UsuariosSistema.CapturarRegistros();
			this.Visible=true;
		}
		
		void btnIniciarSesion_Click(object sender, EventArgs e)
		{
			string UserEmail=Usuario.Textos.ToLower().Trim();
			string UserPassword=Contraseña.Textos.ToLower();
			
			if(UsuariosSistema.VerificarDatosRegistro(UserEmail,UserPassword)){
				AbrirFormInicioSesion();
			}
			else
			{
				MessageBox.Show("Usuario o Contraseña invalidos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		void btnSalir_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
		#endregion 
		
		#region otrasfuncionalidades
		//Evento del reloj parte inferior Izquierda 
		void horaactual_Tick(object sender, EventArgs e)
		{
			HORA.Text= DateTime.Now.ToLongTimeString();
		}
		
		void AbrirFormInicioSesion()
		{
			MessageBox.Show("ah iniciado sesion correctamente");
			this.Visible=false;
			FormEmpleado Formulario= new FormEmpleado();
			Formulario.ShowDialog();
			Formulario=null;
			this.Visible=true;
		}
		#endregion 
		
	}
}
