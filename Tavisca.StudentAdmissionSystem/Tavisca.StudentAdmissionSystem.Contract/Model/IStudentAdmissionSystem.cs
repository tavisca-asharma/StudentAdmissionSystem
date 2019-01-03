using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.StudentAdmissionSystem.Contract.Model
{
    public interface IStudentAdmissionSystem
    {
        Student AdmitAStudentInCollege(Student newStudentAdmissionRequest); 
    }
}
