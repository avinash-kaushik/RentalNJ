using System;
using System.Collections.Generic;

namespace corewebapi.Model
{
    public partial class AddressDet
    {
        public int Id { get; set; }
        public int? UserDetId { get; set; }
        public string LeasingOfficeName { get; set; }
        public string BldgNo { get; set; }
        public string StreetAddress { get; set; }
        public int? CityId { get; set; }

        public virtual CityDet City { get; set; }
        public virtual UserDet UserDet { get; set; }
    }
}
