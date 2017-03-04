﻿using System.Collections.Generic;

using Moq;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Domain.Entities;

using ProjectBlibioE.Tests.Mocks;

namespace ProjectBlibioE.Tests.Repository
{
    public class LanguageRepositoryTests : LanguageRepositoryContract
    {
        private readonly LanguageRepositoryContract _languageContract;

        private IList<Language> mockLanguage = new List<Language>();

        public LanguageRepositoryTests()
        {
            LanguageRepositoryMock mock = new LanguageRepositoryMock();

            Mock<LanguageRepositoryContract> mockApp = mock.createMock(mockLanguage);

            this._languageContract = mockApp.Object;
        }

        public List<Language> GetLanguages(LanguageFilter filters)
        {
            return this._languageContract.GetLanguages(filters);
        }

        public bool Save(Language language)
        {
            return this._languageContract.Save(language);
        }
    }
}