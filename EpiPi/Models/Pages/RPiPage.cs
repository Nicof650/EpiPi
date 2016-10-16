using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer;

namespace EpiPi.Models.Pages
{
    [ContentType(DisplayName = "RPiPage", GUID = "f52267ed-ca6e-40da-8e17-df7734dcb5c8", Description = "")]
    public class RPiPage : BasePage
    {
        [Display(
           Name = "Image",
           Description = "Chose a image for the block",
           GroupName = SystemTabNames.Content,
           Order = 3)]
        [Required]
        public virtual Url Image { get; set; }
    }
}