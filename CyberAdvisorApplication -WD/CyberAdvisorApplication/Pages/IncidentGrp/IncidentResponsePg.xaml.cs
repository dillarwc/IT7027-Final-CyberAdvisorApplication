namespace CyberAdvisorApplication.Pages.IncidentGrp;

public partial class IncidentResponsePg : ContentPage
{
    public IncidentResponsePg()
    {
        InitializeComponent();
    }

    private async void BtnPhishing_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("PhishingResponsePg");
    }

    private async void BtnMalware_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("MalwareResponsePg");
    }

    private async void BtnAccountCompromise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("AccountCompromisePg");
    }

    private async void BtnNetwork_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("NetworkIncidentPg");
    }
}