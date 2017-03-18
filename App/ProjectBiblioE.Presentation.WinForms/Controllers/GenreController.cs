using ProjectBiblioE.Domain.Contracts.App;

namespace ProjectBiblioE.Presentation.WinForms.Controllers
{
    public class GenreController
    {
        /// <summary>
        /// Instance of genre app.
        /// </summary>
        private readonly GenreAppContract _genreApp;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="genreApp"></param>
        public GenreController(GenreAppContract genreApp)
        {
            this._genreApp = genreApp;
        }
    }
}