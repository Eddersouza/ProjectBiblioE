using System;
using System.Collections.Generic;
using System.Resources;
using System.Windows.Forms;

using MetroFramework.Forms;

using ProjectBiblioE.CrossCutting.Helpers;
using ProjectBiblioE.CrossCutting.IoC;
using ProjectBiblioE.Domain.Contracts.Filters;
using ProjectBiblioE.Domain.Contracts.Utils;
using ProjectBiblioE.Domain.Enums;
using ProjectBiblioE.Presentation.WinForms.Contracts;
using ProjectBiblioE.Presentation.WinForms.Controllers;
using ProjectBiblioE.Presentation.WinForms.Utils.Extensions;
using ProjectBiblioE.Presentation.WinForms.ViewModels;
using ProjectBiblioE.Presentation.WinForms.Views.Messages;

namespace ProjectBiblioE.Presentation.WinForms.Views.Genres
{
    public partial class GenresScreen : MetroForm, ScreenContract
    {
        /// <summary>
        /// Constant to name of column Edit.
        /// </summary>
        private const string ColumnNameEdit = "ColumnEdit";

        /// <summary>
        /// Constant to name of column Remove.
        /// </summary>
        private const string ColumnNameRemove = "ColumnRemove";

        /// <summary>
        /// Instance of language controller
        /// </summary>
        private readonly GenreController _genreController;
        private readonly MessageContract _messageContract;
        private readonly ResourceManager _resources;

        public GenresScreen(ResourceManager resources)
        {
            InitializeComponent();

            CompositionRoot.Wire(new IoCModule());
            _genreController = CompositionRoot.Resolve<GenreController>();
            _messageContract = new MessageBuilder();
            _resources = resources;
        }

        /// <summary>
        /// Close this screen.
        /// </summary>
        public void ScreenClose()
        {
            this.Close();
        }

        /// <summary>
        /// Screen Load.
        /// </summary>
        public void ScreenLoad()
        {
            try
            {
                GenreFilter filter = new GenreFilter();
                List<GenreViewModel> list
                    = _genreController.GetGenres(filter);

                this.PopulateGridGenres(list);
            }
            catch (Exception)
            {
                // TODO: create log
                string message = this._resources.GetString(MessageBiblioE.MSG_GenericError.ToString());

                ShowMessageError(message);

                this.ScreenClose();
            }

            this.Cursor = Cursors.Default;
        }

        private void PopulateGridGenres(List<GenreViewModel> list)
        {
            if (list != null && list.Count > 0)
            {
                this.gridGenres.DataSource = list;
            }
            else
            {
                this.gridGenres.DataSource = new List<GenreViewModel>();
            }

            string labelLanguage =
                _resources.GetString(LabelText.Language.ToString());

            gridGenres.CreateColumnsByView(typeof(GenreViewModel));
            gridGenres.AddEditColumn(labelLanguage, ColumnNameEdit);
            gridGenres.AddRemoveColumn(labelLanguage, ColumnNameRemove);
        }

        /// <summary>
        /// Show message error.
        /// </summary>
        /// <param name="message">Message to error.</param>
        private void ShowMessageError(string message)
        {
            MessageScreen messageError
                    = new MessageScreen(
                        MessageType.Error,
                        message);

            messageError.ShowDialog();
        }

        /// <summary>
        /// Get the genre by typed name.
        /// </summary>
        /// <param name="sender">Textbox txtGenreNameSearch.</param>
        /// <param name="e">Arguments of event.</param>
        private void txtGenreNameSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                GenreFilter filter = new GenreFilter();

                string languageName = txtGenreNameSearch.Text;

                if (txtGenreNameSearch.Text.Length > 2)
                {
                    filter.Name = languageName;
                }

                List<GenreViewModel> list
                     = _genreController.GetGenres(filter);

                this.PopulateGridGenres(list);
            }
            catch (Exception)
            {
                // TODO: create log
                string message = this._resources.GetString(MessageBiblioE.MSG_GenericError.ToString());

                ShowMessageError(message);

                this.ScreenClose();
            }
        }
    }
}