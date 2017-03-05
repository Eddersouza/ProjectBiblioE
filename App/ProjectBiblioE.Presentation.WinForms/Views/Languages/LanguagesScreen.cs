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
            catch (Exception)
            {
                // TODO: create log
                string message = this._resources.GetString(MessageBiblioE.MSG_GenericError.ToString());

                ShowMessageError(message);

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
                    null,
                    _languageController,
                    _messageContract,
                    _resources);

            languageNewScreen.PrincipalScreen = this;
            languageNewScreen.ScreenLoad();

            languageNewScreen.ShowDialog();
        }

        /// <summary>
        /// Get language For Row.
        /// </summary>
        /// <param name="row">Row with language.</param>
        /// <returns>View with data language.</returns>
        private LanguageViewModel GetLanguageForRow(DataGridViewRow row)
        {
            string codeCulture = row.Cells["CultureCode"].Value.ToString();
            string name = row.Cells["Name"].Value.ToString();

            LanguageViewModel language = new LanguageViewModel
            {
                CultureCode = codeCulture,
                Name = name
            };

            return language;
        }

        /// <summary>
        /// Event click on Button of grid.
        /// </summary>
        /// <param name="sender">Grid Language.</param>
        /// <param name="e">Event Arguments.</param>
        private void gridLanguages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                    e.RowIndex >= 0)
                {
                    var row = senderGrid.Rows[e.RowIndex];

                    var language = this.GetLanguageForRow(row);

                    int columnIndex = senderGrid.CurrentCell.ColumnIndex;
                    string colName = senderGrid.Columns[columnIndex].Name;

                    if (colName.Equals(ColumnNameEdit)) this.OpenEditForm(language);

                    if (colName.Equals(ColumnNameRemove)) this.RemoveLanguage(language);
                }
            }
            catch (Exception)
            {
                // TODO: create log
                string message = this._resources.GetString(MessageBiblioE.MSG_GenericError.ToString());

                ShowMessageError(message);

                this.ScreenClose();
            }
        }

        /// <summary>
        /// Open edit form with selected language
        /// </summary>
        /// <param name="language">View Language</param>
        private void OpenEditForm(LanguageViewModel language)
        {
            LanguageAddEditScreen languageEditScreen
                = new LanguageAddEditScreen(
                    language,
                    _languageController,
                    _messageContract,
                    _resources);

            languageEditScreen.PrincipalScreen = this;
            languageEditScreen.ScreenLoad();

            languageEditScreen.ShowDialog();
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
        /// Remove Selected Language
        /// </summary>
        /// <param name="language">View Language</param>
        private void RemoveLanguage(LanguageViewModel language)
        {
            try
            {
                string messageConfirm = this._messageContract.MountMessage(
                    MessageBiblioE.MSG_Do_You_Want_Delete,
                    LabelText.Language, language.CultureCode);

                DialogResult messageResult = ShowMessageConfirm(messageConfirm);

                if (messageResult == DialogResult.Yes)
                {
                    this._languageController.Delete(language.CultureCode);

                    this.ScreenLoad();

                    string messageSuccess = this._messageContract.MountMessage(
                        MessageBiblioE.MSG_Sussessfully_Deleted,
                        LabelText.Language, language.CultureCode);

                    ShowMessageSuccess(messageSuccess);
                }
            }
            catch (Exception)
            {
                // TODO: create log
                string message = this._resources.GetString(MessageBiblioE.MSG_GenericError.ToString());

                ShowMessageError(message);

                this.ScreenClose();
            }
        }

        /// <summary>
        /// Show confirm message.
        /// </summary>
        /// <param name="message">Nessage to confirm.</param>
        /// <returns>Result of confirm.</returns>
        private DialogResult ShowMessageConfirm(string message)
        {
            MessageScreen messageConfirmDelete
                   = new MessageScreen(
                       MessageType.Confirm,
                       message);

            messageConfirmDelete.ShowDialog();

            return MessageScreen.BtnResult;
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
        /// Show message success.
        /// </summary>
        /// <param name="message">Message to success.</param>
        private void ShowMessageSuccess(string message)
        {
            MessageScreen messageError
                    = new MessageScreen(
                        MessageType.Success,
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
            catch (Exception)
            {
                // TODO: create log
                string message = this._resources.GetString(MessageBiblioE.MSG_GenericError.ToString());

                ShowMessageError(message);

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