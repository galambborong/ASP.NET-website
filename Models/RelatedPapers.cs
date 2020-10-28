using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PeterKeenan.Models
{
    public class RelatedPapers
    {
        public string ArticleName { get; set; }
        public string Description { get; set; }
        public string For { get; set; }
        public int Year { get; set; }
        [JsonPropertyName("link1_url")]
        public string Url { get; set; }

        public override string ToString() => JsonSerializer.Serialize<RelatedPapers>(this);
    }
}
