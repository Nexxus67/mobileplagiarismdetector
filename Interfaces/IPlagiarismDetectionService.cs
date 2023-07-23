using System.Threading.Tasks;

namespace PlagiarismDetectorMobile.Services
{
    public interface ISettingsService
    {
        Task<string> GetUserPreferredLanguageAsync();

        Task SetUserPreferredLanguageAsync(string language);
    }
}
