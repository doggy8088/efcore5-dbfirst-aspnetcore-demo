using System;
using System.Collections.Generic;

#nullable disable

namespace efcore5_dbfirst_aspnetcore_demo.Models
{
    public partial class VwCourseStudentCount
    {
        public int? DepartmentId { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int? StudentCount { get; set; }
    }
}
