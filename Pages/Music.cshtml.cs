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
        private readonly JsonFileResearchPaperServices _researchPaperServices;
        public IEnumerable<ResearchPapers> ResearchPapers { get; private set; }

        private readonly JsonFileRelatedPaperService _relatedPaperService;
        public IEnumerable<RelatedPapers> RelatedPapers { get; private set; }

        private readonly JsonFileEngravingService _engravingService;
        public IEnumerable<EngravingWork> EngravingWork { get; private set; }

        public MusicModel(
            ILogger<MusicModel> logger, 
            JsonFileResearchPaperServices researchService
        //     JsonFileRelatedPaperService relatedPaperService,
        //     JsonFileEngravingService engravingService
        )
        {
            _logger = logger;
            _researchPaperServices = researchService;
            // _relatedPaperService = relatedPaperService;
            // _engravingService = engravingService;
        }

        public void OnGet()
        {
            ResearchPapers = _researchPaperServices.GetResearchPapers();
            // RelatedPapers = _relatedPaperService.GetRelatedPapers();
            // EngravingWork = _engravingService.GetEngravingWork();
        }
    }
}
