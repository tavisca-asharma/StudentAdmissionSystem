using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.StudentAdmissionSystem.Contract.Model
{
    public class LecturerBasicDetails
    {
        public string LecturerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Course Course { get; set; }
    }
}
