using System;
using System.Collections.Generic;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Domain.Contracts.Services;
using ProjectBiblioE.Domain.Entities;

namespace ProjectBiblioE.Domain.Services
{
    /// <summary>
    /// Language service.
    /// </summary>
    public class LanguageService : LanguageServiceContract
    {
        /// <summary>
        /// Instance of language repository.
        /// </summary>
        private readonly LanguageRepositoryContract _languageRepository;

        /// <summary>
        /// Constructor for service language.
        /// </summary>
        /// <param name="languageRepositoryContract">Instance of repository.</param>
        public LanguageService(LanguageRepositoryContract languageRepositoryContract)
        {
            this._languageRepository = languageRepositoryContract;
        }

        /// <summary>
        /// Get language for repository.
        /// </summary>
        /// <param name="filters">Filter to language.</param>
        /// <returns>Language list entity.</returns>
        public List<Language> GetLanguages(LanguageFilter filters)
        {
            return this._languageRepository.GetLanguages(filters);
        }

        /// <summary>
        /// Save Language.
        /// </summary>
        /// <param name="language">Language to save.</param>
        public bool Save(Language language)
        {
            return this._languageRepository.Save(language);
        }
    }
}