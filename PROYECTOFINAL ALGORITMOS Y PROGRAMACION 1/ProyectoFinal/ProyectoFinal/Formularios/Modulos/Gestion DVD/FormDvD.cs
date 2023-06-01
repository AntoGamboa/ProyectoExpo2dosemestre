/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 06/05/2023
 * Hora: 07:00 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoFinal.Clases.Inventario;
using System.Collections.Generic;
using ProyectoFinal.Formularios.Modulos.Gestion_DVD.CRUDDVD;
namespace ProyectoFinal.Formularios.Modulos.Gestion_DVD
{

	public partial class FormDvD : Form
	{
		List<string> TiposMedio;
		public FormDvD()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			btnAgregarProducto.Click += new EventHandler(btnAgregarProducto_Click);
			btnActualizarProducto.Click+= new EventHandler(btnActualizarProducto_Click);
			btnDetallesProducto.Click += new EventHandler(btnDetallesProducto_Click);
			btnDesactivarProducto.Click += new EventHandler(btnDesactivarProducto_Click);
			BuscarCodigo.KeyPress+=new KeyPressEventHandler(BuscarCodigo_KeyPress);
			BuscarNombre.KeyPress += new KeyPressEventHandler(BuscarNombre_KeyPress);
			btnRefrescar.Click += new EventHandler( BtnRefrescarClick);
			
			BuscarTipo.SelectedValueChanged += new EventHandler(BuscarTipo_SelectedValueChanged);
			
			TiposMedio= new List<string>();
			TiposMedio.Add("PISTA DE AUDIO MP3");
			TiposMedio.Add("PELICULA EN DVD");
			TiposMedio.Add("VIDEO JUEGO");
			foreach(string X in TiposMedio)
			{
				BuscarTipo.Items.Add(X);
			}
			
			cargarregistros();
		}

		
		void btnDesactivarProducto_Click(object sender, EventArgs e)
		{
			if(dataGridView1.CurrentRow != null)
			{
				string datotomado= dataGridView1.CurrentRow.Cells[0].Value.ToString();

				using(ColeccionDVD MostrarProducto= new ColeccionDVD())
				{
					DVD Deshabilitado= new DVD();
					MostrarProducto.CargarDvD();
					foreach(DVD x in MostrarProducto.Lista)
					{
						if(x.Codigo==datotomado)
						{
							if(x.Activo==true)
							{
								x.Activo=false;
								Deshabilitado=x;
								break;
							}
							else
							{
								x.Activo=true;
								Deshabilitado=x;
								break;
							}
						}
					}
					MostrarProducto.Actualizar(Deshabilitado,datotomado);
				}
				dataGridView1.Rows.Clear();
				cargarregistros();
			}
			
		}

		void btnDetallesProducto_Click(object sender, EventArgs e)
		{
			if(dataGridView1.CurrentRow != null)
			{
				string datotomado= dataGridView1.CurrentRow.Cells[0].Value.ToString();
				formVerDetalles Formulario = new formVerDetalles();
				using(ColeccionDVD MostrarProducto= new ColeccionDVD())
				{
					MostrarProducto.CargarDvD();
					foreach(DVD x in MostrarProducto.Lista)
					{
						if(x.Codigo==datotomado)
						{
							Formulario.label1.Text= x .Titulo.ToUpper();
							Formulario.pictureBox1.Image=Image.FromFile(x.Imagen);
							Formulario.label2.Text= "Año de emision: " + x.Añoemision.ToShortDateString();
							Formulario.label3.Text="Tipo de medio: " + x.TipoDVD();
							Formulario.txbDescripcion.Textos=x.Descripcion;
						}
					
					}
				
				
				}
				Formulario.ShowDialog();
				Formulario=null;
			}
		}

		void BuscarTipo_SelectedValueChanged(object sender, EventArgs e)
		{	
			dataGridView1.Rows.Clear();
			List<DVD> Filtrados = FiltradoCodigo(BuscarTipo.SelectedIndex);
			foreach(DVD x in Filtrados){
				{
					CargarDataGrid(x);
				}
			if(BuscarTipo.Text.Trim()=="") cargarregistros();
			}
		}


