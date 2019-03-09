using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Database;
using Models;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentsController : ControllerBase
    {
        private readonly SchoolContext _dbContext;

        public StudentsController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET api/students
        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            return Ok(_dbContext.Students.Include(s => s.Person).ToList());
        }
    }
}
