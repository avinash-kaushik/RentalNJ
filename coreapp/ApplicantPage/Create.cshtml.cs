using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using coreproj.Models;
using Microsoft.Extensions.Caching.Memory;

namespace coreproj.Pages.ApplicantPage
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Applicant obj { get; set; }
        ApplicantActions action;
        int count;
        private IMemoryCache cache;
        public void OnGet()
        {
        }

        public CreateModel(IMemoryCache cache)
        {
            this.cache = cache;
            action = new ApplicantActions((List<Applicant>)cache.Get("dtapplicantset"));
            //count = (int)cache.Get("count");
        }

        public IActionResult OnPost()
        {
            //count++;
            //cache.Set("count", count);
            //obj.Id = count;
            if(!ModelState.IsValid)
            {
                return Page();
            }
            action.AddApplicant(obj);
            return RedirectToPage("./Details", new { Id = obj.Id });
        }
    }
}
