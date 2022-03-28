using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models {
    public class ComicBook {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssuesNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }


        public string DisplayTest {
            get {
                return SeriesTitle + " #" + IssuesNumber;
            }
        }


        // series-title-issuenumber.jpg
        public string CoverImageFileName {
            get {
                return SeriesTitle.Replace(" ", "-")
                    .ToLower() + "-" + IssuesNumber + ".jpg";
            }
        }
    }
}