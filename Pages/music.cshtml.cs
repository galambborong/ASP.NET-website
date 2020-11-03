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

        public JsonFileRelatedPaperService RelatedPaperService;
        public IEnumerable<RelatedPapers> RelatedPapers { get; private set; }

        public JsonFileEngravingService EngravingService { get; private set; }
        public IEnumerable<EngravingWork> EngravingWork { get; private set; }

        public MusicModel(
            ILogger<MusicModel> logger, JsonFileResearchPaperServices researchService,
            JsonFileRelatedPaperService relatedPaperService,
            JsonFileEngravingService engravingService
        )
        {
            _logger = logger;
            ResearchPaperServices = researchService;
            RelatedPaperService = relatedPaperService;
            EngravingService = engravingService;
        }

        public void OnGet()
        {
            ResearchPapers = ResearchPaperServices.GetResearchPapers();
            RelatedPapers = RelatedPaperService.GetRelatedPapers();
            EngravingWork = EngravingService.GetEngravingWork();
        }
    }
}
