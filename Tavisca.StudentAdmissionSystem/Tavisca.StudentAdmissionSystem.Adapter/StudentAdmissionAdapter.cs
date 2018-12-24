using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.StudentAdmissionSystem.Adapter.Model;

namespace Tavisca.StudentAdmissionSystem.Adapter
{
    public class StudentAdmissionAdapter : IStudentAdmission
    {
        public bool GetAStudentAdmittedInCollege(StudentAdmissionRequestResponseModel request)
        {
            return true;
        }
    }
}
