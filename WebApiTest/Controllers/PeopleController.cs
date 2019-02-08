using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class PeopleController : ApiController
    {

        List<People> ppl = new List<People>();

        public PeopleController()
        {
            ppl.Add(new People { FirstName = "LALA", LastName = "WAKAKA", Id = 1 });
            

        }
        

        
        [Route("api/People/GetTime")]
        [HttpPost]
        public People GetTime(People people)
        {
            //people.FirstName =  ;
            //ppl.Add(new People { FirstName = "LALA" });
            people.DateTime = DateTime.Now.ToString();
            return people;
        }

        [HttpGet]
        [Route("api/People/GetFirstName/{userId:int}/{age:int}")]
        public List<string> GetFirstName(int userId, int age)
        {
            List<string> output = new List<string>();

            foreach (var p in ppl)
            {
                //output.Add(p.FirstName);
            }

            return output;
        }

        // GET: api/People
        public List<People> Get()
        {
            //string json = JsonConvert.SerializeObject(ppl, Formatting.Indented);
            //Console.WriteLine(json);

            //People deserializedProduct = JsonConvert.DeserializeObject<People>(json);


            //JToken.Parse(ppl).ToList();
            return ppl;
            
        }

        // GET: api/People/5
        public People Get(int id)
        {
            return ppl.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        //[ProducesResponseType(404)]
        public HttpResponseMessage Post(People val)
        {
            val.FirstName = "jaja";

            if (ModelState.IsValid)
            {
                // Do something with the product (not shown).
                ppl.Add(val);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        //// DELETE: api/People/5
        //public void Delete(int id)
        //{
           
        //}
    }
}
