using System;
using System.Collections.Generic;
using System.Linq;

using Moq;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Domain.Entities;

namespace ProjectBlibioE.Tests.Mocks
{
    public class LanguageRepositoryMock
    {
        public Mock<LanguageRepositoryContract> createMock(IList<Language> mockLanguage)
        {
            Mock<LanguageRepositoryContract> mockRepository = new Mock<LanguageRepositoryContract>();

            MockCreateSetupGetLanguage(ref mockRepository, mockLanguage);
            MockCreateSetupSave(ref mockRepository, mockLanguage);
            MockCreateSetupSaveEdited(ref mockRepository, mockLanguage);
            MockCreateSetupDelete(ref mockRepository, mockLanguage);

            return mockRepository;
        }

        private void MockCreateSetupDelete(ref Mock<LanguageRepositoryContract> mockApp, IList<Language> mockLanguage)
        {
            mockApp.Setup(ls =>
               ls.Delete(It.IsAny<string>()))
               .Returns((string obj) =>
               {
                   var language = mockLanguage.Where(l => l.CultureCode.Equals(obj));

                   if (language != null && language.Count() == 1)
                   {
                       mockLanguage.Remove(language.FirstOrDefault());
                       return true;

                   }

                   return false;
               });
        }

        private void MockCreateSetupGetLanguage(
            ref Mock<LanguageRepositoryContract> mockApp,
            IList<Language> mockLanguage)
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

        private void MockCreateSetupSave(
            ref Mock<LanguageRepositoryContract> mockApp,
            IList<Language> mockLanguage)
        {
            mockApp.Setup(ls =>
                ls.Save(It.IsAny<Language>()))
                .Returns((Language obj) =>
                {
                    if (!string.IsNullOrEmpty(obj.CultureCode) && !string.IsNullOrEmpty(obj.Name))
                    {
                        mockLanguage.Add(obj);
                        return true;
                    }
                    return false;
                });
        }

        private void MockCreateSetupSaveEdited(
            ref Mock<LanguageRepositoryContract> mockApp,
            IList<Language> mockLanguage)
        {
            mockApp.Setup(ls =>
               ls.SaveEdited(It.IsAny<Language>()))
               .Returns((Language obj) =>
               {
                   var language = mockLanguage.Where(l => l.CultureCode.Equals(obj.CultureCode));

                   if (language != null && language.Count() == 1)
                   {
                       language.FirstOrDefault().Name = obj.Name;
                       return true;

                   }

                   return false;
               });
        }
    }
}