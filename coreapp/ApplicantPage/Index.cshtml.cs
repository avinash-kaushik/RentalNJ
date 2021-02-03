using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using coreproj.Models;
using Microsoft.Extensions.Caching.Memory;

namespace coreproj.Pages.ApplicantPage
{
    public class IndexModel : PageModel
    {
        private IMemoryCache cache;
        private readonly ILogger<IndexModel> _logger;
        ApplicantActions action;

        public IEnumerable<Applicant> applicantobj;
        [BindProperty]
        public Applicant employee { get; set; }
        public IndexModel(ILogger<IndexModel> logger, IMemoryCache cache)
        {
            this.cache = cache;
            _logger = logger;
            action = new ApplicantActions((List<Applicant>)cache.Get("dtapplicantset"));
        }

        public void OnGet()
        {
            applicantobj = action.GetAllApplicant();
        }
    }
}
