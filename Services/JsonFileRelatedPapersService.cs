using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using PeterKeenan.Models;

namespace PeterKeenan.Services
{
    public class JsonFileRelatedPapersService
    {
        public JsonFileRelatedPapersService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        private IWebHostEnvironment WebHostEnvironment { get; }

        private string RelatedJsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "researchPapers.json");

        public IEnumerable<RelatedPapers> GetRelatedPapers()
        {
            using var jsonFileReader = File.OpenText(RelatedJsonFileName);
            return JsonSerializer.Deserialize<RelatedPapers[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
        }
    }
}