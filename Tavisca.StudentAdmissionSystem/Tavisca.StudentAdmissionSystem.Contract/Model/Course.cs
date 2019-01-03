using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.StudentAdmissionSystem.Contract.Model
{
    public class Course
    {
      //  public List<Lecturer> AllLecturersOfTheCourse { get; set; }
        public int NumberOfSeatsAvailable { get; set; }
        public string CourseId { get; set; }
        public string Name { get; set; }
        public long AdmissionFees { get; set; }
        public Lecturer HeadOfDepartment { get; set; }
        public string DepartmentId { get; set; }
    }
}
