using EpiPi.Models.Blocks;
using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpiPi.Controllers
{
    public class JumbotronBlockController : BlockController<JumbotronBlock>
    {
        // GET: JumbotronBlock
        public override ActionResult Index(JumbotronBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}