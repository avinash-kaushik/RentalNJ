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
    public class DetailsModel : PageModel
    {
        private readonly IRepository<User> userRepository;
        private string apiName = "User";
        public User user { get; set; }
        public DetailsModel(IRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }
        public void OnGet(int id)
        {
            user = userRepository.GetUser(apiName, id);
        }
    }
}
