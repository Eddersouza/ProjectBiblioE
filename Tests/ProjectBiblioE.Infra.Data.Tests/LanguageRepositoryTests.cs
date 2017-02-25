using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Domain.Entities;

namespace ProjectBiblioE.Infra.Data.Tests
{
    [TestClass]
    public class LanguageRepositoryTests
    {
        private readonly LanguageRepositoryContract _languageContract;

        private string languageCulture = "pt-BR";
        private string languageNome = "Português";
        private IList<Language> mockLanguage = 
          new List<Language>
          {
                new Language
                {
                    CultureCode ="pt-BR",
                    Name = "Português"
                },

                new Language
                {
                    CultureCode ="en-US",
                    Name = "Inglês - Estados unidos"
                },

                new Language
                {
                    CultureCode ="fr-FR",
                    Name = "Françês"
                }
          };

        public LanguageRepositoryTests()
        {
            Mock<LanguageRepositoryContract> mockApp = new Mock<LanguageRepositoryContract>();

            mockApp.Setup(
                lg => lg
                .GetLanguages(It.IsAny<LanguageFilter>()))
                .Returns((LanguageFilter obj) =>
                {
                    List<Language> list = mockLanguage.ToList();

                    if (!string.IsNullOrEmpty(obj.CultureCode))
                    {
                        list = list.Where(
                            l => l.CultureCode.Contains(obj.CultureCode))
                            .ToList();
                    }

                    if (!string.IsNullOrEmpty(obj.Name))
                    {
                        list = list.Where(
                            l => l.Name.Contains(obj.Name))
                            .ToList();
                    }

                    return list;
                });

            this._languageContract = mockApp.Object;
        }

        [TestMethod]
        public void GetAllLanguagesRecorded()
        {
            // Arrange
            LanguageFilter filter =
                new LanguageFilter();
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
            LanguageFilter filter =
                new LanguageFilter();
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
            LanguageFilter filter =
                new LanguageFilter();
            filter.Name = languageNome;
            int count = this.mockLanguage.Count();

            // Act
            var list = _languageContract.GetLanguages(filter);

            // Assert
            Assert.IsNotNull(list);
            Assert.AreNotEqual(count, list.Count());
            Assert.AreEqual(languageNome, list.FirstOrDefault().Name);
        }
    }
}