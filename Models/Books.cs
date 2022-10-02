using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u04598637_HW05.Models
{
    public class Books
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public int BookPC { get; set; }
        public int BookPoint { get; set; }
        public Authors Authorid { get; set; }
        public Types Typeid { get; set; }

    }
}