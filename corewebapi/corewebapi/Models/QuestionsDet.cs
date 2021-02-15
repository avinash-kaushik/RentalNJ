using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace corewebapi.Models
{
    [Table("Questions_Det")]
    public partial class QuestionsDet
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(500)]
        public string Desc { get; set; }
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
