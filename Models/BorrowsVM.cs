using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u04598637_HW05.Models
{
    public class BorrowsVM
    {
        public int borrowId { get; set; }
        public Students studentId { get; set; }
        public Books bookId { get; set; }
        public DateTime takenDate { get; set; }
        public DateTime broughtDate { get; set; }
    }
}