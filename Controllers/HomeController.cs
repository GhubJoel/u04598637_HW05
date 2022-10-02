using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u04598637_HW05.Models;

namespace u04598637_HW05.Controllers
{
    public class HomeController : Controller
    {
        private DataService dataService = new DataService();
        public ActionResult Index()
        {
            StudBookVM studBook;

            studBook = new StudBookVM
            {
                BooksList = dataService.getAllBooks()
            };
            return View(studBook);
        }
    }
}