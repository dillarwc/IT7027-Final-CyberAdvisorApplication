using Plugin.LocalNotification;
namespace CyberAdvisorApplication.Pages;

public partial class WelcomePg : ContentPage
{
    public WelcomePg()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await LocalNotificationCenter.Current.RequestNotificationPermission();

            //    Schedule = new NotificationRequestSchedule
        //    {
        //        NotifyTime = DateTime.Now.AddYears(1)
        //    }
        //};
      //  LocalNotificationCenter.Current.Show(notification);




    }}