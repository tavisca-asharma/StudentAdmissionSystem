using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.StudentAdmissionSystem.Adapter.Model
{
    public interface IStudentAdmission
    {
        string AdmitAStudentInCollege(StudentAdmissionRequest request);
     
    }
}
