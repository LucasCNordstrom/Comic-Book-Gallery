using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers {
    public class ComicBooksController : Controller {
        public ActionResult Detail() {

            ViewBag.SeriesTitle = "The Amazing Spiderman";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "Spiderman does something cool";
            ViewBag.Artists = new string[]
                {
                    "Yeers",
                    "Yoors",
                    "Meemers",
                        };

            return View();
        }
    }
}