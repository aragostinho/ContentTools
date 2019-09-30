using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ContentTools.API.Models.Enums
{
    public enum ContentType
    {
        [Description("blog-post")]
        blogpost,
        [Description("page")]
        page,
        [Description("social-post")]
        socialpost,
        [Description("webinar")]
        webinar,
        [Description("ebook")]
        ebook,
        [Description("newsletter")]
        newsletter
    }
}
