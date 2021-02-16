using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace corewebapi.Models
{
    [Table("Address_Det")]
    public partial class AddressDet
    {
        public AddressDet()
        {
            CustDet = new HashSet<CustDet>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("Leasing_office_name")]
        [StringLength(50)]
        public string LeasingOfficeName { get; set; }
        [Column("Bldg_No")]
        [StringLength(10)]
        public string BldgNo { get; set; }
        [Column("Add_Type")]
        [StringLength(10)]
        public string AddType { get; set; }
        [Column("Street_Address_1")]
        [StringLength(100)]
        public string StreetAddress1 { get; set; }
        [Column("Street_Address_2")]
        [StringLength(100)]
        public string StreetAddress2 { get; set; }
        [Column("APT_No")]
        [StringLength(5)]
        public string AptNo { get; set; }
        [Column("city")]
        [StringLength(20)]
        public string City { get; set; }
        [StringLength(20)]
        public string State { get; set; }
        [StringLength(10)]
        public string Zipcode { get; set; }
        [Column("site_ID")]
        public int? SiteId { get; set; }
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

        [ForeignKey(nameof(SiteId))]
        [InverseProperty(nameof(SiteDet.AddressDet))]
        public virtual SiteDet Site { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<CustDet> CustDet { get; set; }
    }
}
