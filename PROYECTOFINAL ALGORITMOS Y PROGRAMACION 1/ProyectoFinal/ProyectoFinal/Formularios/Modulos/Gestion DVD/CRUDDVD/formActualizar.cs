using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoFinal.Clases.Inventario;
using System.IO;
using System.Collections.Generic;
using ProyectoFinal.Clases;
using System.Text.RegularExpressions;
namespace ProyectoFinal.Formularios.Modulos.Gestion_DVD.CRUDDVD
{

	public partial class formActualizar : Form
	{
		List<string> TiposMedio;
		public formActualizar()
		{

			InitializeComponent();
			TiposMedio= new List<string>();
			TiposMedio.Add("PISTA DE AUDIO MP3.");
			TiposMedio.Add("PELICULA EN DVD.");
			TiposMedio.Add("VIDEOJUEGO.");
			foreach(string X in TiposMedio)
			{
				cbtipomedio.Items.Add(X);
			}
			
			btnActualizar.Click += new EventHandler(btnActualizar_Click);
			btnagregarimagen.Click += new EventHandler(btnagregarimagen_Click);
		
		}

		void btnagregarimagen_Click(object sender, EventArgs e)
		{
			
			string RutaImagen="";
			string NombreImagen="";
			openFileDialog1.Title="Selecciona una imagen.";
			openFileDialog1.Filter="Archivos de imagen (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";
			openFileDialog1.RestoreDirectory=true;
			try{
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
					imagenproducto.Tag=NuevaRuta;
	
	
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error Imagen en ejecucion Recargue el programa para poder Actualizar");
			}
		}

		void btnActualizar_Click(object sender, EventArgs e)
		{
			try{
				ValidarCampos();
				using(ColeccionDVD Actualizar= new ColeccionDVD())
				{
					Actualizar.CargarDVD();
					foreach(DVD x in Actualizar.Lista)
					{
						if(x.Codigo==codigo.Textos.Trim())
						{
							Actualizar.Actualizar(ActualizarRegistro(),codigo.Textos.Trim());
							break;
						}
					}
					MessageBox.Show("Producto Actualizado con exito");
					this.Dispose();
				}
			}
			catch(ArgumentException ex)
			{
				MessageBox.Show(ex.Message);
			
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error Formatos invalidos");
			
			}
		
			
		}
		void ValidarCampos()
		{
			codigo.Textos.CadenaNoVacia("Codigo");
			titulo.Textos.CadenaNoVacia("Titulo");
			descripcion.Textos.CadenaNoVacia("Descripcion");
			if(emision.Value>DateTime.Now) throw new ArgumentException("introduzca una fecha de emision valida");
			cbtipomedio.Text.CadenaNoVacia("Tipo de Medio");
			existencia.Textos.CadenaNoVacia("Existencia");
			precio.Textos.CadenaNoVacia("Precio");
			existencia.Textos.Trim().ValidarSolonumero("Existencia");
			precio.Textos.Trim().ValidarSolonumero("Precio");
			float.Parse(existencia.Textos).valoresMayoresAcero("Existencia");
			float.Parse(precio.Textos).valoresMayoresAcero("Precio");
		}
		DVD ActualizarRegistro()
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
			DVD Actualizado = new DVD(Codigo,Titulo,Descripcion,AñoEmision,TipoMedio,Imagen,Existencia,Precio,Prestado,FechaIngreso);
			return Actualizado;	
		}
		void LimpiarForm()
		{
			string ImagenPorDEfecto= Path.Combine(Application.StartupPath,"ImagenesProductos","sinimagen.jpg");
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
