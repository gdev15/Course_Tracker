using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseTracker.DATA.EF.Models
{
    public class CourseMetadata
    {      

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

    public class EnrollmentMetadata
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
    
    public class ScheduledClassMetadata
    {
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

    public class ScheduledClassStatusMetadata
    {
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

    public class StudentMetadata
    {
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

    public class StudentStatusMetadata
    {
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
