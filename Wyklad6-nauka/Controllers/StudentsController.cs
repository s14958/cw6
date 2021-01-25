using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wyklad6_nauka.Models;
using Wyklad6_nauka.Services;

namespace Wyklad6_nauka.Controllers
{
    [ApiController]
    [Route("students")]
    public class StudentsController : Controller
    {
        private readonly IStudentDbService _dbService; 

        public StudentsController(IStudentDbService studentDbService)
        {
            _dbService = studentDbService;
        }

        [HttpGet("{index}")]
        public IActionResult GetStudent(string index)
        {
            return Ok(_dbService.GetStudent(index));
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_dbService.GetStudents());
        }
    }
}
