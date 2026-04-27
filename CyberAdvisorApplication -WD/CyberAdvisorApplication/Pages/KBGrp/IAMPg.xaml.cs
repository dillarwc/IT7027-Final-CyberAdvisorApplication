namespace CyberAdvisorApplication.Pages.KBGrp;

public partial class IAMPg : ContentPage
{
    public IAMPg()
    {
        InitializeComponent();
    }

    private void BtnAuthentication_Clicked(object sender, EventArgs e)
    {
        AuthenticationSection.IsVisible = true;
        AuthorizationSection.IsVisible = false;
        PamSection.IsVisible = false;
    }

    private void BtnAuthorization_Clicked(object sender, EventArgs e)
    {
        AuthenticationSection.IsVisible = false;
        AuthorizationSection.IsVisible = true;
        PamSection.IsVisible = false;
    }

    private void BtnPam_Clicked(object sender, EventArgs e)
    {
        AuthenticationSection.IsVisible = false;
        AuthorizationSection.IsVisible = false;
        PamSection.IsVisible = true;
    }
}