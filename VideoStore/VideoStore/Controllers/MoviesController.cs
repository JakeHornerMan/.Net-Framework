using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoStore.Models;

namespace VideoStore.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Skrek" };
            return View(movie);
        }

        public ActionResult Edit(int id) {
            return Content("id: " + id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy) {
            if (!pageIndex.HasValue) {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy)) {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        }
    }
}