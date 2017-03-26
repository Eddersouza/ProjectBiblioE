using ProjectBiblioE.Domain.Contracts.App;
using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Entities;
using ProjectBiblioE.Presentation.WinForms.ViewModels;
using System.Collections.Generic;

namespace ProjectBiblioE.Presentation.WinForms.Controllers
{
    public class GenreController
    {
        /// <summary>
        /// Instance of genre app.
        /// </summary>
        private readonly GenreAppContract _genreApp;

        /// <summary>
        /// Default controller.
        /// </summary>
        /// <param name="genreApp">Instance of genre app</param>
        public GenreController(GenreAppContract genreApp)
        {
            this._genreApp = genreApp;
        }

        /// <summary>
        /// Get recorded genres.
        /// </summary>
        /// <param name="filters">Filters to genres.</param>
        /// <returns>Recorded genres.</returns>
        public List<GenreViewModel> GetGenres(GenreFilter filters)
        {
            List<GenreViewModel> viewList = new List<GenreViewModel>();

            List<Genre> list = _genreApp.GetGenres(filters);

            if (list != null)
            {
                foreach (var genre in list)
                {
                    viewList.Add(new GenreViewModel(genre));
                }
            }

            return viewList;
        }        
    }
}