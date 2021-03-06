﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContentTools.Net.Models
{    
    public class Object
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("assignee")]
        public Assignee Assignee { get; set; }

        [JsonProperty("data")]
        public ObjectData ObjectData { get; set; }

        [JsonProperty("ideaTitle")]
        public string IdeaTitle { get; set; }

        [JsonProperty("dateCreated")]
        public DateTime DateCreated { get; set; }

        [JsonProperty("publishDate")]
        public DateTime PublishDate { get; set; } 

        [JsonProperty("lastUpdated")]
        public DateTime LastUpdated { get; set; } 

    }
}
