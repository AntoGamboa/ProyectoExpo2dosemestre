/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 03/05/2023
 * Hora: 05:03 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Linq;
using ProyectoFinal.Formularios.Modulos.Gestion_DVD;
using ProyectoFinal.Formularios.Modulos.Gestion_Clientes;
using ProyectoFinal.Formularios.Modulos.Gestion_Prestamos;
using ProyectoFinal.Formularios.Modulos.ConsultaPrestamos;
using System.IO;
namespace ProyectoFinal.Formularios
{
	/// <summary>
	/// Description of FormEmpleado.
	/// </summary>
	public partial class FormEmpleado : Form
	{
		public FormEmpleado()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			btnsalir.Click += new EventHandler(btnsalir_Click);
			btnmaximizar.Click += new EventHandler(btnmaximizar_Click);
			btnocultar.Click+= new EventHandler(btnocultar_Click);
			btnminimizar.Click += new EventHandler(btnminimizar_Click);
			pneltitulo.MouseDown += new MouseEventHandler(pneltitulo_MouseDown);
			btnmenu.Click += new EventHandler(btnmenu_Click);
			btnGestionDvD.Click+= new EventHandler(btnGestionDvD_Click);
			btnGestionClientes.Click += new EventHandler(btnGestionClientes_Click);
			btnGestionPrestamos.Click += new EventHandler(btnGestionPrestamos_Click);
			btnProductosPrestado.Click+=new EventHandler(btnProductosPrestado_Click);
			btnIngresos.Click+=new EventHandler(btnIngresos_Click);
			btnexportar.Click+= new EventHandler(btnexportar_Click);
			btnImportar.Click+= new EventHandler(btnImportar_Click);
			
			Fecha.Tick += new EventHandler(Fecha_Tick);
		}

		void btnImportar_Click(object sender, EventArgs e)
		{
			openFileDialog1.Title="Seleccione los archivos De la Base de dates a Importar";
			openFileDialog1.Multiselect=true;
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
	        {
	            string rutaCarpetaDestino = Application.StartupPath;
	            string[] rutasArchivos = openFileDialog1.FileNames;
	            try
	            {
	                // Copiar y sobrescribir los archivos en la carpeta raíz
	                foreach (string rutaArchivo in rutasArchivos)
	                {
	                    string nombreArchivo = Path.GetFileName(rutaArchivo);
	                    string rutaDestino = Path.Combine(rutaCarpetaDestino, nombreArchivo);
	                    File.Copy(rutaArchivo, rutaDestino, true);
	                }
	
	                MessageBox.Show("Archivos copiados exitosamente en la carpeta raíz.");
	            }
	            catch (Exception ex)
	            {
	                MessageBox.Show("Error al copiar los archivos: {ex.Message}");
	            }
	        }
		}

