using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using coreapp.Services;
using coreapp.Models;

namespace coreproj.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly IRepository<User> userRepository;
        public IEnumerable<User> users { get; set; }
        private string apiName = "User";

        public IndexModel(IRepository<User> _userRepository)
        {
            this.userRepository = _userRepository;
        }
        public void OnGet()
        {
            users = userRepository.GetAll(apiName);
        }
    }
}
