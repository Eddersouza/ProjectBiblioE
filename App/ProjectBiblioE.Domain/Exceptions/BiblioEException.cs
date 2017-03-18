using System;

namespace ProjectBiblioE.Domain.Exceptions
{
    /// <summary>
    /// Class for biblio exception.
    /// </summary>
    public class BiblioEException : Exception
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public BiblioEException()
        {
        }

        /// <summary>
        /// Constructor with message to throw.
        /// </summary>
        /// <param name="message">Message to exception.</param>
        public BiblioEException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Constructor with message and original exception.
        /// </summary>
        /// <param name="message">Message to exception.</param>
        /// <param name="inner">Original Exception.</param>
        public BiblioEException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}