namespace ProjectBiblioE.Domain.Contracts.Filters
{
    /// <summary>
    /// Public class to represent Language Filter.
    /// </summary>
    public class LanguageFilter
    {
        /// <summary>
        /// Code culture to language.
        /// </summary>
        public string CultureCode
        {
            get;
            set;
        }

        /// <summary>
        /// Language Name.
        /// </summary>
        public string Name
        {
            get;
            set;
        }
    }
}