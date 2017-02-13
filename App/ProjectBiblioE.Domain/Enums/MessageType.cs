using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBiblioE.Domain.Enums
{
    /// <summary>
    /// Represent messages type in the system.
    /// </summary>
    public enum MessageType
    {
        /// <summary>
        /// Confirm message.
        /// </summary>
        Confirm,

        /// <summary>
        /// Error message.
        /// </summary>
        Error,

        /// <summary>
        /// Success message.
        /// </summary>
        Success
    }
}
