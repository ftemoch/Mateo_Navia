using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParcialFinal.Models
{
	public class Libro
	{
		public int ID { get; set; }
		public String Titulo { get; set; }
		public String Autor { get; set; }
		public double Edicion { get; set; }
		public double ISBN { get; set; }

		public TipoLibro tipoLibro { get; set; }
	}
}