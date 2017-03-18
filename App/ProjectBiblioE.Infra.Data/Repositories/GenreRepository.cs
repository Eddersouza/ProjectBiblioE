using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Infra.Data.EF;

namespace ProjectBiblioE.Infra.Data.Repositories
{
    /// <summary>
    /// Genre Repository.
    /// </summary>
    public class GenreRepository : GenreRepositoryContract
    {
        /// <summary>
        /// Instance of project.
        /// </summary>
        private readonly BiblioEContext _context;

        /// <summary>
        /// Default contract.
        /// </summary>
        public GenreRepository()
        {
            _context = new BiblioEContext();
        }
    }
}