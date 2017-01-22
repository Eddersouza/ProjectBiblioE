using System.Collections.Generic;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Entities;

namespace ProjectBiblioE.Domain.Contracts.App
{
    /// <summary>
    /// Represent language app contract.
    /// </summary>
    public interface LanguageAppContract
    {
        /// <summary>
        /// Get languages by filters.
        /// </summary>
        /// <param name="filters">Filters to languages.</param>
        /// <returns>List of languages.</returns>
        List<Language> GetLanguages(LanguageFilter filters);
    }
}