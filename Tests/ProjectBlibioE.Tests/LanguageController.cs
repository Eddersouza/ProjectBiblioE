﻿using ProjectBiblioE.Domain.Contracts.App;
using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlibioE.Tests
{
    public class LanguageController
    {
        private readonly LanguageAppContract _languageApp;

        public LanguageController(LanguageAppContract languageApp)
        {
            _languageApp = languageApp;
        }
               
        public List<Language> GetLanguages(LanguageFilter filters)
        {
            List<Language> languages = _languageApp.GetLanguages(filters);
            
            return languages;
        }

       
        public void Save(Language language)
        {
            this._languageApp.Save(language);
        }
    }
}
