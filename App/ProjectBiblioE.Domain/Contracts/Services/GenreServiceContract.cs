using System.Collections.Generic;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Entities;

namespace ProjectBiblioE.Domain.Contracts.Services
{
    /// <summary>
    /// Genre service contract.
    /// </summary>
    public interface GenreServiceContract
    {
        /// <summary>
        /// Get genres by filters.
        /// </summary>
        /// <param name="filters">Filters to genre.</param>
        /// <returns>List of genres.</returns>
        List<Genre> GetGenres(GenreFilter filters);

        /// <summary>
        /// Save genre.
        /// </summary>
        /// <param name="genre">Genre to save.</param>
        /// <returns>True if save/ False if not.</returns>
        bool Save(Genre genre);
    }
}