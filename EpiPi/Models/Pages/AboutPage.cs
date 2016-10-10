using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiPi.Models.Pages
{
    [ContentType(DisplayName = "AboutPage", GUID = "907dc4fb-8af7-42db-9f7a-a922ea36debe", Description = "")]
    public class AboutPage : PageData
    {
        public virtual string Heading { get; set; }
        public virtual XhtmlString MainBody { get; set; }

    }
}