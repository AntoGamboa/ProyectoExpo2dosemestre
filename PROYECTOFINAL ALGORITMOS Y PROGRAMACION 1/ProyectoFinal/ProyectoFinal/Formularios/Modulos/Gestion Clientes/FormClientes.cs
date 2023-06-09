
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using ProyectoFinal.Formularios.Modulos.Gestion_Clientes.cudclientes;
using ProyectoFinal.Clases.RegistroClient;


namespace ProyectoFinal.Formularios.Modulos.Gestion_Clientes
{
	/// <summary>
	/// Description of FormClientes.
	/// </summary>
	public partial class FormClientes : Form
	{
		
		public FormClientes()
		{
			InitializeComponent();
			btnRegistrarCliente.Click+= new EventHandler(btnRegistrarCliente_Click);
			btnActualizarCliente.Click += new EventHandler(btnActualizarCliente_Click);
			BtnRefrescar.Click+=new EventHandler(BtnRefrescarClick);
			cargarregistros();	
		}
		void btnActualizarCliente_Click(object sender, EventArgs e)
		{
			
			if (dataGridView1.CurrentRow != null)
			{
				string Cedulatomada= dataGridView1.CurrentRow.Cells[0].Value.ToString();
				ActualizarCliente Formulario = new ActualizarCliente();
				
				using(coleccionClientes CargarClientes= new coleccionClientes())
				{
					CargarClientes.CargarClientes();
					foreach(Clientes x in CargarClientes.Listaclientes)
					{
						if(x.CI==Cedulatomada)
						{
							Formulario.cedula.Textos=x.CI;
							Formulario.nombre.Textos=x.Nombre;
							Formulario.apellido.Textos=x.Apellidos;
							Formulario.direccion.Textos=x.DireccionHabitacion;
							Formulario.correo.Textos=x.Correo;
							Formulario.nroResidencia.Textos=x.Numeroresidencia;
							Formulario.telefono.Textos= x.NumeroTLF;
							Formulario.nacimiento.Value=x.FechaDN;
							Formulario.lblFechaingreso.Text=x.Fechaingreso.ToShortDateString();
						}
					}
				}
				
				Formulario.ShowDialog();
				Formulario=null;
				dataGridView1.Rows.Clear();
				cargarregistros();
			}
		}

		void btnRegistrarCliente_Click(object sender, EventArgs e)
		{
			FormRegistrar Formulario= new FormRegistrar();
			Formulario.ShowDialog();
			Formulario=null;
			dataGridView1.Rows.Clear();
			cargarregistros();	
		}
		
		void BtnDesactivarProductoClick(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow.Cells[0] != null) 
			{
				string Capturado= dataGridView1.CurrentRow.Cells[0].Value.ToString();

				using(coleccionClientes Mostrar= new coleccionClientes())
				{
					Clientes Deshabilitado= new Clientes();
					Mostrar.CargarClientes();
					foreach(Clientes x in Mostrar.Listaclientes)
					{
						if(x.CI==Capturado)
						{
							if(x.Activo == true)
							{
								x.Activo = false;
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
					Mostrar.Actualizar(Deshabilitado,Capturado);
				}
				dataGridView1.Rows.Clear();
				cargarregistros();
				
			}
		}
		
		void BuscarCedulaKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar== Convert.ToChar(Keys.Enter)) 
			{
				if(BuscarCedula.Textos.Trim()!="")
				{
					dataGridView1.Rows.Clear();
					List<Clientes> Filtro = Filtrar();
					foreach (Clientes x in Filtro) 
					{
						CargarDataGrid(x);
						
					}
				}
				
				else{dataGridView1.Rows.Clear();cargarregistros();}
			}	
		}
		void BuscarNombreKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar== Convert.ToChar(Keys.Enter)) 
			{
				if(BuscarNombre.Textos.Trim()!="")
				{
					dataGridView1.Rows.Clear();
					List<Clientes> Filtro = Filtrar();
					
					foreach (Clientes y in Filtro) 
					{
						CargarDataGrid(y);
					}
				}
				else { dataGridView1.Rows.Clear();cargarregistros();}
			}
		}
		
		void cargarregistros()
		{
			using(coleccionClientes Mostrar = new coleccionClientes())
			{
				Mostrar.CargarClientes();
				foreach( Clientes x in Mostrar.Listaclientes)
				{
					CargarDataGrid(x);
				}
			}
		}
		void CargarDataGrid(Clientes x)
		{
			int PosicionFilas=dataGridView1.Rows.Add();
			dataGridView1.Rows[PosicionFilas].Cells[0].Value=x.CI.ToString();
			dataGridView1.Rows[PosicionFilas].Cells[1].Value=x.Nombre;
			dataGridView1.Rows[PosicionFilas].Cells[2].Value=x.Apellidos;
			dataGridView1.Rows[PosicionFilas].Cells[3].Value=x.DireccionHabitacion;
			dataGridView1.Rows[PosicionFilas].Cells[4].Value=x.Numeroresidencia;
			dataGridView1.Rows[PosicionFilas].Cells[5].Value=x.Correo;
			dataGridView1.Rows[PosicionFilas].Cells[6].Value=x.NumeroTLF;
			dataGridView1.Rows[PosicionFilas].Cells[7].Value=x.FechaDN.ToShortDateString();
			dataGridView1.Rows[PosicionFilas].Cells[8].Value=x.Fechaingreso.ToShortDateString();
			dataGridView1.Rows[PosicionFilas].Cells[9].Value=x.ToString();
		}
		private List<Clientes> Filtrar()
		{	
			using (coleccionClientes Filtrado= new coleccionClientes()) 
			{
				List<Clientes> ClientesFiltrados= new List<Clientes>();
				Filtrado.CargarClientes();
				bool Encontrado=false;
				foreach (Clientes x in Filtrado.Listaclientes) 
				{
					if (x.CI == BuscarCedula.Textos.Trim() || x.Nombre== BuscarNombre.Textos.Trim()) 
					{ClientesFiltrados.Add(x); Encontrado=true;break;}
				}
				if(Encontrado==false)MessageBox.Show("Cliente no registrado");
				return ClientesFiltrados;
				
			}		
		}
		void BtnRefrescarClick(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			cargarregistros();
			BuscarNombre.Textos= "";
			BuscarCedula.Textos= "";
		}
	}
}
