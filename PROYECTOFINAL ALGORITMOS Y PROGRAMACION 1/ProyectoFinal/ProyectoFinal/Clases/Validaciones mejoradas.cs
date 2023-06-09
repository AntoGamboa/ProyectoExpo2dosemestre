using System;
using System.Text.RegularExpressions;

namespace ProyectoFinal.Clases
{
	public static class Validaciones_mejoradas
	{
		public static void SoloLetras(this string cadena,string nombreControl)
		{
			string PatronBusqueda="[a-zA-zñÑ]{3,12}";
			if(!Regex.IsMatch(cadena,PatronBusqueda)) {throw new ArgumentException("El "+nombreControl + " solo puede contener letras");}
		}
		public static void CadenaNoVacia(this string cadena, string nombrecontrol)
		{
			if(cadena=="") {throw new ArgumentException(nombrecontrol + " No Puede Estar Vacio");}
		}
		public static void valoresMayoresAcero(this float valor,string nombrecontrol)
		{
			if(valor<0) {throw new ArgumentException(nombrecontrol + " No Puede ser un Valor negativo");}
		}
		public static void ValidarSolonumero(this string campo,string nombrecontrol)
		{
			string PatronBusqueda="[0-9]";
			if(!Regex.IsMatch(campo.Trim(),PatronBusqueda)) {throw new ArgumentException(nombrecontrol + " No Puede contener Letras");}
		}	
	}
}
