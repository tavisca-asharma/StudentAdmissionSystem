using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.StudentAdmissionSystem.Adapter.Model;

namespace Tavisca.StudentAdmissionSystem.Adapter
{
    public class StudentAdmissionAdapter : IStudentAdmission
    {
        private readonly IDatabase _fileSystem;
        public StudentAdmissionAdapter(IDatabase fileSystem)
        {
            this._fileSystem = fileSystem;
        }
        public string GetAStudentAdmittedInCollege(StudentAdmissionRequestResponseModel request)
        {
            return _fileSystem.SaveStudentInformation(request); 
        }
    }
}
