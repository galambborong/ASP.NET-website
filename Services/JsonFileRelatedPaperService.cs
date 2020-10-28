using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using PeterKeenan.Models;

namespace PeterKeenan.Services
{
    public class JsonFileRelatedPaperService
    {
        public JsonFileRelatedPaperService(IWebHostEnvironment webHostEnvironment) => WebHostEnvironment = webHostEnvironment;

        private IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "relatedPapers.json");

        public IEnumerable<RelatedPapers> GetRelatedPapers()
        {
            using var jsonFileReader = File.OpenText(JsonFileName);
            return JsonSerializer.Deserialize<RelatedPapers[]>(jsonFileReader.ReadToEnd(), new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
    }
}