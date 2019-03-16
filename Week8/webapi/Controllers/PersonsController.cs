using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Database;
using Database.Entities;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {  
        private readonly SchoolContext _dbContext;
        public PersonsController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET api/persons
        [HttpGet]
        public ActionResult<List<Person>> Get()
        {
            return Ok(_dbContext.Persons.ToList());
        }
    }
}
