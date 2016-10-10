using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiPi.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "1892b21c-2dd4-4dcb-bbed-77bf4eaa0e4c", Description = "")]
    public class StartPage : PageData
    {              
        public virtual string Heading { get; set; }
        public virtual XhtmlString MainBody { get; set; }
         
    }
}