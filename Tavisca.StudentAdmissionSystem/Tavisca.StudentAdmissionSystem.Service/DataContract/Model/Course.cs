using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.StudentAdmissionSystem.Service.DataContract.Model
{
    public class Course
    {
        List<Lecturer> AllLecturersOfTheCourse { get; set; }
        public int NumberOfSeatsAvailable { get; set; }
        string CourseId { get; set; }
        string Name { get; set; }
        long AdmissionFees { get; set; }
        Lecturer HeadOfDepartment { get; set; }
        string DepartmentId { get; set; }
    }
}
