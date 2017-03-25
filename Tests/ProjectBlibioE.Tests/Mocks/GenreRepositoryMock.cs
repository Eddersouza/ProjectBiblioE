using System.Collections.Generic;
using System.Linq;

using Moq;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Domain.Entities;

namespace ProjectBlibioE.Tests.Mocks
{
    public class GenreRepositoryMock
    {
        public Mock<GenreRepositoryContract> createMock(IList<Genre> mockLanguage)
        {
            Mock<GenreRepositoryContract> mockRepository = new Mock<GenreRepositoryContract>();

            MockCreateSetupGetGenres(ref mockRepository, mockLanguage);

            return mockRepository;
        }

        private void MockCreateSetupGetGenres(
            ref Mock<GenreRepositoryContract> mockRepository,
            IList<Genre> mockLanguage)
        {
            mockRepository.Setup(
                lg => lg
                .GetGenres(It.IsAny<GenreFilter>()))
                .Returns((GenreFilter obj) =>
                {
                    List<Genre> list = mockLanguage.ToList();

                    if (obj.GenreId > 0)
                    {
                        list = list.Where(
                            l => l.GenreId.Equals(obj.GenreId))
                            .ToList();
                    }

                    if (!string.IsNullOrEmpty(obj.Name))
                    {
                        list = list.Where(
                            l => l.Name.Contains(obj.Name))
                            .ToList();
                    }

                    return list;
                });
        }
    }
}