using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CourseTracker.DATA.EF.Models
{
    public partial class Student
    {
        public Student()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        [Key]
        public int StudentId { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string FirstName { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string LastName { get; set; } = null!;
        [StringLength(15)]
        [Unicode(false)]
        public string? Major { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Address { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? City { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string? State { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? ZipCode { get; set; }
        [StringLength(13)]
        [Unicode(false)]
        public string? Phone { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string? PhotoUrl { get; set; }
        [Column("SSID")]
        public int Ssid { get; set; }

        [ForeignKey("Ssid")]
        [InverseProperty("Students")]
        public virtual StudentStatus Ss { get; set; } = null!;
        [InverseProperty("Student")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
