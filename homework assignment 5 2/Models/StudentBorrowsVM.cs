using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homework_assignment_5_2.Models
{
    public class StudentBorrowsVM
    {
        //this is the relationship between the student and borrows call the controllors stduent borrows 

        public List<students> studentId { get; internal set; }
        public List<students> name { get; internal set; }
        public List<students> surname { get; internal set; }
        public List<students> birthdate { get; internal set; }
        public List<students> gender { get; internal set; }
        public List<students> Class { get; internal set; }
        public List<students> point { get; internal set; }


    }
}