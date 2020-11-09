using hello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hello.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie movie = new Movie() { name="detachment",id=1};
            return View(movie);
        }
        [Route("Movies/SayHi/{name}/{age:regex(\\d{2,3})}")]
        public ActionResult SayHi(string name="issam",int age = 20)
        {
            return Content("hello " + name + " so you are " + age + " years old.");
        }
    }
}