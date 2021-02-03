using System;
using System.Collections.Generic;

namespace corewebapi.Model
{
    public partial class UserDet
    {
        //public UserDet()
        //{
        //    AddressDet = new HashSet<AddressDet>();
        //}

        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int? PriTelNo { get; set; }
        public int? SecTelNo { get; set; }
        public string Email { get; set; }
        public int? UserTypeId { get; set; }

        public virtual UserType UserType { get; set; }
        public virtual AddressDet AddressDet { get; set; }
    }
}
