using Newtonsoft.Json;
using CyberAdvisorApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Newtonsoft.Json;
using CyberAdvisorApplication.Models;

namespace CyberAdvisorApplication.Services
{
    public class APIServiceNVD
    {
        public async Task<Root> APICall(string callFilters)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync($"https://services.nvd.nist.gov/rest/json/cves/2.0?{callFilters}");
            return JsonConvert.DeserializeObject<Root>(response);
        }

        public Task<Root> GetCVEs()
        {
            DateTime endDate = DateTime.UtcNow;
            DateTime startDate = DateTime.UtcNow.AddDays(-8);

            string startDateStr = startDate.ToString("yyyy-MM-ddTHH:mm:ss.fff");
            string endDateStr = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fff");

            return APICall($"pubStartDate={startDateStr}&pubEndDate={endDateStr}");
        }

        public Task<Root> GetKEVs()
        {
            DateTime endDate = DateTime.UtcNow;
            DateTime startDate = DateTime.UtcNow.AddDays(-30);

            string startDateStr = startDate.ToString("yyyy-MM-ddTHH:mm:ss.fff");
            string endDateStr = endDate.ToString("yyyy-MM-ddTHH:mm:ss.fff");

            return APICall($"kevStartDate={startDateStr}&kevEndDate={endDateStr}"); //*&resultsPerPage=20")*/
        }





        public Task<Root> GetByID(string id){
            return APICall($"cveId={id}");
        }
    }
}






//namespace CyberAdvisorApplication.Services
//{
//    public class APIServiceNVD
//    {
//        public async Task<Root> APICall(string callFilters)
//        {
//            var httpClient = new HttpClient();
//            var response = await httpClient.GetStringAsync($"https://services.nvd.nist.gov/rest/json/cves/2.0?{callFilters}");
//            return JsonConvert.DeserializeObject<Root>(response);
//        }

//        public Task<Root> GetCVEs()
//        {
//            return APICall("resultsPerPage=20");
//        }

//        public Task<Root> GetKEVs()
//        {
//            return APICall("hasKev&resultsPerPage=20");
//        }
//    }
//}