using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using PeterKeenan.Models;

namespace PeterKeenan.Services
{
    public class JsonFileResearchPaperServices
    {
        public JsonFileResearchPaperServices(IWebHostEnvironment webHostEnvironment) => WebHostEnvironment = webHostEnvironment;

        private IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "researchPapers.json");

        public IEnumerable<ResearchPapers> GetResearchPapers()
        {
            using var jsonFileReader = File.OpenText(JsonFileName);
            return JsonSerializer.Deserialize<ResearchPapers[]>(jsonFileReader.ReadToEnd(), new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
    }
}