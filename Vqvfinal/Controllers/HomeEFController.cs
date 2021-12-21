using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vqvfinal.Models;

namespace Vqvfinal.Controllers
{
    public class HomeEFController : Controller
    {
        private CursoDBContext _context;
        public HomeEFController(CursoDBContext context)
        {
            _context = context;
        }

            public IActionResult Index() //pagina view onde vai apresentar as tabela
        {
            var Cursovqv = _context.curso.ToList();// curso éo nome do banco de dados
            return View(Cursovqv);
            }
        //get
             public IActionResult Create()
            {
            return View();
            }
            [HttpPost]         
            public IActionResult Create(Cursovqv curso)
            {
            _context.Add(curso);
            _context.SaveChanges();
            return RedirectToAction("Index");
            }
        //get
            public IActionResult Edit(int id)
            {
                if(id == null)
                {
                return NotFound();
                }

            var curso = _context.curso.SingleOrDefault(async => async.ID == id);
            if (curso == null)
            {
                return NotFound();
            }
            return View(curso);
            } 

        [HttpPost]
        public IActionResult Edit(int id, Cursovqv curso)
        {
            if (id != curso.ID)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                _context.Update(curso);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return View(curso);
           }

        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = _context.curso.SingleOrDefault(a => a.ID == id);
            if (curso == null)
            {
                return NotFound();
            }
            return View(curso);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirma(int id)
        {
            var curso = _context.curso.SingleOrDefault(a => a.ID == id);
            if (curso == null)
            {
                return NotFound();
            }
            _context.curso.Remove(curso);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var curso = _context.curso.SingleOrDefault(a => a.ID == id);
            if (curso == null)
            {
                return NotFound();
            }

            return View(curso);


        }




    }
}
