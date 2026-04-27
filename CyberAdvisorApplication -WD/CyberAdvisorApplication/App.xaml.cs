namespace CyberAdvisorApplication
{
    public partial class App : Application
    {
        private string LastPage = "LastPageRoute";
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            gettheme();
            restorepage();
        }

        private void gettheme()
        {
            string savedtheme = Preferences.Get("ThemeSetting", "Default");
            if (savedtheme == "Default") { UserAppTheme = AppTheme.Unspecified; }
            else UserAppTheme = AppTheme.Dark;
        }


        protected override void OnSleep()
        {
            base.OnSleep();

            string currentRoute = Shell.Current.CurrentState.Location.ToString();
            Preferences.Set(LastPage, currentRoute);

        }


        private async void restorepage()
        {
            string lastroute = Preferences.Get(LastPage, "//WelcomePg");
            await Shell.Current.GoToAsync(lastroute);
        }

    }
}
