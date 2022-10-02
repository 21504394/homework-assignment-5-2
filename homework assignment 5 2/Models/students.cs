using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homework_assignment_5_2.Models
{
    public class students
    {
        public int studentId { get; internal set; }
        public string name { get; internal set; }
        public string surname { get; internal set; }
        public DateTime birthdate { get; internal set; }
        public string gender { get; internal set; }
        public string Class { get; internal set; }
        public int point { get; internal set; }
       
    }
}