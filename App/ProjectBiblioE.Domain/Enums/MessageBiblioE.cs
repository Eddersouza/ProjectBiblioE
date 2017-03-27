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
        /// {0} {1} excluido com sucesso!
        /// </summary>
        MSG_Sussessfully_Deleted,

        /// <summary>
        /// Você deseja excluir {0} {1}?
        /// </summary>
        MSG_Do_You_Want_Delete,

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
        MSG_Success_Saved,

        /// <summary>
        /// O campo {0} deve ter no máximo {1} caracteres!
        /// </summary>
        MSG_Max_Characters
    }
}