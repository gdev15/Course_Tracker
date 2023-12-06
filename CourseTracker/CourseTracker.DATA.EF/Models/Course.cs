using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CourseTracker.DATA.EF.Models
{
    public partial class Course
    {
        public Course()
        {
            ScheduledClasses = new HashSet<ScheduledClass>();
        }

        [Key]
        public int CourseId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string CourseName { get; set; } = null!;
        [Unicode(false)]
        public string CourseDescription { get; set; } = null!;
        public byte CreditHours { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string? Curriculum { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Notes { get; set; }
        public bool IsActive { get; set; }

        [InverseProperty("Course")]
        public virtual ICollection<ScheduledClass> ScheduledClasses { get; set; }
    }
}
