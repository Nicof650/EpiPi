using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiPi.Models.Pages
{
    [ContentType(DisplayName = "RPiPage", GUID = "f52267ed-ca6e-40da-8e17-df7734dcb5c8", Description = "")]
    public class RPiPage : PageData
    {
        public virtual string Heading { get; set; }
        public virtual XhtmlString MainBody { get; set; }
    }
}