using ProjectBiblioE.Domain.Contracts.App;
using ProjectBiblioE.Domain.Contracts.Services;

namespace ProjectBiblioE.App
{
    /// <summary>
    /// Genre app.
    /// </summary>
    public class GenreApp : GenreAppContract
    {
        /// <summary>
        /// Instance of service.
        /// </summary>
        private readonly GenreServiceContract _service;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="service">Instance of service.</param>
        public GenreApp(GenreServiceContract service)
        {
            this._service = service;
        }
    }
}