using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using LaudaMusicam.Models;

namespace LaudaMusicam.Controllers
{
    public class ImageGalleryController : Controller
    {
        //
        // GET: /ImageGallery/

        public ActionResult Index(string name)
        {
            ImageGallery model;
            switch (name)
            {
                case "test":
                    model = new ImageGallery { Id = 0, Title = "Test", Name = "test", Images = new[] { new Image { HighResUrl = "~/Content/PhotoStrip3.png" } } };
                    break;

                case "medieval-day-2012":
                    model = new ImageGallery {
                        Id = 0,
                        Title = "Medieval Day Celebration of 2012",
                        Name = "medieval-day-2012",
                        Description = "Quartet with Patsy Woods, Mickey Gillmor, Gisela McClellan, and Ron Foisia.",
                        Images = new[] { new Image { HighResUrl = "~/Content/PhotoStrip3.png" } }
                    };
                    break;

                case "Picketts-Mill-Elementary-School-Chorus-2012-02":
                    model = new ImageGallery {
                        Id = 0,
                        Title = "Jody Miller performs with the Pickett's Mill Elementary School Chorus",
                        Name = "Picketts-Mill-Elementary-School-Chorus-2012-02",
                        Description = "Lauda Musicam director Jody Miller performs with the Pickett's Mill Elementary School Chorus in their Large Group Performance Evaluation in February 2012.",
                        Images = new[] { new Image { HighResUrl = "~/Content/PhotoStrip3.png" } }
                    };
                    break;

                case "Christmas-Eve-2013-12-24":
                    model = new ImageGallery {
                        Id = 0,
                        Title = "Christmas Eve Service at St. Bartholomew's Episcopal Church on December 24, 2013",
                        Name = "Christmas-Eve-2013-12-24",
                        Description = "Lauda Musicam members perform at Christmas Eve Service at St. Bartholomew's Episcopal Church on December 24, 2013",
                        Images = new[] { new Image { HighResUrl = "~/Content/PhotoStrip3.png" } }
                    };
                    break;

                case "LM-conecert-2015-02-22":
                   model = new ImageGallery {
                        Id = 0,
                        Title = "Lauda Musicam: February 22, 2015 Concert",
                        Name = "LM-conecert-2015-02-22",
                        Description = "Celebrations: Early Music for Special Occasions. Lauda Musicam performs at St. Bartholomew's Episcopal Church on February 22, 2015",
                        Images = new[] { new Image { HighResUrl = "~/Content/PhotoStrip3.png" } }
                    };
                    break;

                default:
                    model = new ImageGallery { Title = "", Name = "", Images = new Image[] { } };
                    break;
            }

            return View("ImageGalleryIndex", model);
        }
    }
}
