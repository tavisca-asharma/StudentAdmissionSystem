//using System;
//using System.Collections.Generic;
//using System.Text;
//using Tavisca.StudentAdmissionSystem.Adapter.Model;
//using Tavisca.StudentAdmissionSystem.Service.DataContract.Model;
//using Course = Tavisca.StudentAdmissionSystem.Adapter.Model.Course;
//using Lecturer = Tavisca.StudentAdmissionSystem.Adapter.Model.Lecturer;

//namespace Tavisca.StudentAdmissionSystem.Service.DataContract.Translator
//{
//    public static class StudentAdmissionRequestTranslator
//    {
//        public static StudentAdmissionRequest ToModel(this Student request)
//        {
//            Lecturer headOfDepartment = null;
//            Lecturer allLecturer = null;
//            Course course = new Course
//            {
//                AllLecturersOfTheCourse = new List<Lecturer>() ,
//                NumberOfSeatsAvailable = request.Course.NumberOfSeatsAvailable,
//                AdmissionFees = request.Course.AdmissionFees,
//                CourseId = request.Course.CourseId,
//                DepartmentId = request.Course.DepartmentId,
//                HeadOfDepartment = headOfDepartment,
//                Name = request.Course.Name
//            }; 
//            headOfDepartment = new Lecturer {
//                Age = request.Course.HeadOfDepartment.Age,
//                ContactNumber = request.Course.HeadOfDepartment.ContactNumber,
//                Course = course,
//                DateOfBirth = request.Course.HeadOfDepartment.DateOfBirth,
//                DateOfJoining = request.Course.HeadOfDepartment.DateOfJoining,
//                EmergencyContactNumber = request.Course.HeadOfDepartment.EmergencyContactNumber,
//                EmergencyContactPerson = request.Course.HeadOfDepartment.EmergencyContactPerson,
//                FirstName = request.Course.HeadOfDepartment.FirstName,
//                Gender = request.Course.HeadOfDepartment.Gender,
//                LastName = request.Course.HeadOfDepartment.LastName,
//                LecturerId = request.Course.HeadOfDepartment.LecturerId,
//                MaritalStatus = request.Course.HeadOfDepartment.MaritalStatus,
//                RelationWithEmergencyContactPerson = request.Course.HeadOfDepartment.RelationWithEmergencyContactPerson,
//                StaffId = request.Course.HeadOfDepartment.StaffId
//            };

          
//            return new StudentAdmissionRequest
//            {
//                FName = request.FirstName,
//                LName = request.LastName,
//                Age = request.Age,
//                Course = course,
//                CasteAndCategory = request.CasteAndCategory,
//                ContactNumber = request.ContactNumber,
//                DateOfBirth = request.DateOfBirth,
//                DiaplomaHolder = request.DiaplomaHolder,
//                FatherName = request.FatherName,
//                FatherOccupation = request.FatherOccupation,
//                FatherOrMotherContactNumber = request.FatherOrMotherContactNumber,
//                Gender = request.Gender,
//                LandlineNumber = request.LandlineNumber,
//                MedicalSpecificationsIfAny = request.MedicalSpecificationsIfAny,
//                MotherName = request.MotherName,
//                MotherOccupation = request.MotherOccupation,
//                YearOfAdmission = request.YearOfAdmission
//            };
//        }
//    }
//}
