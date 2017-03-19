﻿using System.Collections.Generic;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Entities;

namespace ProjectBiblioE.Domain.Contracts.Repository
{
    /// <summary>
    /// Genre repository contract.
    /// </summary>
    public interface GenreRepositoryContract
    {
        /// <summary>
        /// Get genres by filters.
        /// </summary>
        /// <param name="filters">Filters to genre.</param>
        /// <returns>List of genres.</returns>
        List<Genre> GetGenres(GenreFilter filters);
    }
}