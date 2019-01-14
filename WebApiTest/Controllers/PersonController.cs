using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class PersonController : ApiController
    {
        private List<Person> per = new List<Person>();

        public PersonController()
        {
            per.Add(new Person { Id = 1, Name = "Fred Blogs", Email = "fred.blogs@someemail.com" });
            per.Add(new Person { Id = 2, Name = "James Smith", Email = "james.smith@someemail.com" });
            per.Add(new Person { Id = 3, Name = "Jerry Jones", Email = "jerry.jones@someemail.com" });
        }

       


        // GET: api/Person
        [HttpGet]
        public List<Person> Get()
        { 
            return per;
        }

        /*[Route("api/Person")]
        [HttpGet]
        public List<Person> GetNames()
        {
            return (per);
        }*/



        // GET: api/Person/5
        public Person Get(int id)
        {
            Person person = (from p in per where p.Id == id select p).FirstOrDefault();
            if (person == null)
            {
                return null;
            }
            else
            {
                return (person);
            }
        }

        // POST: api/Person
        [HttpPost]
        public IHttpActionResult Post([FromBody]Person person)
        {
            if (person == null)
            {
                return BadRequest();
            }
            int nextId = (from p in per select p.Id).Max() + 1;
            person.Id = nextId;
            per.Add(person);
            return CreatedAtRoute("GetPerson", new { id = nextId }, person);
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
