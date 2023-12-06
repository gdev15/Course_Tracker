using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CourseTracker.DATA.EF.Models
{
    public partial class ScheduledClass
    {
        public ScheduledClass()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        [Key]
        [Column("ScheduledClassID")]
        public int ScheduledClassId { get; set; }
        public int CourseId { get; set; }
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string InstructorName { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string Location { get; set; } = null!;
        [Column("SCSID")]
        public int Scsid { get; set; }

        [ForeignKey("CourseId")]
        [InverseProperty("ScheduledClasses")]
        public virtual Course Course { get; set; } = null!;
        [ForeignKey("Scsid")]
        [InverseProperty("ScheduledClasses")]
        public virtual ScheduledClassStatus Scs { get; set; } = null!;
        [InverseProperty("ScheduledClass")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
