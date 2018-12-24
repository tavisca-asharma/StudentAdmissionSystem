using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.StudentAdmissionSystem.Service.DataContract.Model
{
    public class ExamConduction
    {
        public int YearOfExam { get; set; }
        public string NameOfExam { get; set; }
        public string CourseNameForWhichExamIsBeingConducted { get; set; }
        public string CourseIdForWhichExamIsBeingConducted { get; set; }
        public int MaximumMarks { get; set; }
        public int MarksObtained { get; set; }
        public string Remarks { get; set; }
        public string Reevaluation { get; set; } 
    }
}
