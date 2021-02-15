using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace corewebapi.Model
{
    [Table("Usr_role_map")]
    public partial class UsrRoleMap
    {
        public int Id { get; set; }
        [Column("User_ID")]
        public int? UserId { get; set; }
        [Column("Role_ID")]
        public int? RoleId { get; set; }
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
