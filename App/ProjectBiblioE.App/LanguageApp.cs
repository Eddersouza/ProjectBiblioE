﻿using System.Collections.Generic;
using System.Linq;

using ProjectBiblioE.Domain.Contracts.App;
using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Services;
using ProjectBiblioE.Domain.Entities;

namespace ProjectBiblioE.App
{
    /// <summary>
    /// Language App.
    /// </summary>
    public class LanguageApp : LanguageAppContract
    {
        /// <summary>
        /// Instance of service language.
        /// </summary>
        private readonly LanguageServiceContract _languageContract;

        /// <summary>
        /// Constructor app language.
        /// </summary>
        /// <param name="languageContract">Instance of language service.</param>
        public LanguageApp(LanguageServiceContract languageContract)
        {
            this._languageContract = languageContract;
        }

        /// <summary>
        /// Delete language.
        /// </summary>
        /// <param name="code">Code of language.</param>
        /// <returns>True if exclude/ False if not.</returns>
        public bool Delete(string code)
        {
            return this._languageContract.Delete(code);
        }

        /// <summary>
        /// Get language records.
        /// </summary>
        /// <param name="filters">Filters to language.</param>
        /// <returns>List of language entity.</returns>
        public List<Language> GetLanguages(LanguageFilter filters)
        {
            return this._languageContract.GetLanguages(filters);
        }

        /// <summary>
        /// Save Language.
        /// </summary>
        /// <param name="language">Language to save.</param>
        public bool Save(Language language)
        {
            return this._languageContract.Save(language);
        }

        /// <summary>
        /// Save edited language.
        /// </summary>
        /// <param name="language">language to save.</param>
        /// <returns>True if success saved / False if not.</returns>
        public bool SaveEdited(Language language)
        {
            Language languageSaved =
                this.GetLanguages(
                    new LanguageFilter
                    {
                        CultureCode = language.CultureCode
                    }).FirstOrDefault();

            languageSaved.Name = language.Name;

            return this._languageContract.SaveEdited(languageSaved);
        }
    }
}