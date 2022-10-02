using System;
using homework_assignment_5_2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;




namespace homework_assignment_5_2.Controllers
{
    public class HomeController : Controller
    {

        private readonly Service dataService = Service.GetService();
        //load data


        public  ActionResult Index()
        {
            Service books = new Service();
            List<books> books1 = books.GetAvailableBooks();


            //gets the list of books we created a method for in our dataservice
            //List<books> books = Service.GetAvailableBooks();

            //returns the list of books
            return View(books);

        }



        public ActionResult View()
        {
                return View();

        }

        public ActionResult Students()
        {
            //gets the list of students created and returns the list
            List<students> studentss = Service.GetAvalableStudents();
            return View();

        }



        public ActionResult Borrows()
        {
            // gets the list of borrowed books
            List<books> books = Service.getBorrowedBooks();
            // and returns the list of books borrowed
            return View(books);

        }


        //public ActionResult SetTypeFilter(String type)
        //{
        //    MarkRange range = services.type.FirstOrDefault(r => r.Symbol == type);
        //    if (range != null)
        //    {
        //        HomeController.minFilter = range.MinOfRange;
        //        HomeController.maxFilter = range.MaxOfRange;
        //    }
        //    else
        //    {
        //        HomeController.minFilter = 0;
        //        HomeController.maxFilter = 100;
        //    }
        //    return RedirectToAction("Index");
        //}

        //public ActionResult SetAuthorFilter(String author)
        //{
        //    HomeController.authorFilter = author;
        //    return RedirectToAction("Index");
        //}
        //use link to match ids 

    }
}