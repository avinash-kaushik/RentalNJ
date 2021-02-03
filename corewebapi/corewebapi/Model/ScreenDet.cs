using System;
using System.Collections.Generic;

namespace corewebapi.Model
{
    public partial class ScreenDet
    {
        public ScreenDet()
        {
            UserType = new HashSet<UserType>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UserType> UserType { get; set; }
    }
}
