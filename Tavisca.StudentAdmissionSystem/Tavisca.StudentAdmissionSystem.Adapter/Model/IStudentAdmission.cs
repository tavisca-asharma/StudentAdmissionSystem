using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.StudentAdmissionSystem.Adapter.Model
{
    public interface IStudentAdmission
    {
        bool GetAStudentAdmittedInCollege(StudentAdmissionRequestResponseModel request);
     
    }
}
