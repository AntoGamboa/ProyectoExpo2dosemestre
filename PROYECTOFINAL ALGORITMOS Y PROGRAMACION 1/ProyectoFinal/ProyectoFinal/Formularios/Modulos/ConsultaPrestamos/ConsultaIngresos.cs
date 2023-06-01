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
	/// Description of ConsultaIngresos.
	/// </summary>
	public partial class ConsultaIngresos : Form
	{
		public ConsultaIngresos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			btnBuscar.Click+=new EventHandler(btnBuscar_Click);
		}

		void btnBuscar_Click(object sender, EventArgs e)
		{
			int Suma=0;
			dataGridView1.Rows.Clear();
			using(ColeccionPrestamos Mostrar= new ColeccionPrestamos())
			{
				Mostrar.CargarDatos();
				foreach(ClasePrestamos x in Mostrar.Coleccion)
				{
					if(x.Fechaentrega.ToShortDateString()==FechaBuscada.Value.ToShortDateString())
					{
						int agregarfila=dataGridView1.Rows.Add();
						dataGridView1.Rows[agregarfila].Cells[0].Value=x.Nombre+" "+x.Apellido;
						dataGridView1.Rows[agregarfila].Cells[1].Value=x.Cedula;
						dataGridView1.Rows[agregarfila].Cells[2].Value=x.Direccion;
						dataGridView1.Rows[agregarfila].Cells[3].Value=x.Fechaentrega.ToShortDateString();
						dataGridView1.Rows[agregarfila].Cells[4].Value=x.Total;
					
					}
				
				
				}
				foreach(DataGridViewRow fila in dataGridView1.Rows)
				{
					Suma+=Convert.ToInt16(fila.Cells[4].Value.ToString());
				}	
				label5.Text=Suma.ToString()+" "+"$";
			}
						
		}
		
		
		
	
	}
}
