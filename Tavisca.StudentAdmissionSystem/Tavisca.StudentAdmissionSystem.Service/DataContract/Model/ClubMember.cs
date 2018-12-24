using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.StudentAdmissionSystem.Service.DataContract.Model
{
    public class ClubMember
    {
        public string MemberId { get; set; }
        public List<StudentBasicDetails> Students  { get; set; }
        public List<LecturerBasicDetails> Lecturers { get; set; }
    }
}
