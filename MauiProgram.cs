using Microsoft.Extensions.Logging;
using PlagiarismDetectorMobile.Pages;
using PlagiarismDetectorMobile.Services;
using PlagiarismDetectorMobile.Interfaces;
namespace PlagiarismDetectorMobile;



public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });
        builder.Services.AddSingleton<ISettingsService, SettingsService>();

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Services.AddSingleton<IPlagiarismDetectionService, PlagiarismDetectionService>();
        builder.Logging.AddDebug();
#endif


        return builder.Build();
    }
}