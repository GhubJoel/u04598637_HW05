using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u04598637_HW05.Models
{
    public class BorrowsVM
    {
        public int BorrowID { get; set; }
        public Students Studentid { get; set; }
        public BooksVM Bookid { get; set; }
        public DateTime TakenDate { get; set; }
        public DateTime BroughtDate { get; set; }
    }
}