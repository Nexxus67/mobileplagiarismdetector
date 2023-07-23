using System;
using System.Threading.Tasks;

namespace PlagiarismDetectorMobile.Services
{
    public class SettingsService : ISettingsService
    {
        private const string UserPreferredLanguageKey = "UserPreferredLanguage";

        public Task<string> GetUserPreferredLanguageAsync()
        {
            return Task.FromResult(Preferences.Get(UserPreferredLanguageKey, string.Empty));
        }

        public Task SetUserPreferredLanguageAsync(string language)
        {
            Preferences.Set(UserPreferredLanguageKey, language);
            return Task.CompletedTask;
        } 
    }
}