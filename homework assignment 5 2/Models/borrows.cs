using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homework_assignment_5_2.Models
{
    public class borrows
    {
        public int borrowId { get; internal set; }
        public int book { get; internal set; }
        public string Student { get; internal set; }
        public string TakenOutDate { get; internal set; }
        public string broughtBackDate { get; internal set; }
    }
}