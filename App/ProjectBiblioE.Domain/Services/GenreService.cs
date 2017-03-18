using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Domain.Contracts.Services;

namespace ProjectBiblioE.Domain.Services
{
    /// <summary>
    /// Genre service
    /// </summary>
    public class GenreService : GenreServiceContract
    {
        /// <summary>
        /// Instance of genre repository.
        /// </summary>
        private readonly GenreRepositoryContract _repository;

        /// <summary>
        /// Default Constructor.
        /// </summary>
        /// <param name="repository"></param>
        public GenreService(GenreRepositoryContract repository)
        {
            this._repository = repository;
        }
    }
}