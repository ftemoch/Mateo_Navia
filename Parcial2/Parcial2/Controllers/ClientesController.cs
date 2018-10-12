using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Parcial2.Models;

namespace Parcial2.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Cliente
        public ActionResult Random()
        {
            var Cliente = new Clientes()
            {
                Nombre = "John",
                Apellido = "Smith",
                Sueldo = 200
            };
            return View(Cliente);
        }
    }
}