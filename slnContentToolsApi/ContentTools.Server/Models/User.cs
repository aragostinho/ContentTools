using ContentTools.API.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContentTools.API.Models
{    
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
