using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace CourseTracker.DATA.EF.Models
{
    [ModelMetadataType(typeof(CourseMetadata))]
    public partial class Course { }

    [ModelMetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment { }

    [ModelMetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass { }

    [ModelMetadataType(typeof(StudentMetadata))]
    public partial class Student { }

    [ModelMetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus { }

}
