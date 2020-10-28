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
   //     private readonly JsonFileResearchPaperServices _researchPaperServices;
        public JsonFileRelatedPapersService relatedPaperService;
    //    public IEnumerable<ResearchPapers> ResearchPapers { get; private set; }
        public IEnumerable<RelatedPapers> RelatedPapers { get; private set; }

        public MusicModel(
            ILogger<MusicModel> logger, 
  //          JsonFileResearchPaperServices researchService,
            JsonFileRelatedPapersService relatedService
        )
        {
            _logger = logger;
   //         _researchPaperServices = researchService;
            relatedPaperService = relatedService;
        }

        public void OnGet()
        {
   //         ResearchPapers = _researchPaperServices.GetResearchPapers();
            RelatedPapers = relatedPaperService.GetRelatedPapers();
        }
    }
}
