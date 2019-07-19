using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMVC_Front_Back_End_SQLServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC_Front_Back_End_SQLServer.Controllers
{
    public class EscolaController : Controller
    {
        private readonly DataContext db;
        public EscolaController(DataContext dataContext)
        {
            db = dataContext;
        }
        // lista os dados 
        public IActionResult List()
        {
            var lista = db.Escola.ToList();
            return View(lista);
        }
        [HttpGet] // carregar a pagina 
        public IActionResult Create()
        {
            var escola = new Escola();
            return View(escola);
        }
        [HttpPost] // enviar no banco de dado 
        public IActionResult Create(Escola escola)
        {
            if (ModelState.IsValid)
            {
                db.Escola.Add(escola);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(escola);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var edit = db.Escola.Find(Id);
            if (edit != null)
            {
            }
            return View(edit);
        }
        [HttpPost]
        public IActionResult Edit(Escola escola)
        {
            if (ModelState.IsValid)
            {
                db.Escola.Update(escola);
                db.SaveChanges();
                return RedirectToAction("List"); // Apois a edição vai redirecionar na view da lista 
            }
            else
            {
                return View(escola);
            }
        }
        [HttpGet] // carregar a pagina 
        public IActionResult Delete(int Id)
        {
            var delete = db.Escola.Find(Id);
            return View(delete);
        }
        [HttpPost]
        public IActionResult Delete(Escola escola)
        {
            var delete = db.Escola.Find(escola.Id_esc);
            if (delete !=null)
            {
                db.Escola.Remove(delete);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(escola);
        }
        [HttpGet] // carregar a pagina 
        public IActionResult Details(int Id)
        {
            var details = db.Escola.Find(Id);
            return View(details);
        }
    }
}
