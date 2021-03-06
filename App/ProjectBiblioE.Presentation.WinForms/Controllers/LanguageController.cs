﻿using System.Collections.Generic;

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
        /// Delete language.
        /// </summary>
        /// <param name="code">Code of language.</param>
        public void Delete(string code)
        {
            this._languageApp.Delete(code);
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

        /// <summary>
        /// Save language.
        /// </summary>
        /// <param name="language">Language to save.</param>
        public void Save(LanguageViewModel language)
        {
            this._languageApp.Save(language.ToLanguageEntity());
        }

        /// <summary>
        /// Save edited language.
        /// </summary>
        /// <param name="language">Language to save.</param>
        public void SaveEdited(LanguageViewModel language)
        {
            this._languageApp.SaveEdited(language.ToLanguageEntity());
        }
    }
}