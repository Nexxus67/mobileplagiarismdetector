using System.Threading.Tasks;

namespace PlagiarismDetectorMobile.Interfaces
{
    public interface ISettingsService
    {
        Task<string> GetUserPreferredLanguageAsync();
        Task SetUserPreferredLanguageAsync(string language);
    }
}