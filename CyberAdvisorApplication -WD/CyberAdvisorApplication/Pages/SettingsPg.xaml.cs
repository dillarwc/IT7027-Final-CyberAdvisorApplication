namespace CyberAdvisorApplication.Pages;

public partial class SettingsPg : ContentPage
{
    public SettingsPg()
    {
        InitializeComponent();
    }

    private void BtnDefault_Clicked(object sender, EventArgs e)
    {
        Application.Current.UserAppTheme = AppTheme.Unspecified;

        Preferences.Set("ThemeSetting", "Default");
    }




    private void BtnDark_Clicked(object sender, EventArgs e)
    {
        Application.Current.UserAppTheme = AppTheme.Dark;
          Preferences.Set("ThemeSetting", "Dark");
    }
}