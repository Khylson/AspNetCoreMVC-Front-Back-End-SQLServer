using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMVC_Front_Back_End_SQLServer.Models;


namespace AspNetCoreMVC_Front_Back_End_SQLServer.Controllers
{
    public class AlunoController : Controller
    {
        private readonly DataContext db;
        public AlunoController(DataContext dataContext)
        {
            db = dataContext;
        }

        // lista os dados 
        public IActionResult List()
        {
            var lista = db.Alunos.ToList();
            return View(lista);
        }
        [HttpGet] // carregar a pagina 
        public IActionResult Create()
        {
            var aluno = new Aluno();
            return View(aluno);
        }
        [HttpPost] // enviar no banco de dado 
        public IActionResult Create( Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                db.Alunos.Add(aluno);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(aluno);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var edit = db.Alunos.Find(Id);
            if (edit != null)
            {
            }
            return View(edit);
        }
        [HttpPost]
        public IActionResult Edit(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                db.Alunos.Update(aluno);
                db.SaveChanges();
                return RedirectToAction("List"); // Apois a edição vai redirecionar na view da lista 
            }
            else
            {
                return View(aluno);
            }
        }
        [HttpGet] // carregar a pagina 
        public IActionResult Delete(int Id)
        {
            var delete = db.Alunos.Find(Id);
            return View(delete);
        }
        [HttpPost]
        public IActionResult Delete(Aluno aluno)
        {
            var delete = db.Alunos.Find(keyValues: aluno.Id_aluno);
            if (delete !=null)
            {
                db.Alunos.Remove(delete);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(aluno);
        }
        [HttpGet] // carregar a pagina 
        public IActionResult Details(int Id)
        {
            var details = db.Alunos.Find(Id);
            return View(details);
        }
    }
   
}