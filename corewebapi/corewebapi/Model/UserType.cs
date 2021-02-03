using System;
using System.Collections.Generic;

namespace corewebapi.Model
{
    public partial class UserType
    {
        public UserType()
        {
            UserDet = new HashSet<UserDet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ScreenId { get; set; }

        public virtual ScreenDet Screen { get; set; }
        public virtual ICollection<UserDet> UserDet { get; set; }
    }
}
