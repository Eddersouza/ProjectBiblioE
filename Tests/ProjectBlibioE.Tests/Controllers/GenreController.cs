using System.Collections.Generic;

using ProjectBiblioE.Domain.Contracts.App;
using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Entities;

namespace ProjectBlibioE.Tests.Controllers
{
    public class GenreController
    {
        private readonly GenreAppContract _genreApp;

        public GenreController(GenreAppContract genreApp)
        {
            _genreApp = genreApp;
        }

        public List<Genre> GetGenres(GenreFilter filters)
        {
            List<Genre> languages = _genreApp.GetGenres(filters);

            return languages;
        }
    }
}