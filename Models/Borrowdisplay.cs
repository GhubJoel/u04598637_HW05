using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u04598637_HW05.Models
{
    public class Borrowdisplay
    {
        public int borrowId { get; set; }
        public int bookId { get; set; }
        public string borrowBy { get; set; }
        public DateTime takenDate { get; set; }
        public DateTime broughtDate { get; set; }
    }
}