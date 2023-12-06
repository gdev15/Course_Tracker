using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CourseTracker.DATA.EF.Models
{
    public partial class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int ScheduledClassId { get; set; }
        [Column(TypeName = "date")]
        public DateTime EnrollmentDate { get; set; }

        [ForeignKey("ScheduledClassId")]
        [InverseProperty("Enrollments")]
        public virtual ScheduledClass ScheduledClass { get; set; } = null!;
        [ForeignKey("StudentId")]
        [InverseProperty("Enrollments")]
        public virtual Student Student { get; set; } = null!;
    }
}
