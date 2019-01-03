using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tavisca.StudentAdmissionSystem.Contract.Model;

namespace Tavisca.StudentAdmissionSystem.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {

        [Route("demo")]
        [HttpGet]
        public string RandomMethod()
        {
            return "Ankita Sharma";
        }
    }
}
