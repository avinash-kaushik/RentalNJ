using System;
using System.Collections.Generic;

namespace corewebapi.Model
{
    public partial class SiteDet
    {
        public SiteDet()
        {
            //CityDet = new HashSet<CityDet>();
        }

        public int SiteId { get; set; }
        public string Name { get; set; }
        public byte[] Logo { get; set; }

        //public virtual ICollection<CityDet> CityDet { get; set; }
    }
}
