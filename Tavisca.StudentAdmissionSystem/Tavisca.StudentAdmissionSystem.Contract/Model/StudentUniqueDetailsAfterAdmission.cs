using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.StudentAdmissionSystem.Contract.Model
{
    public class StudentUniqueDetailsAfterAdmission : Student
    {
        public string AdmissionId { get; set; }
        public string StudentEnrollmentNumber { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string DepartmentId { get; set; }
        public string CourseId { get; set; }
        public bool HostelFacilityAvailed { get; set; }
        public int RollNumber { get; set; }

    }
}
