using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace corewebapi.Models
{
    [Table("Site_Det")]
    public partial class SiteDet
    {
        public SiteDet()
        {
            AddressDet = new HashSet<AddressDet>();
            CityDet = new HashSet<CityDet>();
        }

        [Key]
        [Column("Site_ID")]
        public int SiteId { get; set; }
        [StringLength(50)]
        public string Desc { get; set; }
        public byte[] Logo { get; set; }
        [StringLength(30)]
        public string State { get; set; }
        [Column("created_dt", TypeName = "datetime")]
        public DateTime? CreatedDt { get; set; }
        [Column("created_by")]
        [StringLength(10)]
        public string CreatedBy { get; set; }
        [Column("updated_dt", TypeName = "datetime")]
        public DateTime? UpdatedDt { get; set; }
        [Column("updated_by")]
        [StringLength(10)]
        public string UpdatedBy { get; set; }

        [InverseProperty("Site")]
        public virtual ICollection<AddressDet> AddressDet { get; set; }
        [InverseProperty("Site")]
        public virtual ICollection<CityDet> CityDet { get; set; }
    }
}
