using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EpiPi.Models.Pages;

namespace EpiPi.Controllers
{
    public class AboutPageController : PageController<AboutPage>
    {
        // GET: AboutPage
        public ActionResult Index(AboutPage currentPage)
        {
            //GET : AboutPage
            return View(currentPage);
        }
    }
}