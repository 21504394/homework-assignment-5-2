using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homework_assignment_5_2.Models
{
    public class books
    {//get set means collect and use ,store it in the variable(internal set emans only i can jus the data)
       //these should be the same as the attributes in sql
        public int pagecount { get; internal set; }
        public int point { get; internal set; }
        public int bookId { get; internal set; }
        public int authorId { get; internal set; }
        public string name { get; internal set; }
        public int typeId { get; internal set; }
    }
}//each book can have many authors in this case 