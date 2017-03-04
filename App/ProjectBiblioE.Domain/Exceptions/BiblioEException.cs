using System;

namespace ProjectBiblioE.Domain.Exceptions
{
    public class BiblioEException : Exception
    {
        public BiblioEException()
        {
        }

        public BiblioEException(string message) : base(message)
        {
        }

        public BiblioEException(string message, Exception inner) : base(message, inner)
        {
        }

    }
}