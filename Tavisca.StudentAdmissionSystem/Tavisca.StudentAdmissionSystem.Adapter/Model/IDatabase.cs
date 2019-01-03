using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.StudentAdmissionSystem.Contract.Model; 

namespace Tavisca.StudentAdmissionSystem.Adapter.Model
{
    public interface IDatabase
    {
        Student SaveStudentInformation(Student requestAdmission);
    }
}
