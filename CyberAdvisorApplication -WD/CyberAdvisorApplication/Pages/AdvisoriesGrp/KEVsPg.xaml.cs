using CyberAdvisorApplication.Models;
using CyberAdvisorApplication.Services;
using Microsoft.Maui.ApplicationModel;

namespace CyberAdvisorApplication.Pages.AdvisoriesGrp;

public partial class KEVsPg : ContentPage
{
    public List<AdvisoryItem> AdvisoryList;

    public KEVsPg()
    {
        InitializeComponent();
        AdvisoryList = new List<AdvisoryItem>();
        _ = GetKEVs();
    }

    private async Task GetKEVs()
    {
        var apiService = new APIServiceNVD();
        var kevResult = await apiService.GetKEVs();

        if (kevResult == null || kevResult.Vulnerabilities == null)
            return;

        AdvisoryList.Clear();

        foreach (var item in kevResult.Vulnerabilities)
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



            AdvisoryList.Add(new AdvisoryItem()
            {
                Id = item.Cve.ID ?? "",
                Description = description,
                PublishedDate = publishedDate,
                Url = $"https://nvd.nist.gov/vuln/detail/{item.Cve.ID}"
            });
        }

        CvKEVs.ItemsSource = AdvisoryList;
    }

    private async void UrlLabel_Tapped(object sender, TappedEventArgs e)
    {
        var label = sender as Label;
        var selectedItem = label?.BindingContext as AdvisoryItem;

        await Launcher.OpenAsync(selectedItem.Url);
    }

    private async void Save_Btn_Clicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var selectedItem = button?.BindingContext as AdvisoryItem;
        SavedsAlerts.AddId(selectedItem.Id);
    }
}