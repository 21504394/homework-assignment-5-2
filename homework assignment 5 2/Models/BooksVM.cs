using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using homework_assignment_5_2.Models;

namespace homework_assignment_5_2.Models
{
    public class BooksVM
    {
        //each time theres a fk it may be repeated thats a list 
        //look at the number of relation ships if its many things over time then its lists 
        //check controllers get the data use the VM in the controller to return details to the view 
        public List<books> pagecount { get; internal set; }
        public List<books> bookid { get; internal set; }
        public List<books> authorid { get; internal set; }
        public List<books> name { get; internal set; }
        public List<books> typeId { get; internal set; }

    }
}