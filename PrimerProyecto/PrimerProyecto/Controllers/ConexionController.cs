using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Npgsql;

namespace PrimerProyecto.Controllers
{
    public class ConexionController : Controller
    {
        NpgsqlConnection conexion = new NpgsqlConnection();

        // GET: Conexion
        public  void AbrirConexion()
        {
            try
            {
                conexion.ConnectionString = Core.@Properties.Settings.Default.DBCS + ";Password=pmontoya";
                conexion = new NpgsqlConnection(conexion.ConnectionString);
                conexion.Open();
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // GET: Conexion/Details/5
        public string Estado()
        {
            
            return conexion.State.ToString(); 
        }

        // GET: Conexion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Conexion/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Conexion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Conexion/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Conexion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Conexion/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
