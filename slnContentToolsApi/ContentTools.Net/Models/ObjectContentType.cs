using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ContentTools.Net.Models
{
    public enum ObjectContentType
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
        [Description("Newsletter")]
        newsletter
    }
}
