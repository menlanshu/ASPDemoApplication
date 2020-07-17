using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "Fu", LastName = "Long", Age = 20 });
            people.Add(new PersonModel { FirstName = "Kuang", LastName = "Dali", Age = 18 });
            people.Add(new PersonModel { FirstName = "Hua", LastName = "Tingting", Age = 25 });

            return View(people);
        }
    }
}