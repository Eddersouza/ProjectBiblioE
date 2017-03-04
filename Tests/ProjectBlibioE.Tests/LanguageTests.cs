using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProjectBiblioE.Domain.Contracts.Filters;

using ProjectBlibioE.Tests.IoC;
using ProjectBiblioE.Domain.Entities;
using ProjectBiblioE.Domain.Exceptions;

namespace ProjectBlibioE.Tests
{
    [TestClass]
    public class LanguageTests
    {
        private readonly LanguageController _languageController;
        private string culture = "pt-BR";
        private string cultureNew = "fr-FR";
        private string name = "Português - Brasil";
        private string nameNew = "Francês - França";

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

            // Act
            var list = _languageController.GetLanguages(filter);

            // Assert
            Assert.IsNotNull(list);            
        }

        [TestMethod]
        public void GetLanguageByCulture()
        {
            // Arrange
            LanguageFilter filter = new LanguageFilter();
            filter.CultureCode = culture;

            // Act
            var obj = _languageController.GetLanguages(filter).FirstOrDefault();

            // Assert
            Assert.IsNotNull(obj);
            Assert.AreEqual(culture, obj.CultureCode);
        }

        [TestMethod]
        public void GetLanguageByName()
        {
            // Arrange
            LanguageFilter filter = new LanguageFilter();
            filter.Name = name;

            // Act
            var obj = _languageController.GetLanguages(filter).FirstOrDefault();

            // Assert
            Assert.IsNotNull(obj);
            Assert.AreEqual(name, obj.Name);
        }

        [TestMethod]
        public void SaveLanguage()
        {
            // Arrange
            Language language = new Language();
            language.CultureCode = cultureNew;
            language.Name = nameNew;

            // Act
            bool hasSaved = this._languageController.Save(language);

            // Assert
            Assert.IsTrue(hasSaved);
        }

        [TestMethod]
        [ExpectedException(typeof(BiblioEException))]
        public void SaveExistingLanguage()
        {
            // Arrange
            Language language = new Language();
            language.CultureCode = culture;
            language.Name = name;

            // Act
            bool hasSaved = this._languageController.Save(language);

           
        }
    }
}