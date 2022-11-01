using Examen.Domain.Entities;
using Examen.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace Examen.Web.Controllers
{
    public class MaisonController : Controller
    {

        private readonly IMaisonService maisonService;
        private readonly ITypeService typeService;

        public MaisonController(IMaisonService ms, ITypeService ts)
        {
            maisonService = ms;
            typeService = ts;
        }
        // GET: MaisonController
        public ActionResult Index()
        {
            return View(maisonService.GetMany());
        }

        //Filter
        [HttpPost]
        public ActionResult Index(string filter)
        {
            var list = maisonService.GetMany();
            if (!String.IsNullOrEmpty(filter))
            {
                list = list.Where(m => m.quartiers.ToString().Equals(filter)).ToList();
            }
            return View(list);
        }

        // GET: MaisonController/Details/5
        public ActionResult Details(int id)
        {
            return View(maisonService.GetById(id));
        }

        // GET: MaisonController/Create
        public ActionResult Create()
        {
            var types = typeService.GetMany();
            ViewBag.typeId = new SelectList(types, "typeId", "type");
            return View();
        }

        // POST: MaisonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Maison m)
        {
            try
            {
                maisonService.Add(m);
                maisonService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MaisonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MaisonController/Edit/5
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

        // GET: MaisonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MaisonController/Delete/5
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
