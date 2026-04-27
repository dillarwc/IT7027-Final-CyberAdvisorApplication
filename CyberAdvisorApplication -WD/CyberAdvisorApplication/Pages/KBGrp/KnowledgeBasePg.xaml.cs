namespace CyberAdvisorApplication.Pages.KBGrp;

public partial class KnowledgeBasePg : ContentPage
{
    public KnowledgeBasePg()
    {
        InitializeComponent();
    }

    private async void BtnNetworking_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("NetworkingPg");
    }

    private async void BtnIam_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("IAMPg");
    }

    private async void BtnEndpointSecurityMgmt_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("EndpointSecurityMgmtPg");
    }

    private async void BtnVectors_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("VectorsPg");
    }
}