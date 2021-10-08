using System;
using System.Collections.Generic;

#nullable disable

namespace efcore5_dbfirst_aspnetcore_demo.Models
{
    public partial class VwCourseStudent
    {
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public int? StudentId { get; set; }
        public string StudentName { get; set; }
    }
}
