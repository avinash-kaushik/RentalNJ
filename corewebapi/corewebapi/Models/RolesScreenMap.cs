using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace corewebapi.Models
{
    [Table("roles_Screen_map")]
    public partial class RolesScreenMap
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("Role_cd")]
        [StringLength(10)]
        public string RoleCd { get; set; }
        [Column("Screen_ID")]
        public int? ScreenId { get; set; }
        [Column("Role_Act_Ir")]
        [StringLength(1)]
        public string RoleActIr { get; set; }
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
