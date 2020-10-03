using ExampleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleMVC.Controllers
{
    public class PersonController : Controller
    {
        static IList<Person> perpsListTestData = new List<Person>{
                new Person() { PersonId = 1, Name = "John"} ,
                new Person() { PersonId = 2, Name = "Steve"} ,
                new Person() { PersonId = 3, Name = "Bill"} ,
                new Person() { PersonId = 4, Name = "Ram" } ,
                new Person() { PersonId = 5, Name = "Ron" } ,
                new Person() { PersonId = 4, Name = "Chris" } ,
                new Person() { PersonId = 4, Name = "Rob" }
            };

        // GET: Person
        public ActionResult Index()
        {            
            return View(perpsListTestData);
        }

        public ActionResult List()
        {
            return View(perpsListTestData);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            var perp = perpsListTestData.Where(s => s.PersonId == id).FirstOrDefault();

            return View(perp);
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var perp = perpsListTestData.Where(s => s.PersonId == id).FirstOrDefault();
                perpsListTestData.Remove(perp);
                perpsListTestData.Add(perp);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
