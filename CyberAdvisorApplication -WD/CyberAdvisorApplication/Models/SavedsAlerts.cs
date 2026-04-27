using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberAdvisorApplication.Models
{
    public static class SavedsAlerts
    {
        public static ObservableCollection<string> SavedAlertID { get; } = new();

        public static void AddId(string id)
        {
            if (!SavedAlertID.Contains(id))
            {
                SavedAlertID.Add(id);
            }
        }
    }
}