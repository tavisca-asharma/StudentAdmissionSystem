using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.StudentAdmissionSystem.Service.DataContract.Model
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public Course Course { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string FatherName { get; set; }
        public string FatherOccupation { get; set; }
        public string MotherName { get; set; }
        public string MotherOccupation { get; set; }
        public string CasteAndCategory { get; set; }
        public string FatherOrMotherContactNumber { get; set; }
        public int? LandlineNumber { get; set; }
        public string MedicalSpecificationsIfAny { get; set; }
        public bool DiaplomaHolder { get; set; }
        public int YearOfAdmission { get; set; }

    }
}
