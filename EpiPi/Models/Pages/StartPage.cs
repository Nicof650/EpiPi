using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiPi.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "1892b21c-2dd4-4dcb-bbed-77bf4eaa0e4c", Description = "")]
    public class StartPage : BasePage
    {              
        [Display(
            Name = "Block",
            Description = "Add a block",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}