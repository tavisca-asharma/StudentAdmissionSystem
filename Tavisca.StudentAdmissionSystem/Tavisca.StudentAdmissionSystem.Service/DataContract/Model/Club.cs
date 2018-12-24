using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.StudentAdmissionSystem.Service.DataContract.Model
{
    public class Club
    {
        public string NameOfClub { get; set; }
        public StudentBasicDetails StudentIncharge { get; set; }
        public ClubMember ClubMembers { get; set; }
        public DateTime DateOfClubEstablishment { get; set; }
        public LecturerBasicDetails TeacherIncharge { get; set; }
    }
}
