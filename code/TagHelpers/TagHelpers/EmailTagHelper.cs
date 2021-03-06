﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetCorePrimeTime.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        private const string EmailDomain = "stirtrek.com";
        public string MailTo { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";    // Replaces <email> with <a> tag

            var address = MailTo + "@" + EmailDomain;
            output.Attributes.SetAttribute("href", "mailto:" + address);
            output.Content.SetContent(address);
        }
    }
}
