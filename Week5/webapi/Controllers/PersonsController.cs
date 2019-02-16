using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Database;
using Models;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {  
        // GET api/persons
        [HttpGet]
        public ActionResult<List<Person>> Get()
        {
            return getPersons();
        }

        private List<Person> getPersons() 
        {
            return InMemory.persons;
        }
    }
}
