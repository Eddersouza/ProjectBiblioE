using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBiblioE.Domain.Entities
{
    /// <summary>
    /// Represents language entity
    /// </summary>
    public class Language
    {
        /// <summary>
        /// Regex to culture code with 8 characters ex.: Cy-az-AZ
        /// </summary>
        public const string RegexCultureCodeEightChars = "^[A-Z]{1}[a-z]{1}-[a-z]{2}-[A-Z]{2}$";

        /// <summary>
        /// Regex to culture code with 5 characters ex.: pt-BR
        /// </summary>
        public const string RegexCultureCodeFiveChars = "^[a-z]{2}-[A-Z]{2}$";

        /// <summary>
        /// Code culture to language
        /// </summary>
        public string CultureCode
        {
            get; set;
        }

        /// <summary>
        /// Index of Language
        /// </summary>
        public int LanguageID
        {
            get; set;
        }

        /// <summary>
        /// Language Name
        /// </summary>
        public string Name
        {
            get; set;
        }
    }
}