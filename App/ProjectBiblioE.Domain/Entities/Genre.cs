namespace ProjectBiblioE.Domain.Entities
{
    /// <summary>
    /// Entity Genre.
    /// </summary>
    public class Genre
    {
        /// <summary>
        /// Genre name MaxLength.
        /// </summary>
        public const int GenreNameMaxLength = 30;

        /// <summary>
        /// Genre ID.
        /// </summary>
        public int GenreId
        {
            get; set;
        }

        /// <summary>
        /// Genre Name.
        /// </summary>
        public string Name
        {
            get; set;
        }
    }
}