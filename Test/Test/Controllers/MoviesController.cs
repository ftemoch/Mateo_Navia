using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Controllers;

namespace Test.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var Movie = new Movie()
            {
                Nombre = "Friend request!"
            };
            return View(Movie);
        }
    }
}