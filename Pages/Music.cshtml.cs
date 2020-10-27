using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PeterKeenan.Models;
using PeterKeenan.Services;

namespace PeterKeenan.Pages
{
    public class MusicModel : PageModel
    {
        private readonly ILogger<MusicModel> _logger;
        public JsonFileResearchPaperServices ResearchPaperServices;
        public IEnumerable<ResearchPapers> ResearchPapers { get; private set; }

        public MusicModel(ILogger<MusicModel> logger, JsonFileResearchPaperServices researchService)
        {
            _logger = logger;
            ResearchPaperServices = researchService;
        }

        public void OnGet()
        {
            ResearchPapers = ResearchPaperServices.GetResearchPapers();
        }
    }
}
