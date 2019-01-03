using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tavisca.StudentAdmissionSystem.Contract.Model;

namespace Tavisca.StudentAdmissionSystem.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionSystemController : Controller
    {
        private readonly IStudentAdmissionSystem _studentAdmissionService;
        public StudentAdmissionSystemController(IStudentAdmissionSystem studentAdmissionService)
        {
            _studentAdmissionService = studentAdmissionService;
        }

        [Route("admit_student")]
        [HttpPost]
        public Student /*StudentUniqueDetailsAfterAdmission*/ AdmitStudent([FromBody]Student request)
        {
            // student.Course = new ComputerScienceAndEngineering();
            //Admission.cs
            return _studentAdmissionService.AdmitAStudentInCollege(request);
        } 
    }

}
