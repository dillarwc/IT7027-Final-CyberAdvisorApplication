using CyberAdvisorApplication.Models;
using CyberAdvisorApplication.Services;
using Microsoft.Maui.ApplicationModel;


namespace CyberAdvisorApplication.Pages.AdvisoriesGrp;

public partial class SavedAdvisoriesPg : ContentPage
{
    public List<AdvisoryItem> AdvisoryList;

    public SavedAdvisoriesPg()
    {
        InitializeComponent();
        AdvisoryList = new List<AdvisoryItem>();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadSavedAdvisories();
    }

    private async Task LoadSavedAdvisories()
    {
        var apiService = new APIServiceNVD();
        AdvisoryList.Clear();

        foreach (string id in SavedsAlerts.SavedAlertID)
        {
            var result = await apiService.GetByID(id);

            //if (result == null || result.Vulnerabilities == null || result.Vulnerabilities.Count == 0)
            //    continue;

            var item = result.Vulnerabilities[0];
            string description = "";

            //if (item.Cve.descriptions != null)
            //{
                foreach (var desc in item.Cve.descriptions)
                {
                    if (desc.lang == "en")
                    {
                        description = desc.value;
                        break;
                    }
                }
            

            string publishedDate = item.Cve.published.ToString("yyyy-MM-dd");

            AdvisoryList.Add(new AdvisoryItem()
            {
                Id = item.Cve.ID ?? "",
                Description = description,
                PublishedDate = publishedDate,
                Url = $"https://nvd.nist.gov/vuln/detail/{item.Cve.ID}"
            });
        }

        CvSavedAdvisories.ItemsSource = null;
        CvSavedAdvisories.ItemsSource = AdvisoryList;
    }

    private async void UrlLabel_Tapped(object sender, TappedEventArgs e)
    {
        var label = sender as Label;
        var selectedItem = label?.BindingContext as AdvisoryItem;

        await Launcher.OpenAsync(selectedItem.Url);
    }
}