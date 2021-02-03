using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace coreapp.Models
{
    public class User
    {
        public int Id { get; set; }
        //[DisplayName("First Name")]
        //[StringLength(50)]
        //[Required(ErrorMessage = "First Name is required.")]
        public string Fname { get; set; }
        //[DisplayName("Last Name")]
        //[StringLength(50)]
        //[Required(ErrorMessage = "Last Name is required.")]
        public string Lname { get; set; }

        //[DisplayName("Primary Telephone")]
        //[StringLength(12)]
        //[Required(ErrorMessage = "Primary Telephone is required.")]
        public int? PriTelNo { get; set; }
        //[DisplayName("Secondary Telephone")]
        //[StringLength(12)]
        public int? SecTelNo { get; set; }

        //[DisplayName("Email Address")]
        //[Required(ErrorMessage = "Email Address is required.")]
        //[StringLength(50)]
        public string Email { get; set; }

        //[DisplayName("User Type")]
        //[Required(ErrorMessage = "User Type is required.")]
        //[StringLength(1)]
        public int? UserTypeId { get; set; }

        public virtual UserType UserType { get; set; }
        public virtual AddressDet AddressDet { get; set; }
    }

    public partial class UserType
    {
        public UserType()
        {
            UserDet = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ScreenId { get; set; }
        public virtual ICollection<User> UserDet { get; set; }
    }

    public partial class AddressDet
    {
        public int Id { get; set; }
        public int? UserDetId { get; set; }

        //[DisplayName("Leasing Office ")]
        //[StringLength(50)]
        //[Required(ErrorMessage = "Leasing Office is Required")]
        public string LeasingOfficeName { get; set; }

        //[DisplayName("Building No")]
        //[StringLength(50)]
        //[Required(ErrorMessage = "Building No is Required")]
        public string BldgNo { get; set; }

        //[DisplayName("Street Address")]
        //[StringLength(50)]
        //[Required(ErrorMessage = "Street Address is Required")]
        public string StreetAddress { get; set; }

        //[DisplayName("City")]
        //[StringLength(50)]
        //[Required(ErrorMessage = "City is Required")]
        public int? CityId { get; set; }

        public virtual CityDet City { get; set; }
        public virtual User UserDet { get; set; }
    }

    public partial class CityDet
    {
        public CityDet()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public int? SiteId { get; set; }
    }
}
