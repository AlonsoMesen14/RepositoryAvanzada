using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvanzadaAvellanas.ViewModel.NotaViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AvanzadaAvellanas.Controllers
{
    public class NotasController : Controller
    {


        public IActionResult Historico()
        {
            HistoricoViewModel modelo = new HistoricoViewModel();
            modelo.Title = "Historial Notas";
            return View(modelo);
        }

        // GET: Notas
        public ActionResult Index()
        {
            ViewBag.Title = "Ver Notas";

            return View(new VerViewModel()
            {
                Title = "Ver Notas",
                //Notas = repoNota.ObtenerNotas()
            });

            //return View();
        }

        // GET: Notas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Notas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Notas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Notas/Edit/5C:\Users\jesma\Desktop\AvanzadaAvellanas\AvanzadaAvellanas\Migrations\
        public ActionResult Edit(int id)
        {
            EditarViewModel modelo = new EditarViewModel();
            modelo.Title = "Editar Notas";

            return View(modelo);
        }

        // POST: Notas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Notas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Notas/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}