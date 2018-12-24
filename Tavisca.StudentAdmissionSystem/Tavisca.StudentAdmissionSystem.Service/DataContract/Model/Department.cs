using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.StudentAdmissionSystem.Service.DataContract.Model
{
    public class Department
    {
        public string DepartmentId { get; set; }
        public List<Course> CoursesConductedInTheDepartment { get; set; }
        public int NumberOfClasses { get; set; }
        public List<string> RoomIds { get; set; }

    }
}
