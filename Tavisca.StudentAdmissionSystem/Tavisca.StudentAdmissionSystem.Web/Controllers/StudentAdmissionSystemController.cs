using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tavisca.StudentAdmissionSystem.Service.DataContract.Model;

namespace Tavisca.StudentAdmissionSystem.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionSystemController : ControllerBase
    {
        private readonly IStudentAdmissionSystem _studentAdmissionService;
        public StudentAdmissionSystemController(IStudentAdmissionSystem studentAdmissionService)
        {
            _studentAdmissionService = studentAdmissionService;
        }

        [Route("admit_student")]
        [HttpPost]
        public string /*StudentUniqueDetailsAfterAdmission*/ AdmitStudent([FromBody]Student request)
        {
            // student.Course = new ComputerScienceAndEngineering();
            return _studentAdmissionService.AdmitAStudentInCollege(request);
            
        }
    }

}
