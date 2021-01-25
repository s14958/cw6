using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wyklad6_nauka.Models
{
    public class Student
    {
        public string IndexNumber { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime BirthDate { set; get; }
        public int IdEnrollment { set; get; }
    }
}
