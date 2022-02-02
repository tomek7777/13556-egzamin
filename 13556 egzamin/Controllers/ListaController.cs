using _13556_egzamin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13556_egzamin.Controllers
{
    public class ListaController : Controller
    {
        private static IList<Lista> egzamin = new List<Lista>()
        {
            new Lista( ){Id=1, NrIndeksu=13556,Ocena=5, Przedmiot="Matematyka" },
            new Lista( ){Id=1, NrIndeksu=13557,Ocena=4, Przedmiot="WF" },
            new Lista( ){Id=1, NrIndeksu=13558,Ocena=3, Przedmiot="Biologia" },
        };
        // GET: Lista
        public ActionResult Index()
        {
            return View(egzamin);
        }

        // GET: Lista/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Lista/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lista/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Lista/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lista/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Lista/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lista/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
