using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using ProjectBiblioE.Domain.Contracts.App;
using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Services;
using ProjectBiblioE.Domain.Entities;

namespace ProjectBiblioE.App.Tests
{
    [TestClass]
    public class LanguageAppTest
    {
        private readonly LanguageAppContract _languageContract;

        private string languageCulture = "pt-BR";
        private string languageNome = "Português";

        private IList<Language> mockLanguage = new List<Language>();

        public LanguageAppTest()
        {
            LanguageAppMock mock = new LanguageAppMock();

            Mock<LanguageServiceContract> mockApp = mock.createMock(mockLanguage);

            this._languageContract = new LanguageApp(mockApp.Object);
        }

        [TestMethod]
        public void GetAllLanguagesRecorded()
        {
            // Arrange
            LanguageFilter filter = new LanguageFilter();

            int count = this.mockLanguage.Count();

            // Act
            var list = _languageContract.GetLanguages(filter);

            // Assert
            Assert.IsNotNull(list);
            Assert.AreEqual(count, list.Count());
        }

        [TestMethod]
        public void GetLanguageByLanguageCode()
        {
            // Arrange
            LanguageFilter filter = new LanguageFilter();
            filter.CultureCode = languageCulture;

            int count = this.mockLanguage.Count();

            // Act
            var list = _languageContract.GetLanguages(filter);

            // Assert
            Assert.IsNotNull(list);
            Assert.AreNotEqual(count, list.Count());
            Assert.AreEqual(languageCulture, list.FirstOrDefault().CultureCode);
        }

        [TestMethod]
        public void GetLanguageByLanguageName()
        {
            // Arrange
            LanguageFilter filter = new LanguageFilter();
            filter.Name = languageNome;

            int count = this.mockLanguage.Count();

            // Act
            var list = _languageContract.GetLanguages(filter);

            // Assert
            Assert.IsNotNull(list);
            Assert.AreNotEqual(count, list.Count());
            Assert.AreEqual(languageNome, list.FirstOrDefault().Name);
        }

        [TestInitialize]
        public void initalize()
        {
            mockLanguage.Add(new Language { CultureCode = "pt-BR", Name = "Português" });
            mockLanguage.Add(new Language { CultureCode = "en-US", Name = "Inglês - Estados unidos" });
            mockLanguage.Add(new Language { CultureCode = "fr-FR", Name = "Françês" });
        }
    }
}