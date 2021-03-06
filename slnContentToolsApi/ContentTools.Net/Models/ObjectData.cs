﻿using Newtonsoft.Json;
using System;

namespace ContentTools.Net.Models
{
    [JsonObject("data")]
    public class ObjectData
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("wpPostSlug")]
        public string WpPostSlug { get; set; }
        
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("excerpt")]
        public string Summary { get; set; }

        [JsonProperty("featureImage")]
        public string FeatureImage { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("contentTypeComponent")]
        public ObjectContentType ContentType { get; set; }

        [JsonProperty("dateCreated")]
        public DateTime DateCreated { get; set; } 
    }
}
