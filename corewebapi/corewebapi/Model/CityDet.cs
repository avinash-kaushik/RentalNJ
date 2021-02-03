using System;
using System.Collections.Generic;

namespace corewebapi.Model
{
    public partial class CityDet
    {
        public CityDet()
        {
           // AddressDet = new HashSet<AddressDet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public int? SiteId { get; set; }

        public virtual SiteDet Site { get; set; }
        //public virtual ICollection<AddressDet> AddressDet { get; set; }
    }
}
