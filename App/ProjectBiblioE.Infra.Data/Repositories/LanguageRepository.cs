using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Domain.Entities;
using ProjectBiblioE.Infra.Data.EF;

namespace ProjectBiblioE.Infra.Data.Repositories
{
    /// <summary>
    /// Language Repository
    /// </summary>
    public class LanguageRepository : LanguageRepositoryContract
    {
        private readonly BiblioEContext _context;

        public LanguageRepository()
        {
            _context = new BiblioEContext();
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

        /// <summary>
        /// Get language.
        /// </summary>
        /// <param name="filters">Filter to language.</param>
        /// <returns>Language list.</returns>
        public List<Language> GetLanguages(LanguageFilter filters)
        {
            var languages = ApplyFilter(_context.Languages, filters).ToList();

            return languages;
        }

        /// <summary>
        /// Save Language.
        /// </summary>
        /// <param name="language">Language to save.</param>
        public void Save(Language language)
        {
            _context.Languages.Add(language);
            _context.SaveChanges();
        }
    }
}