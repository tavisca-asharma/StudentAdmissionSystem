using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.StudentAdmissionSystem.Contract.Model
{
    public class Lecturer
    {
        public string LecturerId { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public Course Course { get; set; }
        public string MaritalStatus { get; set; }
        public string EmergencyContactPerson { get; set; }
        public string RelationWithEmergencyContactPerson { get; set; }
        public string EmergencyContactNumber { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Name { get; set; } 
        public string StaffId { get; set; }
        public string ContactNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
