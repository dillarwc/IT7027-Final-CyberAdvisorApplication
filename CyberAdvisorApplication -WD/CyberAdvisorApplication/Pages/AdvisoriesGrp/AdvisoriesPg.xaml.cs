namespace CyberAdvisorApplication.Pages.AdvisoriesGrp;

public partial class AdvisoriesPg : ContentPage
{
    public AdvisoriesPg()
    {
        InitializeComponent();
    }

    private async void BtnKEVs_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("KEVsPg");
    }

    private async void BtnCves_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("CVEsPg");
    }

    private async void BtnSaved_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("SavedAdvisoriesPg");
    }
}