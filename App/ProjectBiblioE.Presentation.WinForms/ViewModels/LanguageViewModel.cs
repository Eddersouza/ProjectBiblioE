﻿using ProjectBiblioE.CrossCutting.Resource;
using ProjectBiblioE.Domain.Entities;
using ProjectBiblioE.Presentation.WinForms.Utils.Attributes;

namespace ProjectBiblioE.Presentation.WinForms.ViewModels
{
    /// <summary>
    /// Language  view.
    /// </summary>
    public class LanguageViewModel
    {
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public LanguageViewModel()
        {
        }

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="language">Language to view.</param>
        public LanguageViewModel(Language language)
        {            
            this.CultureCode = language.CultureCode;
            this.Name = language.Name;
        }

        /// <summary>
        /// Language culture code. 
        /// </summary>
        [CustomTableAttributes(ColumnName = "LanguageViewModel_Code", ColumnOrder = 0, FitColumn = true, ResourceType = typeof(Resources))]
        public string CultureCode
        {
            get; set;
        }

        /// <summary>
        /// Language name.
        /// </summary>
        [CustomTableAttributes(ColumnName = "LanguageViewModel_Name", ColumnOrder = 1, ResourceType = typeof(Resources))]
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// Change view to language entity.
        /// </summary>
        /// <returns>Language entity.</returns>
        public Language ToLanguageEntity()
        {
            Language language = new Language();
            language.CultureCode = this.CultureCode;
            language.Name = this.Name;

            return language;
        }
    }
}