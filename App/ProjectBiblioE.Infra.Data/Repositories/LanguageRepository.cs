using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Domain.Entities;
using ProjectBiblioE.Infra.Data.EF;

namespace ProjectBiblioE.Infra.Data.Repositories
{
    /// <summary>
    /// Language Repository.
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
        /// Delete language.
        /// </summary>
        /// <param name="code">Code of language.</param>
        /// <returns>True if exclude/ False if not.</returns>
        public bool Delete(string code)
        {
            var language
                = this.GetLanguages(new LanguageFilter { CultureCode = code })
                .FirstOrDefault();
            _context.Languages.Remove(language);
            _context.SaveChanges();

            return true;
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
        public bool Save(Language language)
        {
            _context.Languages.Add(language);
            _context.SaveChanges();

            return true;
        }

        /// <summary>
        /// Save edited language.
        /// </summary>
        /// <param name="language">language to save.</param>
        /// <returns>True if success saved / False if not.</returns>
        public bool SaveEdited(Language language)
        {
            _context.Entry(language).State = EntityState.Modified;
            _context.SaveChanges();

            return true;
        }
    }
}