using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ContentTools.Net.Models
{
    public enum Status : byte
    {
        [Description("In progress")]
        InProgress = 1,
        [Description("Finished")]
        Finished = 2,
        [Description("Archived")]
        Archived = 3,
        [Description("Published")]
        Published = 4,
        [Description("Delayed")]
        Delayed = 5,
        [Description("Scheduled")]
        Scheduled = 6
    }
}
