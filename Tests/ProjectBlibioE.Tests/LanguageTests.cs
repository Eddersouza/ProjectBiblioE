using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectBlibioE.Tests.IoC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectBiblioE.Domain.Contracts.Filters;

namespace ProjectBlibioE.Tests
{
    [TestClass]
    public class LanguageTests
    {
        private readonly LanguageController _languageController;

        public LanguageTests()
        {
            
            CompositionRoot.Wire(new IoCModule());
            _languageController = CompositionRoot.Resolve<LanguageController>();
        }

        [TestMethod]
        public void GetAllLanguagesRecorded()
        {
            // Arrange
            LanguageFilter filter = new LanguageFilter();

            int count = 0;

            // Act
            var list = _languageController.GetLanguages(filter);

            // Assert
            Assert.IsNotNull(list);
            Assert.AreEqual(count, list.Count());
        }
    }
}
