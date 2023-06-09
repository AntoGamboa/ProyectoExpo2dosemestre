/*
 * Creado por SharpDevelop.
 * Usuario: Freelight
 * Fecha: 20/05/2023
 * Hora: 04:15 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using ProyectoFinal.Clases.Inventario;
using ProyectoFinal.Clases.RegistroClient;
using ProyectoFinal.Clases.Prestamos;

namespace ProyectoFinal.Formularios.Modulos.Gestion_Prestamos
{
	/// <summary>
	/// Description of FormPrestamos.
	/// </summary>
	public partial class FormPrestamos : Form
	{
		public FormPrestamos()
		{
			
			InitializeComponent();
			BuscarDClientes.Click += new EventHandler(BuscarDClientes_Click);
			btnEliminar.Click+= new EventHandler(btnEliminar_Click);
			btnAgregarProducto.Click+=new EventHandler(btnAgregarProducto_Click);
			btnGenerarVenta.Click+= new EventHandler(btnGenerarVenta_Click);
			btnAgregarProducto.Enabled= false;
			
		}

		void btnAgregarProducto_Click(object sender, EventArgs e)
		{
			int Suma=0;
			FormAgregarP formulario2=new FormAgregarP();
			AddOwnedForm(formulario2);
			formulario2.ShowDialog();
			int Posicion=dataGridView1.Rows.Add();
			dataGridView1.Rows[Posicion].Cells[0].Value=formulario2.textBox1.Textos;
			dataGridView1.Rows[Posicion].Cells[1].Value=formulario2.textBox2.Text;
			dataGridView1.Rows[Posicion].Cells[2].Value=formulario2.label5.Text;
			dataGridView1.Rows[Posicion].Cells[3].Value=formulario2.label1.Text;
			dataGridView1.Rows[Posicion].Cells[4].Value=formulario2.label2.Text;
			dataGridView1.Rows[Posicion].Cells[5].Value=formulario2.label3.Text;
			dataGridView1.Rows[Posicion].Cells[6].Value=formulario2.textBox3.Textos;
			btnGenerarVenta.Enabled= true;		
			foreach(DataGridViewRow fila in dataGridView1.Rows)
			{
					Suma+=Convert.ToInt16(fila.Cells[3].Value.ToString());
			}
			label5.Text=Suma.ToString();
			formulario2=null;
		}
		void btnGenerarVenta_Click(object sender, EventArgs e)
		{
			GenerarRegistro();
			ActualizarExistencia();
			LimpiarFormC();
			MessageBox.Show("Venta Registrada Exitoxamente");
		}
		void btnEliminar_Click(object sender, EventArgs e)
		{
			int Suma=0;
			btnGenerarVenta.Enabled= false;
			if (dataGridView1.SelectedCells.Count > 0)
		    {

		        DataGridViewRow filaSeleccionada = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
		        dataGridView1.Rows.Remove(filaSeleccionada);
		        
		    }
			foreach(DataGridViewRow fila in dataGridView1.Rows)
			{
				Suma+=Convert.ToInt16(fila.Cells[3].Value.ToString());
			}
			label5.Text=Suma.ToString();
		}

		void BuscarDClientes_Click(object sender, EventArgs e)
		{
			using(coleccionClientes Buscar= new coleccionClientes())
			{
				Buscar.CargarClientes();
				bool encontrado=false;
				foreach(Clientes x in Buscar.Listaclientes)
				{
					if(Cedula.Textos==x.CI)
					{
						nombre.Textos=x.Nombre.ToString();
						apellido.Textos=x.Apellidos.ToString();
						direccion.Textos=x.DireccionHabitacion.ToString();
						btnAgregarProducto.Enabled= true;
						encontrado=true;
						break;	
					}
				}
				if(encontrado==false){
					MessageBox.Show("Cliente no registrado en Base de Datos");
					nombre.Textos="";
					apellido.Textos="";
					direccion.Textos="";
				}
			}
		}
		void GenerarRegistro()
		{
			string cedula=Cedula.Textos;
			string Nombre=nombre.Textos;
			string Apellido=apellido.Textos;
			string Direccion=direccion.Textos;
			float Total=float.Parse(label5.Text);
			List<ProductoVendido> Vendido=new List<ProductoVendido>();
			foreach(DataGridViewRow Filas in dataGridView1.Rows)
			{
				string codigo= Filas.Cells[0].Value.ToString();
				string titulo= Filas.Cells[1].Value.ToString();
				string tipomedio= Filas.Cells[2].Value.ToString();
				float precio= Convert.ToSingle(Filas.Cells[3].Value);
				DateTime fechadevolucion=Convert.ToDateTime( Filas.Cells[5].Value);
				int cantidad= Convert.ToInt16(Filas.Cells[6].Value);
				Vendido.Add(new ProductoVendido(codigo,titulo,tipomedio,precio,fechadevolucion,cantidad));
			}
			using(ColeccionPrestamos Escribir= new ColeccionPrestamos())
			{
				Escribir.RegistrarVenta(new ClasePrestamos(cedula,Nombre,Apellido,Direccion,Total,Vendido));
			}

		
		}
		void ActualizarExistencia()
		{
			using (ColeccionDVD actualizarExistencia = new ColeccionDVD())
		    {
		        actualizarExistencia.CargarDVD();
		        foreach (DataGridViewRow filas in dataGridView1.Rows)
		        {
		            string codigoArestar = filas.Cells[0].Value.ToString();
		            int CantidadProducto = Convert.ToInt16(filas.Cells[6].Value);
		            List<DVD> listaDVDs = actualizarExistencia.Lista.ToList();
		            foreach (DVD x in listaDVDs)
		            {
		                if (x.Codigo == codigoArestar)
		                {
		                    x.Existencia = x.Existencia - CantidadProducto;
		                    actualizarExistencia.Actualizar(x, codigoArestar);
		                }
		            }
		        }
		    }
		}
	
		
		void CedulaKeyPress(DVD sender, KeyPressEventArgs e)
		{
			if (e.KeyChar== Convert.ToChar(Keys.Enter)) BuscarDClientes_Click(sender,e);
		}
		
		void LimpiarFormC()
		{
			Cedula.Textos= "";
			nombre.Textos= "";
			apellido.Textos="";
			direccion.Textos= "";
			dataGridView1.Rows.Clear();
			btnAgregarProducto.Enabled= false;
			btnGenerarVenta.Enabled= false;
		}
	}
}
