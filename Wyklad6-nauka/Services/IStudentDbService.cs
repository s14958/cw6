using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wyklad6_nauka.Models;

namespace Wyklad6_nauka.Services
{
    public interface IStudentDbService
    {
        public Student GetStudent(string index);

        public IEnumerable<Student> GetStudents();
    }
}
