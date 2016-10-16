using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiPi.Models.Pages
{
    [ContentType(DisplayName = "BasePage", GUID = "922d6900-a9dd-44f6-9277-e02cb64089e2", Description = "")]
    public class BasePage : PageData
    {
        [Display(
               Name = "Header",
               Description = "Enter a header for the block",
               GroupName = SystemTabNames.Content,
               Order = 1)]
        [Required]
        public virtual string Heading { get; set; }

        [Display(
            Name = "Description",
            Description = "Enter a Description for the block",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [Required]
        public virtual XhtmlString MainBody { get; set; }

    }
}