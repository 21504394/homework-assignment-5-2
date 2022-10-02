using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using homework_assignment_5_2.Models;

namespace homework_assignment_5_2.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        
        public ActionResult Search(string searchText, int type, int author)
        {

            SqlCommand search;
            try
            {

                object x = null;
                Service books = new Service();

                List<books> book = books.GetAvailableBooks().Where(x => searchText != " " ? x.name.ToLower().Contains(searchText.ToLower()) : true) && (type == 0 || x.typeID == type);
                //if status in a linque query to retrieve the status of the book 
               

            }
            catch(Exception ex)
            {

            }
            return View(book);
        }
    }
}