		void btnexportar_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.Description="Seleccione la carpeta donde quiere Exportar La base de datos";
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
	        {
	            string carpetaDestino = folderBrowserDialog1.SelectedPath;
	            string rutaArchivo1 = "BdClientes.txt";
	            string rutaArchivo2 = "BdDvd.txt";
	            string rutaArchivo3 = "FactsVenta.txt";
	
	            try
	            {
	                File.Copy(rutaArchivo1, Path.Combine(carpetaDestino, Path.GetFileName(rutaArchivo1)),true);
	                File.Copy(rutaArchivo2, Path.Combine(carpetaDestino, Path.GetFileName(rutaArchivo2)),true);
	                File.Copy(rutaArchivo3, Path.Combine(carpetaDestino, Path.GetFileName(rutaArchivo3)),true);
	
	               MessageBox.Show("Archivos copiados exitosamente. ¡Por favor No cambie el Nombre de los archivos para evitar corrupciones en la base de Dato!","¡Mensaje!");
	            }
	            catch (Exception ex)
	            {
	            	MessageBox.Show("Error al copiar los Archivos");
	            }
	        }
		}

		void btnIngresos_Click(object sender, EventArgs e)
		{
			AbrirFormhijos<ConsultaIngresos>();
		}

		void btnProductosPrestado_Click(object sender, EventArgs e)
		{
			AbrirFormhijos<CosultaPrestamoCliente>();
		}

		

		void btnGestionPrestamos_Click(object sender, EventArgs e)
		{
			AbrirFormhijos<FormPrestamos>();
		}

		void btnGestionClientes_Click(object sender, EventArgs e)
		{
			AbrirFormhijos<FormClientes>();
		}

		void Fecha_Tick(object sender, EventArgs e)
		{
			label1.Text= DateTime.Now.ToLongDateString();
			label2.Text= DateTime.Now.ToLongTimeString();
		}

		void btnGestionDvD_Click(object sender, EventArgs e)
		{
			
			AbrirFormhijos<FormDvD>();
		}
		void btnmenu_Click(object sender, EventArgs e)
		{
			if(panelMenu.Width==190)
			{
				for(int i=190;i>=50;i=i-10)
				{
					panelMenu.Width=i;
				}
			
			}
			else
			{
				for(int i=50;i<=190;i=i+10)
				{
					panelMenu.Width=i;
				}
			}
		}
		
		//para poder mover el formulario
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
		
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        void pneltitulo_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		
        
        
        
        //esta variables sirven para tomar los valores de localizacion y tamño
		// antes de agrandar el formulario para enviarlos devuelta al momento de minimizarlos
		int LocalizacionX,LocalizacionY;
		int Ancho,altura;
		
		void btnmaximizar_Click(object sender, EventArgs e)
		{
			//aqui es para que al momento de agrandar envie su tamaño y localizacion para volver a minimizarlo
			LocalizacionX=this.Location.X;
			LocalizacionY=this.Location.Y;
			Ancho=this.Size.Width;
			altura=this.Height;
			
			//Aqui agrandamos el formulario 	
			btnmaximizar.Visible=false;
			this.Size= Screen.PrimaryScreen.WorkingArea.Size;
			this.Location=Screen.PrimaryScreen.WorkingArea.Location;
			btnminimizar.Visible=true;
		}
		void btnminimizar_Click(object sender, EventArgs e)
		{
			btnmaximizar.Visible=true;
			this.Size= new Size(Ancho,altura);
			this.Location= new Point(LocalizacionX,LocalizacionY);
	
			btnminimizar.Visible=false;
		}

		
		
		void btnocultar_Click(object sender, EventArgs e)
		{
			this.WindowState= FormWindowState.Minimized;
		}

		

		void btnsalir_Click(object sender, EventArgs e)
		{
			DialogResult Salir = MessageBox.Show("Esta seguro que quiere salir del programa","!Alerta¡",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
			if(Salir== DialogResult.Yes)this.Dispose();

		}
		// esta funcion lo que hace es redimensioar el formulario hijo en el panel contenedor de este formulario
		//ademas soluciona el problema que tenia que hacia que se crearan muchas instacias del mismo formulario
		//esto hace que se abrar una sola instancia y listo
		private void AbrirFormhijos<MiForm>()where MiForm:Form,new()
		{
			Form FormularioHijo;
			FormularioHijo=PanelFormularios.Controls.OfType<MiForm>().FirstOrDefault();// atra vez de esta linea buscamos si existe ya un formulario existente
			if(FormularioHijo==null)
			{
				FormularioHijo= new MiForm();
				FormularioHijo.TopLevel=false;
				FormularioHijo.FormBorderStyle=FormBorderStyle.None;
				FormularioHijo.Dock=DockStyle.Fill;
				PanelFormularios.Controls.Add(FormularioHijo);
				PanelFormularios.Tag= FormularioHijo;
				FormularioHijo.Show();
				FormularioHijo.BringToFront();
			}
			else 
				FormularioHijo.BringToFront();
		}
		
		
		
		
		
			
		
	}
}
