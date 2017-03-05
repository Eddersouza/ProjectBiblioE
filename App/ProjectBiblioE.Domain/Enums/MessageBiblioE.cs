namespace ProjectBiblioE.Domain.Enums
{
    /// <summary>
    /// Contracts to message.
    /// </summary>
    public enum MessageBiblioE
    {
        /// <summary>
        /// {0} {1} já existe!
        /// </summary>
        MSG_Alredy_Exists,

        /// <summary>
        /// O campo {0} é obrigatório!
        /// </summary>
        MSG_Field_Required,

        /// <summary>
        /// Generic error.
        /// </summary>
        MSG_GenericError,

        /// <summary>
        /// {0} {1} salvo com sucesso!
        /// </summary>
        MSG_Success_Saved        
    }
}