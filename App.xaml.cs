using System.Diagnostics;

namespace PlagiarismDetectorMobile;

public partial class App : Application
{
    // Define a static property that can be accessed from anywhere in your app
    public static string AppName { get; } = "PlagiarismDetectorMobile";

    public static AppSettings Settings { get; private set; }

    public App()
    {
        InitializeComponent();
        InitializeAppSettings();
        MainPage = new MainPage();

        // Handle connectivity changes
        Connectivity.ConnectivityChanged += OnConnectivityChanged;
    }

    protected override void OnStart()
    {
        // Handle when your app starts
        Debug.WriteLine("Application has started.");
    }

    protected override void OnSleep()
    {
        // Handle when your app sleeps
        Debug.WriteLine("Application has gone to sleep.");
    }

    protected override void OnResume()
    {
        // Handle when your app resumes
        Debug.WriteLine("Application has resumed.");
    }

    private void InitializeAppSettings()
    {
        // Here you might want to load some settings from a file or a remote server
        Settings = new AppSettings
        {
            UseDarkTheme = true, // Set this according to the actual setting
            ApiUrl = "https://api.example.com" // Set this according to the actual setting
        };
    }

    public static ConnectivityStatus ConnectivityStatus { get; private set; }


    private void OnConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
    {
        // Update the current connectivity status
        ConnectivityStatus = e.NetworkAccess == NetworkAccess.Internet ? ConnectivityStatus.Online : ConnectivityStatus.Offline;

        Debug.WriteLine($"Connectivity changed to: {ConnectivityStatus}");
    }
}

public enum ConnectivityStatus
{
    Online,
    Offline
}

public class AppSettings
{
    public bool UseDarkTheme { get; set; }
    public string ApiUrl { get; set; }
}
