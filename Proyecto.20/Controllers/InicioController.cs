using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto._20.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        public ActionResult Index()
        {
            return View();
        }

        // GET: Inicio/Details/5
        public ActionResult Login()
        {
            return View();
        }

        // GET: Inicio/Create
        public ActionResult Productos()
        {
            return View();
        }
        public ActionResult PC()
        {
            return View();
        }
        public ActionResult Almacenamiento()
        {
            return View();
        }
        public ActionResult UPS()
        {
            return View();
        }
        public ActionResult Teclados()
        {
            return View();
        }
        public ActionResult Mouse()
        {
            return View();
        }
        public ActionResult Monitores()
        {
            return View();
        }
        public ActionResult Procesadores()
        {
            return View();
        }
        public ActionResult Cases()
        {
            return View();
        }
        public ActionResult FuentesPoder()
        {
            return View();
        }
        public ActionResult Enfriamiento()
        {
            return View();
        }
        public ActionResult TarjetasVideo()
        {
            return View();
        }
        public ActionResult TarjetasRam()
        {
            return View();
        }
        public ActionResult TarjetaMadre()
        {
            return View();
        }
        public ActionResult Ventiladores()
        {
            return View();
        }
        public ActionResult Carrito()
        {
            return View();
        }
        public ActionResult Contactenos()
        {
            return View();
        }

        // POST: Inicio/Create
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

        // GET: Inicio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Inicio/Edit/5
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

        // GET: Inicio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Inicio/Delete/5
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