		void BuscarNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar==Convert.ToChar(Keys.Enter))
			{
				if (BuscarNombre.Textos.Trim()!= "") 
				{
					dataGridView1.Rows.Clear();
					List<DVD> Filtrados = Filtrado(BuscarNombre.Textos);
					foreach(DVD x in Filtrados)
					{
						CargarDataGrid(x);
					}
				}
				else
				{
					dataGridView1.Rows.Clear();
					cargarregistros();
				
				}
					
			}
		}

		void BuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar==Convert.ToChar(Keys.Enter))
			{
				if (BuscarCodigo.Textos.Trim()!= "") 
				{
					dataGridView1.Rows.Clear();
					List<DVD> Filtrados = Filtrado(BuscarCodigo.Textos);
					foreach(DVD x in Filtrados)
					{
						CargarDataGrid(x);
					}
				}
				else
				{
					dataGridView1.Rows.Clear();
					cargarregistros();
					
				}
			}
		}

		void btnActualizarProducto_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null)
			{
				string CodigoTomado= dataGridView1.CurrentRow.Cells[0].Value.ToString();
				formActualizar Formulario = new formActualizar();
				using(ColeccionDVD CargarProducto= new ColeccionDVD())
				{
					CargarProducto.CargarDvD();
					foreach(DVD x in CargarProducto.Lista)
					{
						if(x.Codigo==CodigoTomado)
						{
							Formulario.codigo.Textos=x.Codigo;
							Formulario.titulo.Textos=x.Titulo;
							Formulario.descripcion.Textos=x.Descripcion;
							Formulario.emision.Value=x.Añoemision;
							Formulario.imagenproducto.Image=Image.FromFile(x.Imagen);
							Formulario.imagenproducto.Tag=x.Imagen.ToString();
							Formulario.cbtipomedio.SelectedIndex=x.Tipomedio;
							Formulario.existencia.Textos=x.Existencia.ToString();
							Formulario.precio.Textos=x.Precio.ToString();
							Formulario.prestado.Checked=x.Prestamo;
							Formulario.lblFechaingreso.Text="Este producto se registro el dia " + x.Fechaingreso.ToShortDateString();					
							break;
						
						}
					
					}
				

				}
				
				Formulario.ShowDialog();
				Formulario=null;
				dataGridView1.Rows.Clear();
				cargarregistros();
			}
			
		}

		void btnAgregarProducto_Click(object sender, EventArgs e)
		{
			formagregarproducto Formulario = new formagregarproducto();
			Formulario.ShowDialog();
			Formulario=null;
			dataGridView1.Rows.Clear();
			cargarregistros();

			
		}
		
		public void cargarregistros()
		{
			using(ColeccionDVD Mostrar = new ColeccionDVD())
			{
				Mostrar.CargarDvD();
				foreach(DVD x in Mostrar.Lista)
				{
					CargarDataGrid(x);

				}
			}
		}
		
		
		
		List<DVD> Filtrado(string DatoFiltrado)
		{
			using(ColeccionDVD Filtrado = new ColeccionDVD())
			{
				List<DVD> DVDfiltrados= new List<DVD>();
				Filtrado.CargarDvD();
				bool Encontrado=false;
				foreach(DVD x in Filtrado.Lista)
				{
					if(x.Codigo==DatoFiltrado||x.Titulo==DatoFiltrado)
					{
						DVDfiltrados.Add(x);
						Encontrado=true;
						break;
					}
				}
				if(Encontrado==false)MessageBox.Show("Producto no registrado");
				return DVDfiltrados;
			}
		}
		
		List<DVD> FiltradoCodigo(int DatoFiltrado)
		{
			using(ColeccionDVD Filtrado = new ColeccionDVD())
			{
				Filtrado.CargarDvD();
				List<DVD> DVDfiltrados= DVDfiltrados=Filtrado.Lista.FindAll(x=>x.Tipomedio == DatoFiltrado);
				return DVDfiltrados;
			}
		}
		
		
		void CargarDataGrid(DVD x)
		{
			int PosicionFilas=dataGridView1.Rows.Add();
			dataGridView1.Rows[PosicionFilas].Cells[0].Value=x.Codigo.ToString();
			dataGridView1.Rows[PosicionFilas].Cells[1].Value=x.Titulo;
			dataGridView1.Rows[PosicionFilas].Cells[2].Value=x.Añoemision.ToShortDateString();
			dataGridView1.Rows[PosicionFilas].Cells[3].Value=x.TipoDVD();
			dataGridView1.Rows[PosicionFilas].Cells[4].Value=x.Existencia;
			dataGridView1.Rows[PosicionFilas].Cells[5].Value=x.Precio;
			dataGridView1.Rows[PosicionFilas].Cells[6].Value=x.Fechaingreso.ToShortDateString();
			dataGridView1.Rows[PosicionFilas].Cells[7].Value=x.ToString();
			dataGridView1.Rows[PosicionFilas].Cells[8].Value=x.EstadoProduco();
		}
		
		
		
		void BtnRefrescarClick(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			cargarregistros();
			BuscarCodigo.Textos= "";
			BuscarNombre.Textos= "";
			BuscarTipo.Text= "";
		}
		
		
		
			
		
	}
}
