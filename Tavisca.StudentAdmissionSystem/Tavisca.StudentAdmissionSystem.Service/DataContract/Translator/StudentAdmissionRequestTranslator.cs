using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.StudentAdmissionSystem.Adapter.Model;
using Tavisca.StudentAdmissionSystem.Service.DataContract.Model;

namespace Tavisca.StudentAdmissionSystem.Service.DataContract.Translator
{
    public static class StudentAdmissionRequestTranslator
    {
        public static StudentAdmissionRequest ToModel(this Student request)
        {
            return new StudentAdmissionRequest
            {
                FName = request.FirstName,
                LName = request.LastName
            };
        }
    }
}
