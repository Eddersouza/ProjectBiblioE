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
        /// Delete language.
        /// </summary>
        /// <param name="code">Code of language.</param>
        /// <returns>True if exclude/ False if not.</returns>
        bool Delete(string code);

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
        /// <returns>True if exclude/ False if not.</returns>
        bool Save(Language language);

        /// <summary>
        /// Save Edited Language.
        /// </summary>
        /// <param name="language">Language to save.</param>
        /// <returns>True if exclude/ False if not.</returns>
        bool SaveEdited(Language language);
    }
}