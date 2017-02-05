namespace ProjectBiblioE.Domain.Entities
{
    /// <summary>
    /// Represents language entity.
    /// </summary>
    public class Language
    {
        /// <summary>
        /// Max length for Language Culture Code.
        /// </summary>
        public const int LanguageCultureCodeMaxLength = 8;

        /// <summary>
        /// Max length for Language Name.
        /// </summary>
        public const int LanguageNameMaxLength = 30;

        /// <summary>
        /// Regex to culture code with 8 characters ex.: Cy-az-AZ.
        /// </summary>
        public const string RegexCultureCodeEightChars = "^[A-Z]{1}[a-z]{1}-[a-z]{2}-[A-Z]{2}$";

        /// <summary>
        /// Regex to culture code with 5 characters ex.: pt-BR.
        /// </summary>
        public const string RegexCultureCodeFiveChars = "^[a-z]{2}-[A-Z]{2}$";

        /// <summary>
        /// Code culture to language.
        /// </summary>
        public string CultureCode
        {
            get; set;
        }        

        /// <summary>
        /// Language Name.
        /// </summary>
        public string Name
        {
            get; set;
        }
    }
}