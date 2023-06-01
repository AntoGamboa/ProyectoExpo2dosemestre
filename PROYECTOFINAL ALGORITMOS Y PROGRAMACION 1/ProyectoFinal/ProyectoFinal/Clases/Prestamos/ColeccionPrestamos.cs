using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Globalization;

namespace ProyectoFinal.Clases.Prestamos
{
	/// <summary>
	/// Description of ColeccionPrestamos.
	/// </summary>
	public class ColeccionPrestamos:IDisposable
	{
		string Ruta="FactsVenta.txt";
		char Separador='|';
		private List<ClasePrestamos> _coleccion;
		public List<ClasePrestamos> Coleccion {get { return _coleccion; }set { _coleccion = value; }}
	
		public ColeccionPrestamos()
		{
			Coleccion=new List<ClasePrestamos>();
		}
		public void RegistrarVenta(ClasePrestamos x)
		{
			using(FileStream stream = new FileStream(Ruta,FileMode.Append,FileAccess.Write))
			{
				using(StreamWriter writer = new StreamWriter(stream))
				{
					string Parte1=EscribirParte1(x);
					writer.Write(Parte1);
					string Parte2=EscribirParte2(x);
					writer.Write(Parte2);
						
				
				}
			}
		
		}
		string EscribirParte1(ClasePrestamos x)
		{
			string s=Separador.ToString().Trim();
			string cadena="A"+s+x.Cedula+s+x.Nombre+s+x.Apellido+s+x.Direccion+s+x.Total.ToString()+s+x.Fechaentrega.ToString("s")+"\n";
			return cadena;
		
		}
		string EscribirParte2(ClasePrestamos x)
		{
			string s=Separador.ToString().Trim();
			string cadena="";
			
			foreach(ProductoVendido h in x.Productosfact)
			{
				cadena+="B"+s+h.Codigo+s+h.Titulo+s+h.Tipomedio+s+h.Precio.ToString()+s+h.Cantidad.ToString()+s+h.Fechaentrega.ToString("s")+s+h.Fechadevolucion.ToString("s")+"\n";
			}
			return cadena;
		
		}
		public void CargarDatos()
		{
			if(File.Exists(Ruta))
			{
				
				using(FileStream stream= new FileStream(Ruta,FileMode.Open,FileAccess.Read))
				{
					using(StreamReader read = new StreamReader(stream))
					{
						string DatosRecuperado = read.ReadLine();
						bool Validar=false;
						ClasePrestamos guardar= new ClasePrestamos();
						while(DatosRecuperado != null)
						{
							string [] recuperacion= DatosRecuperado.Split(Separador);
							switch (recuperacion[0]) 
							{
								case "A":
									if(Validar==true)Coleccion.Add(guardar);else Validar=true;
									guardar= new ClasePrestamos();
									guardar.Cedula=recuperacion[1].ToString();
									guardar.Nombre=recuperacion[2].ToString();
									guardar.Apellido=recuperacion[3].ToString();
									guardar.Direccion=recuperacion[4].ToString();
									guardar.Total=Convert.ToUInt16(recuperacion[5]);
									guardar.Fechaentrega=Convert.ToDateTime(recuperacion[6],CultureInfo.InvariantCulture);
								break;
							
								case "B":
									ProductoVendido Guardadas= new ProductoVendido();
									Guardadas.Codigo=recuperacion[1].ToString();
									Guardadas.Titulo=recuperacion[2].ToString();
									Guardadas.Tipomedio=recuperacion[3].ToString();
									Guardadas.Precio=Convert.ToSingle(recuperacion[4]);
									Guardadas.Cantidad=Convert.ToInt16(recuperacion[5]);
									Guardadas.Fechaentrega=Convert.ToDateTime(recuperacion[6],CultureInfo.InvariantCulture);
									Guardadas.Fechadevolucion=Convert.ToDateTime(recuperacion[7],CultureInfo.InvariantCulture);
									guardar.Productosfact.Add(Guardadas);
								break;
									
							}
							DatosRecuperado=read.ReadLine();
						
						}
						if(Validar==true)Coleccion.Add(guardar);
					}
				}
			}
		}
		
		
		public void Dispose()
		{
			GC.SuppressFinalize(this);
				
		}
	}
}
