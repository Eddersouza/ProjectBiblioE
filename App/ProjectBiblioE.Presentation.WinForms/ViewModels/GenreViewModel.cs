using ProjectBiblioE.CrossCutting.Resource;
using ProjectBiblioE.Domain.Entities;
using ProjectBiblioE.Presentation.WinForms.Utils.Attributes;

namespace ProjectBiblioE.Presentation.WinForms.ViewModels
{
    /// <summary>
    /// Genre view model.
    /// </summary>
    public class GenreViewModel
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public GenreViewModel()
        {
        }

        /// <summary>
        /// Defalt constructor with genre view constructor.
        /// </summary>
        /// <param name="genre">Genre to change</param>
        public GenreViewModel(Genre genre)
        {
            this.GenreId = genre.GenreId;
            this.Name = genre.Name;
        }

        /// <summary>
        /// Genre ID.
        /// </summary>
        [CustomTableAttributes(ColumnName = "GenreViewModel_GenreId", ColumnOrder = 0, FitColumn = true, ResourceType = typeof(Resources))]
        public int GenreId
        {
            get; set;
        }

        /// <summary>
        /// Genre Name.
        /// </summary>
        [CustomTableAttributes(ColumnName = "GenreViewModel_Name", ColumnOrder = 1, ResourceType = typeof(Resources))]
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// Change view to genre.
        /// </summary>
        /// <returns>Genre created.</returns>
        public Genre ToGenreEntity()
        {
            Genre genre = new Genre();
            genre.GenreId = this.GenreId;
            genre.Name = this.Name;

            return genre;
        }
    }
}