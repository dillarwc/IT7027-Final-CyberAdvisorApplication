namespace CyberAdvisorApplication.Pages.KBGrp;

public partial class EndpointSecurityMgmtPg : ContentPage
{
    public EndpointSecurityMgmtPg()
    {
        InitializeComponent();
    }

    private void BtnMdm_Clicked(object sender, EventArgs e)
    {
        MdmSection.IsVisible = true;
        VulnMgmtSection.IsVisible = false;
        AvEdrSection.IsVisible = false;
    }

    private void BtnVulnMgmt_Clicked(object sender, EventArgs e)
    {
        MdmSection.IsVisible = false;
        VulnMgmtSection.IsVisible = true;
        AvEdrSection.IsVisible = false;
    }

    private void BtnAvEdr_Clicked(object sender, EventArgs e)
    {
        MdmSection.IsVisible = false;
        VulnMgmtSection.IsVisible = false;
        AvEdrSection.IsVisible = true;
    }
}