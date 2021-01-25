using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia6.Models;
using Cwiczenia6.Services;

namespace Cwiczenia6.Controllers
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
