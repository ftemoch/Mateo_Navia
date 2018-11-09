using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clase12.Models
{
	public class Tarifas
	{
		public int Id { get; set; }
		public String Nombre { get; set; }
		public double Costo { get; set; }
		public double Descuento { get; set; }
		public String Fecha { get; set; }
	}
}