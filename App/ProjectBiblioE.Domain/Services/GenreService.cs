using System;
using System.Collections.Generic;
using System.Linq;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Domain.Contracts.Services;
using ProjectBiblioE.Domain.Entities;

namespace ProjectBiblioE.Domain.Services
{
    /// <summary>
    /// Genre service
    /// </summary>
    public class GenreService : GenreServiceContract
    {
        /// <summary>
        /// Instance of genre repository.
        /// </summary>
        private readonly GenreRepositoryContract _genreRepository;

        /// <summary>
        /// Default Constructor.
        /// </summary>
        /// <param name="repository"></param>
        public GenreService(GenreRepositoryContract repository)
        {
            this._genreRepository = repository;
        }

        /// <summary>
        /// Get recorded genres.
        /// </summary>
        /// <param name="filters">Filter to genres.</param>
        /// <returns>List of genres</returns>
        public List<Genre> GetGenres(GenreFilter filters)
        {
            return this._genreRepository.GetGenres(filters);
        }

        /// <summary>
        /// Save genre.
        /// </summary>
        /// <param name="genre">Genre to save.</param>
        /// <returns>True if save/ False if not.</returns>
        public bool Save(Genre genre)
        {
            return this._genreRepository.Save(genre);
        }
    }
}