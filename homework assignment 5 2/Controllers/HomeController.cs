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

        Service dataservice = new Service();

        public  ActionResult Index()
        {
          
            List<books> books1 = dataService.GetAvailableBooks();
            //gets the list of books we created a method for in our dataservice
           

            //returns the list of books
            return View(books1);

        }



        public ActionResult View()
        {
                return View();

        }

        public ActionResult Students()
        {
            Service studentss = new Service();
            //gets the list of students created and returns the list
            List<students> students = studentss.GetAvailableStudents();
            return View(students);

        }



        public ActionResult Borrows()
        {
            Service borrows = new Service();
            // gets the list of borrowed books
            List<borrows> borrow = borrows.GetBorrowedBooks(bookId);
            // and returns the list of books borrowed
            return View(borrows);

        }


     

    }
}