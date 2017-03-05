using System;
using System.Collections.Generic;
using System.Linq;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Domain.Contracts.Services;
using ProjectBiblioE.Domain.Contracts.Utils;
using ProjectBiblioE.Domain.Entities;
using ProjectBiblioE.Domain.Enums;
using ProjectBiblioE.Domain.Exceptions;

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
            var objList = this._languageRepository.GetLanguages(
                    new LanguageFilter
                    {
                        CultureCode = language.CultureCode,
                        Name = language.Name,
                    });

            if (ExistLanguage(objList, language))
                this.ThrowMessage(
                    MessageBiblioE.MSG_Alredy_Exists, LabelText.Language, language.CultureCode);

            if (string.IsNullOrEmpty(language.CultureCode))
                this.ThrowMessage(MessageBiblioE.MSG_Field_Required, LabelText.Code);

            if (string.IsNullOrEmpty(language.Name))
                this.ThrowMessage(MessageBiblioE.MSG_Field_Required, LabelText.Name);

            return this._languageRepository.Save(language);
        }

        /// <summary>
        /// Save edited language.
        /// </summary>
        /// <param name="language">language to save.</param>
        /// <returns>True if success saved / False if not.</returns>
        public bool SaveEdited(Language language)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Verifi if language already exists.
        /// </summary>
        /// <param name="languages">Languages to compare.</param>
        /// <param name="language">Language to test.</param>
        /// <returns>True if exists/ False if not.</returns>
        private bool ExistLanguage(List<Language> languages, Language language)
        {
            bool exists = false;

            if (languages != null && languages.Count != 0)
            {
                var obj = languages.FirstOrDefault();

                if (obj.CultureCode.Equals(language.CultureCode)
                    || obj.Name.Equals(language.Name))
                {
                    exists = true;
                }
            }

            return exists;
        }

        /// <summary>
        /// Throw Messages.
        /// </summary>
        /// <param name="messagePatern">Pattern to message.</param>
        /// <param name="paramsMessage">Params to message</param>
        private void ThrowMessage(MessageBiblioE messagePatern, params string[] paramsMessage)
        {
            string messageFieldRequired
                = _messageContract.MountMessage(messagePatern, paramsMessage);

            throw new BiblioEException(messageFieldRequired);
        }

        /// <summary>
        /// Throw Messages.
        /// </summary>
        /// <param name="messagePatern">Pattern to message.</param>
        /// <param name="paramsMessage">Params to message</param>
        private void ThrowMessage(MessageBiblioE messagePatern, LabelText subject, params string[] paramsMessage)
        {
            string messageFieldRequired
                = _messageContract.MountMessage(messagePatern, subject, paramsMessage);

            throw new BiblioEException(messageFieldRequired);
        }
    }
}