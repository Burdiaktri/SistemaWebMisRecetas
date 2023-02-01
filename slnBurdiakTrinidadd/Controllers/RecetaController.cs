using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using slnBurdiakTrinidad.Data;
using slnBurdiakTrinidad.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace slnBurdiakTrinidad.Controllers
{
    public class RecetaController : Controller
    {
        private readonly RecetasDBContext context;

        public RecetaController(RecetasDBContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var recetas = context.Recetas.ToList();
            return View(recetas);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Receta receta = new Receta();
            return View(receta);
        }

        [HttpPost]
        public ActionResult Create(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receta);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Receta receta = context.Recetas.Find(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", receta);
            }
        }

        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            Receta receta = context.Recetas.Find(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                context.Recetas.Remove(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Receta receta = context.Recetas.Find(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("edit", receta);
            }
        }


        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Entry(receta).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receta);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Receta receta = context.Recetas.Find(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", receta);
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Receta>> GetByNombreAutor(string nombre)
        {
            List<Receta> recetas = (from a in context.Recetas
                                    where a.NombreAutor == nombre
                                    select a).ToList();
            if (recetas == null)
            {
                return NotFound();
            }
            else
            {
                return View("GetByNombreAutor", recetas);
            }
        }
        [HttpGet]
        public ActionResult<IEnumerable<Receta>> GetByApellidoAutor(string apellido)
        {
            List<Receta> recetas = (from a in context.Recetas
                             where a.ApellidoAutor == apellido
                             select a).ToList();

            if (recetas == null)
            {
                return NotFound();
            }
            else
            {
                return View("GetByApellidoAutor", recetas);
            }
        }
    }
}
