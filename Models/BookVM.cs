using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u04598637_HW05.Models
{
    public class BookVM
    {
        public int bookID { get; set; }
        public string bookName { get; set; }
        public string authorName { get; set; }
        public string booktype { get; set; }
        public int bookPC { get; set; }
        public int bookPoint { get; set; }
    }
}