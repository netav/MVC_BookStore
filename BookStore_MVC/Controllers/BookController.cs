using BookStore_MVC.Models;
using BookStore_MVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore_MVC.Controllers
{
    public class BookController : Controller
    {
        private IBookService _bookService;

        public BookController()
        {
            _bookService = new BookService();
        }
        [HttpGet]
        
        public ActionResult Index()
        {
            List<BookViewModel> booksViewModel = _bookService.GetAll();
            return View(booksViewModel);
        }

        public ActionResult NewBook()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewBook(BookViewModel model)
        {
            _bookService.AddNewBook(model);
            return RedirectToAction("Index");
        }

    }
}