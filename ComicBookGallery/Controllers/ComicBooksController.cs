using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers {
    public class ComicBooksController : Controller {
        public ActionResult Detail() {

            var comicBook = new ComicBook() {
                SeriesTitle = "The Amazing Spiderman",
                IssueNumber = 700,
                DescriptionHtml = "<p>Spiderman does something cool</p>",
                Artists = new Artist[]
                {
                    new Artist(){ Name = "Yeers", Role = "Something" },
                    new Artist(){ Name = "Yoors", Role = "Something" },
                    new Artist() {Name = "Meemers", Role = "Something" },
                    new Artist(){ Name = "Focaccia", Role = "Something" }
                }

            };



            return View(comicBook);
        }
    }
}