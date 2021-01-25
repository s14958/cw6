﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wyklad6_nauka.Models;

namespace Wyklad6_nauka.Services
{
    public class MockDbService : IStudentDbService
    {
        public Student GetStudent(string index)
        {
            return new Student
            {
                IndexNumber = "s14958",
                FirstName = "John",
                LastName = "Doe",
                BirthDate = DateTime.Parse("1989.09.28")
            };
        }

        public IEnumerable<Student> GetStudents()
        {
            var studentList = new List<Student>();

            studentList.Add(new Student
            {
                IndexNumber = "s123",
                FirstName = "Jan",
                LastName = "Kowalski",
                BirthDate = DateTime.Parse("1900.11.06"),
                IdEnrollment = 12
            });

            studentList.Add(new Student
            {
                IndexNumber = "s234",
                FirstName = "Andrzej",
                LastName = "Malewski",
                BirthDate = DateTime.Parse("1990.02.12"),
                IdEnrollment = 6
            });

            return studentList;
        }
    }
}
