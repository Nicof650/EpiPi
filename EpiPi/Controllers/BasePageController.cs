using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Framework.DataAnnotations;
using System.Web.Mvc;
using EpiPi.Models.Pages;
using EPiServer.Web.Mvc;

namespace EpiPi.Controllers
{
    public class BasePageController : PageController<BasePage>
    {
        // GET: BasePage
        public ActionResult Index(BasePage currentPage)
        {
            return View(currentPage);
        }
    }
}