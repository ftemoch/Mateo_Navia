using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Clase12.Models;

namespace Clase12.ViewModels
{
	public class NewPeliculaViewModel
	{
		public IEnumerable<TipoPelicula> TipoPeliculas { get; set; }
		public Movie Movie { get; set; }
	}
}