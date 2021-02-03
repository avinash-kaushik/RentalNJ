using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using coreapp.Services;
using coreapp.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace coreproj.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly IRepository<User> userRepository;
        private readonly IRepository<CityDet> userRepositoryCity;
        private readonly IRepository<UserType> userTypeRepository;
        private string apiName = "User";
        [BindProperty]
        public User user { get; set; }
        public SelectList cityList { get; set; }
        public SelectList userTypeList { get; set; }

        public CreateModel(IRepository<User> userRepository, IRepository<CityDet> userRepositoryCity, IRepository<UserType> userTypeRepository)
        {
            this.userRepository = userRepository;
            this.userRepositoryCity = userRepositoryCity;
            this.userTypeRepository = userTypeRepository;
        }
        public void OnGet()
        {
            FillDropDown();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                user = userRepository.UpdateUser(apiName, user);
            }
            FillDropDown();
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
        public void FillDropDown()
        {
            cityList = new SelectList(PopulateCity(), "Id", "Name");
            userTypeList = new SelectList(PopulateUserType(), "Id", "Name");
        }
    }

}