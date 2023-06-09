using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoFinal.Clases.Inventario;
using System.Collections.Generic;
using ProyectoFinal.Clases;
namespace ProyectoFinal.Formularios.Modulos.Gestion_Prestamos
{
	
	public partial class FormAgregarP : Form
	{
		
		public FormAgregarP()
		{
			
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			button2.Enabled= true;
			using(ColeccionDVD Buscar= new ColeccionDVD())
			{
				Buscar.CargarDVD();
				foreach(DVD x in Buscar.Lista)
				{
					if(x.Codigo==textBox1.Textos.Trim())
					{
						textBox2.Text=x.Titulo;
						label5.Text=x.TipoDVD();
						label1.Text="2";
						label2.Text=DateTime.Now.ToShortDateString();
						if(x.Tipomedio==0)
						{
							label3.Text=DateTime.Now.AddDays(7.0f).ToShortDateString();
							diasprestamo.Text="7";
						}
						
						if(x.Tipomedio==1)
						{
							label3.Text=DateTime.Now.AddDays(3.0f).ToShortDateString();
							diasprestamo.Text="3";
						}
						if(x.Tipomedio==2)
						{
							label3.Text=DateTime.Now.AddDays(4.0f).ToShortDateString();
							diasprestamo.Text="4";
						}
						
						
					}
				}
			
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			try
			{
				using(ColeccionDVD Buscar= new ColeccionDVD())
				{
					Buscar.CargarDVD();
					foreach(DVD x in Buscar.Lista)
					{
						if(x.Codigo==textBox1.Textos.Trim())
						{
							textBox1.Textos.CadenaNoVacia("Codigo");
							textBox3.Textos.CadenaNoVacia("Cantidad");
							if (x.Prestamo==false) throw new ArgumentException("Este producto no puede prestarse");
							if(x.Existencia<int.Parse(textBox3.Textos))throw new ArgumentException("La cantidad vendida no puede ser mayor a la existencia!");
							if(x.Activo==false)throw new ArgumentException("No puede vender un producto inactivo");
						}	
					}
				}
				Close();
			}
			catch(ArgumentException ex)
			{
				MessageBox.Show(ex.Message);
			}	
		}	
	}
}
