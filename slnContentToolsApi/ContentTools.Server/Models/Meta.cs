using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentTools.Server.Models
{    
    public class Meta
    {
        [JsonProperty("categoryId")]
        public int? CategoryId { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }
}
