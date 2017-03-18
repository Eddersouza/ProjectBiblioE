using ProjectBiblioE.Domain.Contracts.App;

namespace ProjectBlibioE.Tests.Controllers
{
    public class GenreController
    {
        private readonly GenreAppContract _genreApp;

        public GenreController(GenreAppContract genreApp)
        {
            _genreApp = genreApp;
        }
    }
}