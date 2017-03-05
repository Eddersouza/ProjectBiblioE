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

namespace ProjectBiblioE.Presentation.WinForms.Views.Languages
{
    /// <summary>
    /// Screen Language.
    /// </summary>
    public partial class LanguagesScreen : MetroForm, ScreenContract
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
        private readonly LanguageController _languageController;
        private readonly MessageContract _messageContract;
        private readonly ResourceManager _resources;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public LanguagesScreen(ResourceManager resources)
        {
            InitializeComponent();
            CompositionRoot.Wire(new IoCModule());
            _languageController = CompositionRoot.Resolve<LanguageController>();
            _messageContract = new MessageBuilder();
            _resources = resources;
        }

        /// <summary>
        /// Close screeen.
        /// </summary>
        public void ScreenClose()
        {
            this.Close();
        }

        /// <summary>
        /// Load screen data.
        /// </summary>
        public void ScreenLoad()
        {
            try
            {
                LanguageFilter filter = new LanguageFilter();
                List<LanguageViewModel> list
                    = _languageController.GetLanguages(filter);

                this.PopulateGridLanguage(list);
            }
            catch (Exception ex)
            {
                string message = this._resources.GetString(MessageBiblioE.MSG_GenericError.ToString());

                ShowErrorMessage(message);

                this.ScreenClose();
            }

            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Event of click btn new language.
        /// </summary>
        /// <param name="sender">Button new language.</param>
        /// <param name="e">Arguments of event.</param>
        private void BtnLanguageNew_Click(object sender, System.EventArgs e)
        {
            LanguageAddEditScreen languageNewScreen
                = new LanguageAddEditScreen(
                    _languageController,
                    _messageContract,
                    _resources);

            languageNewScreen.PrincipalScreen = this;

            languageNewScreen.ShowDialog();
        }

        /// <summary>
        /// Populate Grid of Genres.
        /// </summary>
        /// <param name="list">List of genres to populate. </param>
        private void PopulateGridLanguage(List<LanguageViewModel> list)
        {
            if (list != null && list.Count > 0)
            {
                this.gridLanguages.DataSource = list;
            }
            else
            {
                this.gridLanguages.DataSource = new List<LanguageViewModel>();
            }

            string labelLanguage =
                _resources.GetString(LabelText.Language.ToString());

            gridLanguages.CreateColumnsByView(typeof(LanguageViewModel));
            gridLanguages.AddEditColumn(labelLanguage, ColumnNameEdit);
            gridLanguages.AddRemoveColumn(labelLanguage, ColumnNameRemove);
        }

        /// <summary>
        /// Show message error.
        /// </summary>
        /// <param name="message">Message to error.</param>
        private void ShowErrorMessage(string message)
        {
            MessageScreen messageError
                    = new MessageScreen(
                        MessageType.Error,
                        message);

            messageError.ShowDialog();
        }

        /// <summary>
        /// Get the language by typed name.
        /// </summary>
        /// <param name="sender">Textbox txtLanguageNameSearch.</param>
        /// <param name="e">Arguments of event.</param>
        private void txtLanguageNameSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                LanguageFilter filter = new LanguageFilter();

                string languageCode = txtLanguageSearch.Text;
                string languageName = txtLanguageNameSearch.Text;

                if (txtLanguageNameSearch.Text.Length > 2)
                {
                    filter.CultureCode = languageCode;
                    filter.Name = languageName;
                }

                List<LanguageViewModel> list
                     = _languageController.GetLanguages(filter);

                this.PopulateGridLanguage(list);
            }
            catch (Exception ex)
            {
                string message = this._resources.GetString(MessageBiblioE.MSG_GenericError.ToString());

                ShowErrorMessage(message);

                this.ScreenClose();
            }
        }

        /// <summary>
        /// Get the language by typed code text.
        /// </summary>
        /// <param name="sender">Textbox txtLanguageSearch.</param>
        /// <param name="e">Arguments of event.</param>
        private void txtLanguageSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                LanguageFilter filter = new LanguageFilter();

                string languageCode = txtLanguageSearch.Text;
                string languageName = txtLanguageNameSearch.Text;

                if (languageCode.Length > 2)
                {
                    filter.CultureCode = languageCode;
                    filter.Name = languageName;
                }

                List<LanguageViewModel> list
                    = _languageController.GetLanguages(filter);

                this.PopulateGridLanguage(list);
            }
            catch (Exception ex)
            {
                string message = this._resources.GetString(MessageBiblioE.MSG_GenericError.ToString());

                ShowErrorMessage(message);

                this.ScreenClose();
            }
        }
    }
}