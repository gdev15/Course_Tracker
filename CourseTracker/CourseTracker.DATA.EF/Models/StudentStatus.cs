using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CourseTracker.DATA.EF.Models
{
    public partial class StudentStatus
    {
        public StudentStatus()
        {
            Students = new HashSet<Student>();
        }

        [Key]
        [Column("SSID")]
        public int Ssid { get; set; }
        [Column("SSName")]
        [StringLength(30)]
        [Unicode(false)]
        public string Ssname { get; set; } = null!;
        [Column("SSDescription")]
        [StringLength(250)]
        [Unicode(false)]
        public string? Ssdescription { get; set; }

        [InverseProperty("Ss")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
