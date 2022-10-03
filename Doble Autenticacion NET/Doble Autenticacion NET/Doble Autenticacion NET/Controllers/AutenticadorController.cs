using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Doble_Autenticacion_NET.Controllers
{
    public class AutenticadorController : Controller
    {
        // GET: Autenticador
        public ActionResult Index()
        {
            return View();
        }

        // GET: Autenticador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Autenticador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autenticador/Create
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

        // GET: Autenticador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Autenticador/Edit/5
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

        // GET: Autenticador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Autenticador/Delete/5
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
