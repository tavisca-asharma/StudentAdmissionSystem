using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.StudentAdmissionSystem.Adapter.Model;

namespace Tavisca.StudentAdmissionSystem.Contract.Model
{
    public class Admission : IStudentAdmissionSystem
    {
        private readonly IStudentAdmission _studentAdmission;
        public Admission(IStudentAdmission studentAdmission)
        {
            this._studentAdmission = studentAdmission;
        }
        public Student /*StudentUniqueDetailsAfterAdmission*/ AdmitAStudentInCollege(Student newStudentAdmissionRequest)
        {
            //apply validations
           // var requestModel = newStudentAdmissionRequest.ToModel();
            //Here we will call the adapter layer
            var responseModel = _studentAdmission.AdmitAStudentInCollege(newStudentAdmissionRequest);
            return responseModel;
        }
    }
}
