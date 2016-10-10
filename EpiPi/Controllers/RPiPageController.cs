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
    public class RPiPageController : PageController<RPiPage>
    {
        // GET: RPiPage
        public ActionResult Index(RPiPage currentPage)
        {
            return View(currentPage);
        }
    }
}