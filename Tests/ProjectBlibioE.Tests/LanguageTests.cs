﻿using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProjectBiblioE.Domain.Contracts.Filters;

using ProjectBlibioE.Tests.IoC;
using ProjectBiblioE.Domain.Entities;
using ProjectBiblioE.Domain.Exceptions;
using ProjectBiblioE.Domain.Contracts.Utils;
using ProjectBiblioE.CrossCutting.Helpers;
using ProjectBiblioE.Domain.Enums;

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
        private readonly MessageContract _messageContract;

        public LanguageTests()
        {
            CompositionRoot.Wire(new IoCModule());
            _languageController = CompositionRoot.Resolve<LanguageController>();
            _messageContract = new MessageBuilder();
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

            try
            {
                // Act
                bool hasSaved = this._languageController.Save(language);
            }
            catch (BiblioEException ex)
            {
                string messageAlreadExists
                        = this._messageContract
                        .MountMessage(
                            MessageBiblioE.MSG_Alredy_Exists,
                            LabelText.Language,
                            language.CultureCode);

                Assert.AreEqual(messageAlreadExists, ex.Message);
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(BiblioEException))]
        public void SaveLanguageWithEmptyCulture()
        {
            // Arrange
            Language language = new Language();
            language.CultureCode = string.Empty;
            language.Name = nameNew;

            try
            {
                // Act
                bool hasSaved = this._languageController.Save(language);
            }
            catch (BiblioEException ex)
            {
                string messageFieldRequired
                        = this._messageContract
                        .MountMessage(
                            MessageBiblioE.MSG_Field_Required,
                            LabelText.Code);

                Assert.AreEqual(messageFieldRequired, ex.Message);
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(BiblioEException))]
        public void SaveLanguageWithEmptyName()
        {
            // Arrange
            Language language = new Language();
            language.CultureCode = cultureNew;
            language.Name = string.Empty;

            try
            {
                // Act
                bool hasSaved = this._languageController.Save(language);
            }
            catch (BiblioEException ex)
            {
                string messageFieldRequired
                         = this._messageContract
                         .MountMessage(
                             MessageBiblioE.MSG_Field_Required,
                             LabelText.Name);

                Assert.AreEqual(messageFieldRequired, ex.Message);
                throw;
            }
        }
    }
}