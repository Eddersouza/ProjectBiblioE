using System.Collections.Generic;

using ProjectBiblioE.Domain.Contracts.App;
using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Presentation.WinForms.ViewModels;

namespace ProjectBiblioE.Presentation.WinForms.Controllers
{
    /// <summary>
    /// Language Controller.
    /// </summary>
    public class LanguageController
    {
        /// <summary>
        /// Instance of language app.
        /// </summary>
        private readonly LanguageAppContract _languageApp;

        /// <summary>
        /// Instance of language app.
        /// </summary>
        /// <param name="languageApp">Instance of language app.</param>
        public LanguageController(LanguageAppContract languageApp)
        {
            _languageApp = languageApp;
        }

        /// <summary>
        /// Get the languages.
        /// </summary>
        /// <param name="filters">Filters to get languages.</param>
        /// <returns>List of languages.</returns>
        public List<LanguageViewModel> GetLanguages(LanguageFilter filters)
        {
            List<LanguageViewModel> languages = new List<LanguageViewModel>();

            var savedLanguages = _languageApp.GetLanguages(filters);

            if (savedLanguages != null)
            {
                foreach (var language in savedLanguages)
                {
                    languages.Add(new LanguageViewModel(language));
                }
            }

            return languages;
        }
    }
}