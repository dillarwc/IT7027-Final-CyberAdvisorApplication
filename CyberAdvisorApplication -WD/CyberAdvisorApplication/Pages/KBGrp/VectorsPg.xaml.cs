namespace CyberAdvisorApplication.Pages.KBGrp;

public partial class VectorsPg : ContentPage
{
    public VectorsPg()
    {
        InitializeComponent();
    }

    private void BtnPhishing_Clicked(object sender, EventArgs e)
    {
        PhishingSection.IsVisible = true;
        DownloadsSection.IsVisible = false;
        CredentialTheftSection.IsVisible = false;
        ExploitationSection.IsVisible = false;
    }

    private void BtnDownloads_Clicked(object sender, EventArgs e)
    {
        PhishingSection.IsVisible = false;
        DownloadsSection.IsVisible = true;
        CredentialTheftSection.IsVisible = false;
        ExploitationSection.IsVisible = false;
    }

    private void BtnCredentialTheft_Clicked(object sender, EventArgs e)
    {
        PhishingSection.IsVisible = false;
        DownloadsSection.IsVisible = false;
        CredentialTheftSection.IsVisible = true;
        ExploitationSection.IsVisible = false;
    }

    private void BtnExploitation_Clicked(object sender, EventArgs e)
    {
        PhishingSection.IsVisible = false;
        DownloadsSection.IsVisible = false;
        CredentialTheftSection.IsVisible = false;
        ExploitationSection.IsVisible = true;
    }
}