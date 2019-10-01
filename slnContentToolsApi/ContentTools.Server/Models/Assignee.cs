using ContentTools.API.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContentTools.API.Models
{    
    public class Assignee
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("dateCreated")]
        public DateTime DateCreated { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

    }
}
