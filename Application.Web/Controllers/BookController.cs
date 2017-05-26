using Application.Web.Models;
using Application.Web.ViewModel;
using System.Web.Mvc;

namespace Application.Web.Controllers
{
    public class BookController : Controller
    {
        // GET: Book  
        public ActionResult Index()
        {
            BookCliente BC = new BookCliente();
            ViewBag.listBooks = BC.pegarTodos();

            return View();
        }
        [HttpGet]
        public ActionResult Criar()
        {
            return View("Criar");
        }
        [HttpPost]
        public ActionResult Criar(Book book)
        {
            BookCliente BC = new BookCliente();
            BC.Criar(book);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            BookCliente BC = new BookCliente();
            BC.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            BookCliente BC = new BookCliente();
            Book book = new Book();
            book = BC.encontrar(id);
            return View("Editar", book);
        }
        [HttpPost]
        public ActionResult Editar(Book book)
        {
            BookCliente BC = new BookCliente();
            BC.Editar(book);
            return RedirectToAction("Index");
        }
    }
}