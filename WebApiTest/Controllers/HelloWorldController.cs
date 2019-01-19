using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            int a = 0;
            return View(a);
            
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
        

        List<People> ppl = new List<People>();

        //public HelloWorldController()
        //{
        //    ppl.Add(new People { FirstName = "LALA", LastName = "WAKAKA", Id = 1 });
        //    ppl.Add(new People { FirstName = "LALA", LastName = "WAKAKA" });
        //}

        public ActionResult Return()
        {
            return View(ppl);
        }
        public ActionResult TestCall()
        {
            return View();
        }
    }
}