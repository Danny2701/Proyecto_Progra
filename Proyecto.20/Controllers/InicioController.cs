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
