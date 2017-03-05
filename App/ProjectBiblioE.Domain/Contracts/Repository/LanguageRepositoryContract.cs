﻿using System.Collections.Generic;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Entities;

namespace ProjectBiblioE.Domain.Contracts.Repository
{
    /// <summary>
    /// Contract to language repository.
    /// </summary>
    public interface LanguageRepositoryContract
    {
        /// <summary>
        /// Get languages by filters
        /// </summary>
        /// <param name="filters">Filters to languages.</param>
        /// <returns>List of languages.</returns>
        List<Language> GetLanguages(LanguageFilter filters);

        /// <summary>
        /// Save Language.
        /// </summary>
        /// <param name="language">Language to save.</param>
        bool Save(Language language);

        /// <summary>
        /// Save Edited Language.
        /// </summary>
        /// <param name="language">Language to save.</param>
        bool SaveEdited(Language language);
    }
}