using EpiPi.Models.Blocks;
using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpiPi.Controllers
{
    public class ProjectBlockController : BlockController<ProjectBlock>
    {
        // GET: ProjectBlock
        public override ActionResult Index(ProjectBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}