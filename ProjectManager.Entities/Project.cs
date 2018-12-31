using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManager.Entities
{
    [Table("Projecttbl")]
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [StringLength(20)]
        [Required]
        public string ProjectName { get; set; }

        public int UserId { get; set; }

        public int Priority { get; set; }

        [Column(TypeName = "Date")]
        public DateTime SDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime EDate { get; set; }
        public int TotalTasks { get; set; }
        public int CompletedTasks { get; set; }

        [Column(TypeName = "Bit")]
        public bool ProjectEndFlag { get; set; }
    }
}
