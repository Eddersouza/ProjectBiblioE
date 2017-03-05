using System.Collections.Generic;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Entities;

namespace ProjectBiblioE.Domain.Contracts.Services
{
    /// <summary>
    /// Contract to language service.
    /// </summary>
    public interface LanguageServiceContract
    {
        /// <summary>
        /// Get languages by filters.
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