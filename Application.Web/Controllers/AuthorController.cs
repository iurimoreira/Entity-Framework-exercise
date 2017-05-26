using Application.Web.Models;
using System.Web.Mvc;

namespace Application.Web.Controllers
{
    public class AuthorController : Controller
    {
        public ActionResult Index()
        {
            AuthorCliente AC = new AuthorCliente();
            ViewBag.listAuthors = AC.pegarTodos();

            return View();
        }
        [HttpGet]
        public ActionResult Criar()
        {
            return View("Criar");
        }
        [HttpPost]
        public ActionResult Criar(Author author)
        {
            AuthorCliente AC = new AuthorCliente();
            AC.Criar(author);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            AuthorCliente AC = new AuthorCliente();
            AC.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            AuthorCliente AC = new AuthorCliente();
            Author author = new Author();
            author = AC.encontrar(id);
            return View("Editar", author);
        }
        [HttpPost]
        public ActionResult Editar(Author author)
        {
            AuthorCliente AC = new AuthorCliente();
            AC.Editar(author);
            return RedirectToAction("Index");
        }
    }
}