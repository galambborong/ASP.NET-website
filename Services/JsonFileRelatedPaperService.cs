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

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "relatedPapersDb.json"); } // There seems to be an issue with relatedPapers.json
        }

        public IEnumerable<RelatedPapers> GetRelatedPapers()
        {
            using(var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<RelatedPapers[]>(jsonFileReader.ReadToEnd(), new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
        }
    }
}