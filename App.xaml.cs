using System.Diagnostics;

namespace PlagiarismDetectorMobile;

public partial class App : Application
{
    // Define a static property that can be accessed from anywhere in your app
    public static string AppName { get; } = "PlagiarismDetectorMobile";
    public App()
    {
        InitializeComponent();
        MainPage = new MainPage();
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
}

