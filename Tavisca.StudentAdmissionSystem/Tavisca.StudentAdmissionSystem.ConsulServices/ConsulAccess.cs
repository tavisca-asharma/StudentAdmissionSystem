using System;
using System.Threading.Tasks;
using Tavisca.Common.Plugins.Configuration;
using Tavisca.Platform.Common.Configurations;
using Tavisca.StudentAdmissionSystem.ConsulServices.Model;

namespace Tavisca.StudentAdmissionSystem.ConsulServices
{
    public class ConsulAccess : IConsulServices
    {
        private readonly IConfigurationProvider _configurationProvider;
        public ConsulAccess()
        {
            _configurationProvider = new ConfigurationProvider("student_admission_asharma");
        }
        public async Task<string> GetHodName(string courseName)
        {
            var config = await _configurationProvider.GetTenantConfigurationAsync<ResponseSetting>("default", "student_admission_asharma", "cse", "hod");
            if (config != null)
            {
                return config.Hod;
            }
            return null;
        }
        public class ResponseSetting
        {
            public string Hod { get; set; } 
        }
    }
}
