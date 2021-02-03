using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using coreapp.Services;
using coreapp.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace coreproj.Pages.Users
{
    public class EditModel : PageModel
    {
        private readonly IRepository<User> userRepository;
        private readonly IRepository<CityDet> userRepositoryCity;
        private readonly IRepository<UserType> userTypeRepository;
        private string apiName = "User";

        //public <int,string> 
        [BindProperty]
        public User user { get; set; }
        public SelectList cityList { get; set; }
        public SelectList userTypeList { get; set; }
        public EditModel(IRepository<User> userRepository, IRepository<CityDet> userRepositoryCity, IRepository<UserType> userTypeRepository)
        {
            this.userRepository = userRepository;
            this.userRepositoryCity = userRepositoryCity;
            this.userTypeRepository = userTypeRepository;
        }
        public IActionResult OnGet(int id)
        {
            user = userRepository.GetUser(apiName, id);
            int cityId = Convert.ToInt32(user.AddressDet.CityId);
            int usertypeId = Convert.ToInt32(user.UserTypeId);
            cityList = new SelectList(PopulateCity(), "Id", "Name", cityId);
            userTypeList = new SelectList(PopulateUserType(), "Id", "Name", usertypeId);
            if (user == null)
            {
                return RedirectToPage("/Not Found");
            }
            else
            {
                return Page();
            }


        }

        public IActionResult OnPost(User user)
        {
            if (ModelState.IsValid)
            {
                user = userRepository.UpdateUser(apiName, user);
            }
            int cityId = Convert.ToInt32(user.AddressDet.CityId);
            int usertypeId = Convert.ToInt32(user.UserTypeId);
            cityList = new SelectList(PopulateCity(), "Id", "Name", cityId);
            userTypeList = new SelectList(PopulateUserType(), "Id", "Name", usertypeId);
            return Page();
        }

        private IEnumerable<CityDet> PopulateCity()
        {
            IEnumerable<CityDet> city;
            city = userRepositoryCity.GetAll("city");
            return city;
        }

        private IEnumerable<UserType> PopulateUserType()
        {
            IEnumerable<UserType> data;
            data = userTypeRepository.GetAll("user/type");
            return data;
        }
    }
}
