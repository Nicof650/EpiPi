using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer;

namespace EpiPi.Models.Pages
{
    [ContentType(DisplayName = "AboutPage", GUID = "907dc4fb-8af7-42db-9f7a-a922ea36debe", Description = "")]
    public class AboutPage : BasePage
    {
        [Display(
            Name = "Button label",
            Description = "Enter a label for the button",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        [Required]
        public virtual string Button { get; set; }

        [Display(
            Name = "Url",
            Description = "Enter a Url for the button",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        [Required]
        public virtual Url Url { get; set; }

        [Display(
            Name = "Block",
            Description = "Add a block",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}