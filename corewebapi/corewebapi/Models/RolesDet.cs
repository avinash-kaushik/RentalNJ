using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace corewebapi.Models
{
    [Table("roles_det")]
    public partial class RolesDet
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ROle_cd")]
        [StringLength(10)]
        public string RoleCd { get; set; }
        [Column("Role_Desc")]
        [StringLength(30)]
        public string RoleDesc { get; set; }
        [Column("Role_Act_Ir")]
        public int? RoleActIr { get; set; }
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
