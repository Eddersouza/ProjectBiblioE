namespace ProjectBiblioE.Domain.Contracts.Filters
{
    /// <summary>
    /// Public class to represent Language Filter.
    /// </summary>
    public class LanguageFilter
    {
        /// <summary>
        /// Variable to culture code.
        /// </summary>
        private string _cultureCode = string.Empty;

        /// <summary>
        /// Variable to name.
        /// </summary>
        private string _name = string.Empty;

        /// <summary>
        /// Code culture to language.
        /// </summary>
        public string CultureCode
        {
            get { return _cultureCode; }

            set { _cultureCode = value; }
        }        

        /// <summary>
        /// Language Name.
        /// </summary>
        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }
    }
}