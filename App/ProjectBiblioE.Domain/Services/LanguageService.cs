using System.Collections.Generic;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Domain.Contracts.Services;
using ProjectBiblioE.Domain.Entities;
using ProjectBiblioE.Domain.Exceptions;
using ProjectBiblioE.Domain.Contracts.Utils;
using ProjectBiblioE.Domain.Enums;

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
        /// Instance of language repository.
        /// </summary>
        private readonly MessageContract _messageContract;

        /// <summary>
        /// Constructor for service language.
        /// </summary>
        /// <param name="languageRepositoryContract">Instance of repository.</param>
        public LanguageService(
            LanguageRepositoryContract languageRepositoryContract,
            MessageContract messageContract)
        {
            this._languageRepository = languageRepositoryContract;
            this._messageContract = messageContract;
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
            var obj =
                this._languageRepository
                    .GetLanguages(
                        new LanguageFilter
                        {
                            CultureCode = language.CultureCode
                        });

            if (obj != null && obj.Count != 0)
            {
                string messageAlreadExists
                    = this._messageContract
                    .MountMessage(
                        MessageBiblioE.MSG_Alredy_Exists,
                        "Idioma",
                        language.CultureCode);

                throw new BiblioEException(messageAlreadExists);
            }

            return this._languageRepository.Save(language);
        }
    }
}