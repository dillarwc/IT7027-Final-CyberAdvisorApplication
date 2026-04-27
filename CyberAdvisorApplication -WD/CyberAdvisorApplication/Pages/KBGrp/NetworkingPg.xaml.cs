namespace CyberAdvisorApplication.Pages.KBGrp;

public partial class NetworkingPg : ContentPage
{
    public NetworkingPg()
    {
        InitializeComponent();
    }

    private void BtnFirewalls_Clicked(object sender, EventArgs e)
    {
        FirewallsSection.IsVisible = true;
        SegmentationSection.IsVisible = false;
        IdsIpsSection.IsVisible = false;
    }

    private void BtnSegmentation_Clicked(object sender, EventArgs e)
    {
        FirewallsSection.IsVisible = false;
        SegmentationSection.IsVisible = true;
        IdsIpsSection.IsVisible = false;
    }

    private void BtnIdsIps_Clicked(object sender, EventArgs e)
    {
        FirewallsSection.IsVisible = false;
        SegmentationSection.IsVisible = false;
        IdsIpsSection.IsVisible = true;
    }
}