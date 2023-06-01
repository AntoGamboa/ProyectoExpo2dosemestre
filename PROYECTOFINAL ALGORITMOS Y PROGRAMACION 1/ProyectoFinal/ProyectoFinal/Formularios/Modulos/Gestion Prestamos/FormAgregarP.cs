
using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoFinal.Clases.Inventario;
using System.Collections.Generic;
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
				Buscar.CargarDvD();
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
					Buscar.CargarDvD();
					foreach(DVD x in Buscar.Lista)
					{
						if(x.Codigo==textBox1.Textos.Trim())
						{
							if (x.Prestamo==false) throw new ArgumentException("Este producto no puede prestarse");
							if(textBox3.Textos.Trim()=="") throw new ArgumentException("La cantidad no puede estar en Blanco!");
							if(x.Existencia<int.Parse(textBox3.Textos))throw new ArgumentException("La cantidad vendida no puede ser mayor a la existencia!");
							if(x.Activo==false)throw new ArgumentException("No puede vender un producto inactivo");

						}
						else
						{
							if (textBox1.Textos== "" & textBox3.Textos== "") throw new ArgumentException("No pueden Haber campos Vacios, Por favor llenar los campos!");
							if(textBox1.Textos== "") throw new ArgumentException("Debe ingresar el codigo del producto para registrarlo!");
							
							
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
