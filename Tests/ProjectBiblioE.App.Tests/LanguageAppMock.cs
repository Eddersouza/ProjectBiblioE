using System.Collections.Generic;
using System.Linq;

using Moq;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Services;
using ProjectBiblioE.Domain.Entities;

namespace ProjectBiblioE.App.Tests
{
    public class LanguageAppMock
    {
        public Mock<LanguageServiceContract> createMock(IList<Language> mockLanguage)
        {
            Mock<LanguageServiceContract> mockApp = new Mock<LanguageServiceContract>();

            MockCreateSetupGetLanguage(ref mockApp, mockLanguage);

            return mockApp;
        }

        private void MockCreateSetupGetLanguage(ref Mock<LanguageServiceContract> mockApp, IList<Language> mockLanguage)
        {
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
    }
}