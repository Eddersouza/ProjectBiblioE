using System;
using System.Collections.Generic;
using System.Linq;

using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Domain.Contracts.Services;
using ProjectBiblioE.Domain.Entities;
using ProjectBiblioE.Domain.Contracts.Utils;
using ProjectBiblioE.Domain.Enums;

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
        private readonly GenreRepositoryContract _genreRepository;
        
        /// <summary>
        /// Instance of Message.
        /// </summary>
        private readonly MessageContract _messageContract;

        /// <summary>
        /// Default Constructor.
        /// </summary>
        /// <param name="repository"></param>
        public GenreService(GenreRepositoryContract repository,
            MessageContract messageContract)
        {
            this._genreRepository = repository;
            this._messageContract = messageContract;
        }

        /// <summary>
        /// Get recorded genres.
        /// </summary>
        /// <param name="filters">Filter to genres.</param>
        /// <returns>List of genres</returns>
        public List<Genre> GetGenres(GenreFilter filters)
        {
            return this._genreRepository.GetGenres(filters);
        }

        /// <summary>
        /// Save genre.
        /// </summary>
        /// <param name="genre">Genre to save.</param>
        /// <returns>True if save/ False if not.</returns>
        public bool Save(Genre genre)
        {
            var objList = this._genreRepository.GetGenres(
                    new GenreFilter
                    {
                        Name = genre.Name
                    });

            if (ExistLanguage(objList, genre))
                _messageContract.ThrowMessage(
                    MessageBiblioE.MSG_Alredy_Exists, LabelText.Genre, genre.Name);

            if (string.IsNullOrEmpty(genre.Name))
                _messageContract.ThrowMessage(MessageBiblioE.MSG_Field_Required, LabelText.Name);

            if (genre.Name.Length > Genre.GenreNameMaxLength)
                _messageContract.ThrowMessage(MessageBiblioE.MSG_Max_Characters, LabelText.Name, Genre.GenreNameMaxLength.ToString());

            return this._genreRepository.Save(genre);
        }

        /// <summary>
        /// Verifi if genre already exists.
        /// </summary>
        /// <param name="genres">Genres to compare.</param>
        /// <param name="genre">Genre to test.</param>
        /// <returns>True if exists/ False if not.</returns>
        private bool ExistLanguage(List<Genre> genres, Genre genre)
        {
            bool exists = false;

            if (genres != null && genres.Count != 0)
            {
                var obj = genres.FirstOrDefault();

                if (obj.Name.Equals(genre.Name))
                {
                    exists = true;
                }
            }

            return exists;
        }
    }
}