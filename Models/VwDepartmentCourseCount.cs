using System;
using System.Collections.Generic;

#nullable disable

namespace efcore5_dbfirst_aspnetcore_demo.Models
{
    public partial class VwDepartmentCourseCount
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int? CourseCount { get; set; }
    }
}
