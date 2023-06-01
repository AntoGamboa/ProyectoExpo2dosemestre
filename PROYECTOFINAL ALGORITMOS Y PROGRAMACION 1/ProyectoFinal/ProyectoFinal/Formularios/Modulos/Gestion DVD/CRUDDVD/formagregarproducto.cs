/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 14/05/2023
 * Hora: 07:01 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoFinal.Clases.Inventario;
using ProyectoFinal.Clases;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;

namespace ProyectoFinal.Formularios.Modulos.Gestion_DVD.CRUDDVD
{
	
	public partial class formagregarproducto : Form
	{
		ColeccionDVD ColeccionAgregar;
		List<string> TiposMedio;
		
		
		public formagregarproducto()
		{
			InitializeComponent();
			codigo.KeyPress += new KeyPressEventHandler(codigo_KeyPress);
			titulo.KeyPress += new KeyPressEventHandler(titulo_KeyPress);
			existencia.KeyPress += new KeyPressEventHandler(existencia_KeyPress);
			TiposMedio= new List<string>();
			TiposMedio.Add("PISTA DE AUDIO MP3");
			TiposMedio.Add("PELICULA EN DVD");
			TiposMedio.Add("VIDEO JUEGO");
			foreach(string X in TiposMedio)
			{
				cbtipomedio.Items.Add(X);
			}
			
			
			ColeccionAgregar= new ColeccionDVD();
			lblFechaingreso.Text="Producto resgistrado el dia " + string.Format(DateTime.Now.ToShortDateString());
			btnAgregar.Click+= new EventHandler(btnAgregar_Click);
			btnagregarimagen.Click+=new EventHandler(btnagregarimagen_Click);
		}
		void existencia_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar==Convert.ToChar(Keys.Enter)) precio.Focus();
		}

		void titulo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar==Convert.ToChar(Keys.Enter)) descripcion.Focus();
		}

		void codigo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar==Convert.ToChar(Keys.Enter)) titulo.Focus();
		}
		void btnagregarimagen_Click(object sender, EventArgs e)
		{
			string RutaImagen="";
			string NombreImagen="";
			openFileDialog1.Title="Selecciona una imagen";
			openFileDialog1.Filter="Archivos de imagen (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";
			openFileDialog1.RestoreDirectory=true;
			if(openFileDialog1.ShowDialog()== DialogResult.OK)
			{
				RutaImagen=openFileDialog1.FileName;
				NombreImagen=Path.GetFileName(RutaImagen);
				string ImageneProductos=Path.Combine(Application.StartupPath,"ImagenesProductos");
				if(!Directory.Exists("ImagenesProductos"))
					Directory.CreateDirectory(ImageneProductos);
				string NuevaRuta=Path.Combine(ImageneProductos,NombreImagen);
				File.Copy(RutaImagen,NuevaRuta,true);
				imagenproducto.Image=Image.FromFile(NuevaRuta);
				string rutaRelativa = Path.Combine("ImagenesProductos", NombreImagen);
       			imagenproducto.Tag = rutaRelativa;
			}
		}
		void btnAgregar_Click(object sender, EventArgs e)
		{
			ColeccionAgregar.CargarDvD();
			try
			{
				
				ValidarCampos();
				if (imagenproducto.Tag == null)
		        {
		            string rutaImagenPorDefecto = Path.Combine("ImagenesProductos", "sinimagen.jpg");
		            imagenproducto.Image = Image.FromFile(rutaImagenPorDefecto);
		            imagenproducto.Tag = rutaImagenPorDefecto;
		        }
				ValidarCodigoExistente(codigo.Textos);
				CrearRegistro();
				MessageBox.Show("Registro Realizado Exitosamente","¡Mensaje!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				LimpiarForm();
			}
			catch(Validaciones ex)
			{
				Validaciones.EnviarMensajes(ex.Message);
			
			}
			catch(Exception ex)
			{
			
				MessageBox.Show("introduzca un formato correcto");
			}
			ColeccionAgregar.Lista.Clear();
			
		}
		
		void ValidarCampos()
		{
			
			ValidarSolonumero(existencia.Textos.Trim());
			ValidarSolonumero(precio.Textos.Trim());
			if(codigo.Textos.Trim()=="") throw new Validaciones("11");
			else if(titulo.Textos.Trim()=="") throw new Validaciones("12");
			else if(descripcion.Textos.Trim()=="") throw new Validaciones("13");
			else if(emision.Value>DateTime.Now) throw new Validaciones("14");
			else if(cbtipomedio.Text.Trim()=="") throw new Validaciones("15");
			else if(float.Parse(existencia.Textos)<0) throw new Validaciones("16");
			else if(float.Parse(precio.Textos)<0) throw new Validaciones("17");
			ValidarSolonumero(existencia.Textos.Trim());
		}
		void ValidarSolonumero(string campo)
		{
			string PatronBusqueda="[0-9]";
			if(!Regex.IsMatch(campo.Trim(),PatronBusqueda)) {throw new Validaciones("18");}
		
		}
		void ValidarCodigoExistente(string Codigo)
		{
			if(ColeccionAgregar.Encontrar(Codigo)) throw new Validaciones("19");
		}
		void CrearRegistro()
		{
			string Codigo= codigo.Textos;
			string Titulo= titulo.Textos;
			string Descripcion= descripcion.Textos;
			DateTime AñoEmision=emision.Value;	
			int TipoMedio=cbtipomedio.SelectedIndex;
			string Imagen=imagenproducto.Tag.ToString();
			int Existencia= int.Parse(existencia.Textos);
			float Precio= float.Parse(precio.Textos);
			bool Prestado = prestado.Checked;
			DateTime FechaIngreso=DateTime.Now;
			ColeccionAgregar.AgregarDVD(new DVD(Codigo,Titulo,Descripcion,AñoEmision,TipoMedio
			                                   	,Imagen,Existencia,Precio,Prestado,FechaIngreso));
				
			
		
		}
		void LimpiarForm()
		{
			string ImagenPorDEfecto=Path.Combine(Application.StartupPath,"ImagenesProductos","sinimagen.jpg");
			codigo.Textos="";
			titulo.Textos="";
			descripcion.Textos="";
			emision.Value=DateTime.Now;
			cbtipomedio.SelectedIndex=-1;
			imagenproducto.Image= Image.FromFile(ImagenPorDEfecto);
			existencia.Textos="";
			precio.Textos="";
			prestado.Checked=false;
		
		}
	}
}
