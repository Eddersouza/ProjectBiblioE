using System.Collections.Generic;

using ProjectBiblioE.Domain.Contracts.App;
using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Entities;

namespace ProjectBlibioE.Tests.Controllers
{
    public class LanguageController
    {
        private readonly LanguageAppContract _languageApp;

        public LanguageController(LanguageAppContract languageApp)
        {
            _languageApp = languageApp;
        }

        public bool Delete(string code)
        {
            return this._languageApp.Delete(code);
        }

        public List<Language> GetLanguages(LanguageFilter filters)
        {
            List<Language> languages = _languageApp.GetLanguages(filters);

            return languages;
        }

        public bool Save(Language language)
        {
            return this._languageApp.Save(language);
        }

        public bool SaveEdited(Language language)
        {
            return this._languageApp.SaveEdited(language);
        }
    }
}