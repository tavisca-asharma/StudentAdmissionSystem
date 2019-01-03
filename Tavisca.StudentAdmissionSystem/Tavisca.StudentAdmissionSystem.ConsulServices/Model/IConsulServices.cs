using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.StudentAdmissionSystem.ConsulServices.Model
{
    public interface IConsulServices
    {
        Task<string> GetHodName(string courseName);
    }
}
