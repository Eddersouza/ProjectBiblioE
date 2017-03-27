using ProjectBiblioE.Domain.Enums;

namespace ProjectBiblioE.Domain.Contracts.Utils
{
    public interface MessageContract
    {
        string MountMessage(
            MessageBiblioE message,
            params string[] paramsMessage);

        string MountMessage(
            MessageBiblioE message,
            LabelText paramsMessageLabel,
            params string[] paramsMessage);

        /// <summary>
        /// Throw Messages.
        /// </summary>
        /// <param name="messagePatern">Pattern to message.</param>
        /// <param name="paramsMessage">Params to message.</param>
        void ThrowMessage(MessageBiblioE messagePatern, params string[] paramsMessage);

        /// <summary>
        /// Throw Messages.
        /// </summary>
        /// <param name="messagePatern">Pattern to message.</param>
        /// <param name="subject">Subject to message.</param>
        /// <param name="paramsMessage">Params to message.</param>
        void ThrowMessage(MessageBiblioE messagePatern, LabelText subject, params string[] paramsMessage);
    }
}