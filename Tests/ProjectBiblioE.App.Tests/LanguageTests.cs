using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjectBiblioE.Domain.Contracts.App;
using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBiblioE.App.Tests
{
    [TestClass]
    public class LanguageTests
    {
        private readonly LanguageAppContract _languageContract;

        public LanguageTests()
        {
            Mock<LanguageAppContract> mockApp = new Mock<LanguageAppContract>();

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
        }

        private IList<Language> mockLanguage =
            new List<Language>
            {
                new Language
                {
                    CultureCode ="pt-BR",
                    LanguageID =1,
                    Name = "Português"
                },

                new Language
                {
                    CultureCode ="en-US",
                    LanguageID =2,
                    Name = "Inglês - Estados unidos"
                },

                new Language
                {
                    CultureCode ="fr-FR",
                    LanguageID =3,
                    Name = "Françês"
                }
            };


        [TestMethod]
        public void GetAllLanguagesRecorded()
        {

        }
    }
}
