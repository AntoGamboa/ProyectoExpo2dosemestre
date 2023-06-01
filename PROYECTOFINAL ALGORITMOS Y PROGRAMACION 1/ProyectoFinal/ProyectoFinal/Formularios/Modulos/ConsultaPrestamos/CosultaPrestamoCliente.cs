/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 21/05/2023
 * Hora: 12:53 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using ProyectoFinal.Clases.Prestamos;

namespace ProyectoFinal.Formularios.Modulos.ConsultaPrestamos
{
	/// <summary>
	/// Description of CosultaPrestamoCliente.
	/// </summary>
	public partial class CosultaPrestamoCliente : Form
	{
		public CosultaPrestamoCliente()
		{
			
			InitializeComponent();
			MostrarPrestamos();
			
		}
		
		void MostrarPrestamos()
		{
			using(ColeccionPrestamos Mostrar= new ColeccionPrestamos())
			{

				Mostrar.CargarDatos();
				foreach(ClasePrestamos x in Mostrar.Coleccion)
				{
					
					foreach(ProductoVendido h in x.Productosfact)
					{
						int Agregarfila=dataGridView1.Rows.Add();
						dataGridView1.Rows[Agregarfila].Cells[0].Value=x.Nombre+" "+x.Apellido;
						dataGridView1.Rows[Agregarfila].Cells[1].Value=h.Codigo;
						dataGridView1.Rows[Agregarfila].Cells[2].Value=h.Titulo;
						dataGridView1.Rows[Agregarfila].Cells[3].Value=h.Tipomedio;
						dataGridView1.Rows[Agregarfila].Cells[4].Value=h.Fechadevolucion.ToShortDateString();
						dataGridView1.Rows[Agregarfila].Cells[5].Value=h.Cantidad.ToString();
					}
				
				}
			
			}
		
		}
		
		void BtnBuscarNombreClick(object sender, EventArgs e)
		{
			if(FiltroNombre.Textos.Trim()!="")
			{
				using(ColeccionPrestamos Buscar= new ColeccionPrestamos())
				{
					dataGridView1.Rows.Clear();
					Buscar.CargarDatos();
					bool Encontrado=false;
					foreach(ClasePrestamos x in Buscar.Coleccion)
					{
						foreach(ProductoVendido h in x.Productosfact)
						{
							if(FiltroNombre.Textos== x.Nombre.Trim())
							{
								int agregarfila=dataGridView1.Rows.Add();
								dataGridView1.Rows[agregarfila].Cells[0].Value=x.Nombre.Trim()+" "+x.Apellido.Trim();
								dataGridView1.Rows[agregarfila].Cells[1].Value=h.Codigo;
								dataGridView1.Rows[agregarfila].Cells[2].Value=h.Titulo;
								dataGridView1.Rows[agregarfila].Cells[3].Value=h.Tipomedio;
								dataGridView1.Rows[agregarfila].Cells[4].Value=h.Fechadevolucion.ToShortDateString();
								dataGridView1.Rows[agregarfila].Cells[5].Value=h.Cantidad.ToString();
								Encontrado=true;
							}
							
						}
								
					 }
					if(Encontrado==false)MessageBox.Show("No hay Prestamos Asociados con en Cliente Buscado");
				}
			}
			else MostrarPrestamos();
					
		 }
		void Button1Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			MostrarPrestamos();
			FiltroNombre.Textos= "";
			
		}
		
		void FiltroNombreKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToChar(Keys.Enter)) BtnBuscarNombreClick(sender, e);
		}
		
		
	}
		
}
