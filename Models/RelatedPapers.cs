using System.Text.Json;

namespace PeterKeenan.Models
{
    public class RelatedPapers
    {
        public string ArticleName { get; set; }
        public string Description { get; set; }
        public string For { get; set; }
        public int Year { get; set; }
        public override string ToString() => JsonSerializer.Serialize<RelatedPapers>(this);
    }
}