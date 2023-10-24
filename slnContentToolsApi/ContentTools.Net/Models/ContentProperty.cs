using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentTools.Net.Models
{
    public enum ContentProperty
    {
        [Description("publish_date")]
        PublishDate = 1,
        [Description("last_updated")]
        LastUpdated = 2,
        [Description("start_date")]
        DateCreated = 3,
        [Description("title")]
        Title = 4,
    }
}
