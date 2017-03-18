using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlibioE.Tests.Repository
{
    public class GenreRepositoryTests : GenreRepositoryContract
    {
        private readonly GenreRepositoryContract _genreRepository;

        private IList<Genre> mockGenre = new List<Genre>();

        public GenreRepositoryTests(GenreRepositoryContract genreRepository)
        {
            _genreRepository = genreRepository;
        }
    }
}
