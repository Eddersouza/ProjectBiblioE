using System;
using System.Collections.Generic;
using System.Linq;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Domain.Entities;
using ProjectBiblioE.Infra.Data.EF;

namespace ProjectBiblioE.Infra.Data.Repositories
{
    /// <summary>
    /// Genre Repository.
    /// </summary>
    public class GenreRepository : GenreRepositoryContract
    {
        /// <summary>
        /// Instance of project.
        /// </summary>
        private readonly BiblioEContext _context;

        /// <summary>
        /// Default contract.
        /// </summary>
        public GenreRepository()
        {
            _context = new BiblioEContext();
        }

        /// <summary>
        /// Apply filter. 
        /// </summary>
        /// <param name="query">Query to filter.</param>
        /// <param name="filter">Params to filter query.</param>
        /// <returns>Filtered query.</returns>
        public IQueryable<Genre> ApplyFilter(IQueryable<Genre> query, GenreFilter filter)
        {
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
        public List<Genre> GetGenres(GenreFilter filters)
        {
            var languages = ApplyFilter(_context.Genres, filters).ToList();

            return languages;
        }

        /// <summary>
        /// Save genre.
        /// </summary>
        /// <param name="genre">Genre to save.</param>
        /// <returns>True if save/ False if not.</returns>
        public bool Save(Genre genre)
        {
            _context.Genres.Add(genre);
            _context.SaveChanges();

            return true;
        }
    }
}