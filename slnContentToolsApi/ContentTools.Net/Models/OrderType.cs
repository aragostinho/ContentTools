using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentTools.Net.Models
{
    public enum OrderType
    {
        [Description("Ascending")]
        Ascending = 1,
        [Description("Descending")]
        Descending = 2,
    }
}
