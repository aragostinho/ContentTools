using ContentTools.Net.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentTools.Net.Models
{
    public class Response
    {        
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("objects")]
        public IList<Object> Objects { get; set; }
    }
}
