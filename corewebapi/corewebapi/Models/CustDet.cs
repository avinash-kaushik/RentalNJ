using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace corewebapi.Models
{
    [Table("Cust_Det")]
    public partial class CustDet
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("Address_ID")]
        public int AddressId { get; set; }
        [Column("fname")]
        [StringLength(50)]
        public string Fname { get; set; }
        [Column("lname")]
        [StringLength(50)]
        public string Lname { get; set; }
        [Column("pri_Tel_No")]
        [StringLength(12)]
        public string PriTelNo { get; set; }
        [Column("Sec_Tel_No")]
        [StringLength(12)]
        public string SecTelNo { get; set; }
        [Column("email")]
        [StringLength(30)]
        public string Email { get; set; }
        [Column("Alt_email")]
        [StringLength(30)]
        public string AltEmail { get; set; }
        [MaxLength(200)]
        public byte[] Passwd { get; set; }
        [Column("Is_Verified")]
        public int? IsVerified { get; set; }
        [Column("DOB", TypeName = "datetime")]
        public DateTime? Dob { get; set; }
        [Column("Acv_Ir")]
        public int? AcvIr { get; set; }
        [Column("Reg_Dt", TypeName = "datetime")]
        public DateTime? RegDt { get; set; }
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
    }
}
