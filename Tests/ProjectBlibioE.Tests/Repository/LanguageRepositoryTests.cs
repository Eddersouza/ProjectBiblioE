using ProjectBiblioE.Domain.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Entities;
using ProjectBlibioE.Tests.Mocks;
using Moq;

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

        /// <summary>
        /// Apply filter. 
        /// </summary>
        /// <param name="query">Query to filter.</param>
        /// <param name="filter">Params to filter query.</param>
        /// <returns>Filtered query.</returns>
        public IQueryable<Language> ApplyFilter(IQueryable<Language> query, LanguageFilter filter)
        {
            if (!string.IsNullOrEmpty(filter.CultureCode))
            {
                query = query.Where(x => x.CultureCode.Contains(filter.CultureCode));
            }

            if (!string.IsNullOrEmpty(filter.Name))
            {
                query = query.Where(x => x.Name.Contains(filter.Name));
            }

            return query;
        }
    }
}
