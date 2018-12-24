using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.StudentAdmissionSystem.Service.DataContract.Model
{
    public interface IStudentAdmissionSystem
    {
        string AdmitAStudentInCollege(Student newStudentAdmissionRequest); 
    }
}
