using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ParcialFinal.Models;

namespace ParcialFinal.ViewModels
{
	public class NewLibroViewModel
	{
		public IEnumerable<TipoLibro> TipoLibros { get; set; }
		public Libro Libro { get; set; }
	}
}