using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace corewebapi.Models
{
    [Table("city_det")]
    public partial class CityDet
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("state")]
        [StringLength(50)]
        public string State { get; set; }
        [Column("zipcode")]
        [StringLength(10)]
        public string Zipcode { get; set; }
        [Column("site_ID")]
        public int? SiteId { get; set; }

        [ForeignKey(nameof(SiteId))]
        [InverseProperty(nameof(SiteDet.CityDet))]
        public virtual SiteDet Site { get; set; }
    }
}
