using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Npgsql;

namespace PrimerProyecto.Controllers
{
    public class HomeController : Controller
    {
        ConexionController conexion = new ConexionController();

        public ActionResult Index()
        {
            try
            {
                conexion.AbrirConexion();

                string estado = conexion.Estado();

                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                conexion.CerrarConexion();
                Console.WriteLine(e.Message);
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}