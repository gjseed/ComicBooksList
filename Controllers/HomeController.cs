using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_ComicBooksCharacters.Models;

namespace MVC_ComicBooksCharacters.Controllers
{
    public class HomeController : Controller
    {
        private ComicBookContext Ctx = null;
        public HomeController(ComicBookContext Contxt)
        {
            Ctx = Contxt;
        }
        //public HomeController()
        //{
        //    ComicBookContext cbtxt = new ComicBookContext();
        //    cbtxt.Database.EnsureCreated();
        //    ComicBook c = new ComicBook { ComicBookTitle = "The Killing Joke" };
        //    cbtxt.ComicBooks.Add(c);
        //    cbtxt.SaveChanges();
        //}
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(Ctx);
        }
    }
}
