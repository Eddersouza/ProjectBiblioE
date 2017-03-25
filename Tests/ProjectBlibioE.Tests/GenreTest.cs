using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ProjectBiblioE.CrossCutting.Helpers;
using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Utils;
using ProjectBiblioE.Domain.Entities;
using ProjectBlibioE.Tests.Controllers;
using ProjectBlibioE.Tests.IoC;
using ProjectBlibioE.Tests.Repository;
using System.Collections.Generic;

namespace ProjectBlibioE.Tests
{
    [TestClass]
    public class GenreTest
    {
        private readonly GenreController _genreController;
        private readonly MessageContract _messageContract;

        private int genreId = 1;
        private string genreName = "Ação";


        public GenreTest()
        {
            List<Genre> list = new List<Genre>();

            list.Add(new Genre { GenreId = 1, Name = "Ação" });
            list.Add(new Genre { GenreId = 2, Name = "Faroeste" });
            list.Add(new Genre { GenreId = 3, Name = "Suspense" });

            GenreRepositoryTests.mockGenre = list;
            CompositionRoot.Wire(new IoCModule());
            _genreController = CompositionRoot.Resolve<GenreController>();
            _messageContract = new MessageBuilder();           
        }

        [TestMethod]
        public void GetAllGenresRecorded()
        {
            // Arrange
            GenreFilter filter = new GenreFilter();

            // Act
            var list = _genreController.GetGenres(filter);

            // Assert
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void GetGenresById()
        {
            // Arrange
            GenreFilter filter = new GenreFilter();
            filter.GenreId = genreId;

            // Act
            var obj = _genreController.GetGenres(filter).FirstOrDefault();

            // Assert
            Assert.IsNotNull(obj);
            Assert.AreEqual(genreId, obj.GenreId);
        }


        [TestMethod]
        public void GetGenresByName()
        {
            // Arrange
            GenreFilter filter = new GenreFilter();
            filter.Name = genreName;

            // Act
            var obj = _genreController.GetGenres(filter).FirstOrDefault();

            // Assert
            Assert.IsNotNull(obj);
            Assert.AreEqual(genreName, obj.Name);
        }
    }
}