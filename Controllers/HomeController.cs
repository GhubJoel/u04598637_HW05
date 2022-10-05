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

        public ActionResult BorrowList(int id)
        {
            StudBookVM studBorrow;

            studBorrow = new StudBookVM
            {
                BorrowList = dataService.getBorrowList(id)
            };
            return View(studBorrow);
        }

        public ActionResult StudentList()
        {
            StudBookVM stud;

            stud = new StudBookVM
            {
                StudentList = dataService.getStudents()
            };
            return View(stud);
        }
    }
}