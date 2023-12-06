using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CourseTracker.DATA.EF.Models
{
    public partial class ScheduledClassStatus
    {
        public ScheduledClassStatus()
        {
            ScheduledClasses = new HashSet<ScheduledClass>();
        }

        [Key]
        [Column("SCSID")]
        public int Scsid { get; set; }
        [Column("SCSName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Scsname { get; set; } = null!;

        [InverseProperty("Scs")]
        public virtual ICollection<ScheduledClass> ScheduledClasses { get; set; }
    }
}
