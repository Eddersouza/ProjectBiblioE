namespace ProjectBiblioE.Domain.Contracts.Filters
{
    public class GenreFilter
    {
        /// <summary>
        /// Variable to genre id.
        /// </summary>
        private int _genreId;

        /// <summary>
        /// Variable to genre name.
        /// </summary>
        private string _name = string.Empty;

        /// <summary>
        /// Genre id.
        /// </summary>
        public int GenreId
        {
            get { return _genreId; }

            set { _genreId = value; }
        }

        /// <summary>
        /// Genre name.
        /// </summary>
        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }
    }
}