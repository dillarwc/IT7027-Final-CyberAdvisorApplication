using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberAdvisorApplication.Models
{
    public class AdvisoryItem
    {
        public string Id { get; set; } = "";
        public string Description { get; set; } = "";
        public string PublishedDate { get; set; } = "";
        public string Url { get; set; } = "";
    }
}
