using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class TestController : Controller
    {
        List<People> ppl = new List<People>();

        public TestController()
        {
            ppl.Add(new People { FirstName = "LALA", LastName = "WAKAKA" , Id = 1});
            ppl.Add(new People { FirstName = "LALA", LastName = "WAKAKA" });.
            ppl.Add(new People { FirstName = "Lmao", LastName = "Anjir" });
        }


        // GET: Test
        public ActionResult Index()
        {
            //ViewBag.Title = "EditDB";
            return View();
        }

        public ActionResult List()
        {
            //Get the student from studentList sample collection for demo purpose.
            //Get the student from the database in the real application
            //var std = ppl.Where(s => s.Id == Id).FirstOrDefault();

            return View(ppl);
        }

        public ActionResult Edit(int Id)
        {
            //Get the student from studentList sample collection for demo purpose.
            //Get the student from the database in the real application
            var std = ppl.Where(s => s.Id == Id).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(People std)
        {
            //write code to update student 

            return RedirectToAction("List");
        }
    }
}