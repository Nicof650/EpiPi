﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer;

namespace EpiPi.Models.Blocks
{
    [ContentType(
         GUID = "d5dbb74b-ce46-436c-8e23-457393f57139",
         DisplayName = "Jumbotron",
         Description = "Jumbotron blocktype with header, description, image and button")]
    [ImageUrl("~/Content/icons/jumbotronblocktype.jpg")]
    public class JumbotronBlock : BlockData
    {
        [Display(
            Name = "Header",
            Description = "Enter a header for the block",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [Required]
        public virtual string Header { get; set; }

        [Display(
            Name = "Description",
            Description = "Enter a Description for the block",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [Required]
        public virtual XhtmlString Description { get; set; }

        [Display(
            Name = "Image",
            Description = "Chose a image for the block",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        [Required]
        public virtual Url Image { get; set; }

        [Display(
            Name = "Button label",
            Description = "Enter a label for the button",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        [Required]
        public virtual string Button { get; set; }

        [Display(
            Name = "Url",
            Description = "Enter a Url for the button",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        [Required]
        public virtual Url Url { get; set; }
    }
}