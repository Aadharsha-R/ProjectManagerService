﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManager.Entities
{
    [Table("Tasktbl")]
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        public int ParentId { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }

        [StringLength(20)]
        [Required]
        public string TaskName { get; set; }

        [StringLength(20)]
        public string ParentTask { get; set; }
        public int Priority { get; set; }

        [Column(TypeName = "Date")]
        public DateTime SDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime EDate { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [Column(TypeName = "Bit")]
        public bool TaskEndFlag { get; set; }
    }
}
