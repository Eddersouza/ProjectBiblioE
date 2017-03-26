using System;
using System.Collections.Generic;

using ProjectBiblioE.Domain.Contracts.App;
using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Services;
using ProjectBiblioE.Domain.Entities;

namespace ProjectBiblioE.App
{
    /// <summary>
    /// Genre app.
    /// </summary>
    public class GenreApp : GenreAppContract
    {
        /// <summary>
        /// Instance of service.
        /// </summary>
        private readonly GenreServiceContract _genreService;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="service">Instance of service.</param>
        public GenreApp(GenreServiceContract service)
        {
            this._genreService = service;
        }

        /// <summary>
        /// Get recorded genres.
        /// </summary>
        /// <param name="filters">Filter to genres.</param>
        /// <returns>List of genres</returns>
        public List<Genre> GetGenres(GenreFilter filters)
        {
            return this._genreService.GetGenres(filters);
        }

        /// <summary>
        /// Save genre.
        /// </summary>
        /// <param name="genre">Genre to save.</param>
        /// <returns>True if save/ False if not.</returns>
        public bool Save(Genre genre)
        {
            return this._genreService.Save(genre);
        }
    }
}