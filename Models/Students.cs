using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u04598637_HW05.Models
{
    public class Students
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public DateTime StudentDOB { get; set; }
        public string StudentGender { get; set; }
        public string StudentClass { get; set; }
        public int StudentPoint { get; set; }
    }
}