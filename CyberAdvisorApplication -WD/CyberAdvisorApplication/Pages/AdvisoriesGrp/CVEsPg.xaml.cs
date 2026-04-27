using CyberAdvisorApplication.Models;
using CyberAdvisorApplication.Services;
using Microsoft.Maui.ApplicationModel;
using Plugin.LocalNotification;

namespace CyberAdvisorApplication.Pages.AdvisoriesGrp;

public partial class CVEsPg : ContentPage
{
    public List<AdvisoryItem> AdvisoryList;

    public CVEsPg()
    {
        InitializeComponent();
        AdvisoryList = new List<AdvisoryItem>();
        _ = GetCVEs();
    }

    private async Task GetCVEs()
    {
        var apiService = new APIServiceNVD();
        var cveResult = await apiService.GetCVEs();

        if (cveResult == null || cveResult.Vulnerabilities == null)
            return;

        AdvisoryList.Clear();

        foreach (var item in cveResult.Vulnerabilities)
        {
            string description = "";

            if (item.Cve.descriptions != null)
            {
                foreach (var desc in item.Cve.descriptions)
                {
                    if (desc.lang == "en")
                    {
                        description = desc.value;
                        break;
                    }
                }
            }

            string publishedDate = item.Cve.published.ToString();


;
            AdvisoryList.Add(new AdvisoryItem()
            {
                Id = item.Cve.ID ?? "",
                Description = description,
                PublishedDate = publishedDate,
                Url = $"https://nvd.nist.gov/vuln/detail/{item.Cve.ID}"
            });
        }

        CvCVEs.ItemsSource = AdvisoryList;
    }

    private async void UrlLabel_Tapped(object sender, TappedEventArgs e)
    {
        var label = sender as Label;
        var selectedItem = label?.BindingContext as AdvisoryItem;

        if (selectedItem == null)
            return;

        await Launcher.OpenAsync(selectedItem.Url);
    }


    private async void Save_Btn_Clicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var selectedItem = button?.BindingContext as AdvisoryItem;
        SavedsAlerts.AddId(selectedItem.Id);
    }






    protected override async void OnAppearing()
    {
        base.OnAppearing();
        LocalNotificationCenter.Current.Cancel(100);
        var notification = new NotificationRequest
        {
            NotificationId = 100,
            Title = "Reminder_CheckCVEs",
            Description = "Dont forget to review the recent CVEs",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddDays(6)
            }
        };
        LocalNotificationCenter.Current.Show(notification);
    }

}