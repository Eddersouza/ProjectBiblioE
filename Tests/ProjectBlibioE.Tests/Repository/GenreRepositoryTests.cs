using System.Collections.Generic;
using Moq;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Domain.Entities;

using ProjectBlibioE.Tests.Mocks;

namespace ProjectBlibioE.Tests.Repository
{
    public class GenreRepositoryTests : GenreRepositoryContract
    {
        private readonly GenreRepositoryContract _genreRepository;

        public static IList<Genre> mockGenre = new List<Genre>();

        public GenreRepositoryTests()
        {
            GenreRepositoryMock mock = new GenreRepositoryMock();
            
            Mock<GenreRepositoryContract> mockApp = mock.createMock(mockGenre);

            this._genreRepository = mockApp.Object;
        }

        public List<Genre> GetGenres(GenreFilter filters)
        {
            return this._genreRepository.GetGenres(filters);
        }
    }
}