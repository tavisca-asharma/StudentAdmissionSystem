using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.StudentAdmissionSystem.Adapter.Model;
using Tavisca.StudentAdmissionSystem.ConsulServices.Model;
using Tavisca.StudentAdmissionSystem.Contract.Model;


namespace Tavisca.StudentAdmissionSystem.Adapter
{
    public class StudentAdmissionAdapter : IStudentAdmission
    {
        private readonly IDatabase _fileSystem;
        private readonly IConsulServices _consul;
        public StudentAdmissionAdapter(IDatabase fileSystem, IConsulServices consul)
        {
            this._fileSystem = fileSystem;
            this._consul = consul;
        }
        public Student AdmitAStudentInCollege(Student request)
        {
           // return 
             var savedData = _fileSystem.SaveStudentInformation(request);

            //Get HOD

            //Get Name from consul based on dept name 

           // var hodName = _consul.GetHODFromConsul(request.Course.CourseId);
            var hodName = _consul.GetHodName(request.Course.Name);
            savedData.Course.HeadOfDepartment.Name = hodName.ToString();

            return savedData;
        }
    }
}
