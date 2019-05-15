using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTNETApi.Core.Entities
{
    [Table("projects")]
    public class Project
    {
        [Key]
        [Column("pj_id")]
        public int Id { get; set; }
        [Column("pj_name")]
        public string ProjectName { get; set; }

    }
}
