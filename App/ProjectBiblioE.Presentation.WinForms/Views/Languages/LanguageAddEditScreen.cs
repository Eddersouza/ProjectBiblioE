using System;
using System.Resources;

using MetroFramework.Forms;

using ProjectBiblioE.Domain.Contracts.Utils;
using ProjectBiblioE.Domain.Enums;
using ProjectBiblioE.Domain.Exceptions;
using ProjectBiblioE.Presentation.WinForms.Contracts;
using ProjectBiblioE.Presentation.WinForms.Controllers;
using ProjectBiblioE.Presentation.WinForms.ViewModels;
using ProjectBiblioE.Presentation.WinForms.Views.Messages;

namespace ProjectBiblioE.Presentation.WinForms.Views.Languages
{
    /// <summary>
    /// Represents screen to add or edit languages.
    /// </summary>
    public partial class LanguageAddEditScreen : MetroForm, ScreenContract
    {
        private readonly LanguageController _languageController;
        private readonly LanguageViewModel _languageView;
        private readonly MessageContract _messageContract;
        private readonly ResourceManager _resources;

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public LanguageAddEditScreen(
            LanguageViewModel languageView,
            LanguageController controller,
            MessageContract message,
            ResourceManager resources)
        {
            InitializeComponent();

            _languageView = languageView;
            _languageController = controller;
            _messageContract = message;
            _resources = resources;
        }

        /// <summary>
        /// Instance of principal screen(to execute actions).
        /// </summary>
        public ScreenContract PrincipalScreen
        {
            get; set;
        }

        /// <summary>
        /// Close Screen.
        /// </summary>
        public void ScreenClose()
        {
            this.Close();
        }

        /// <summary>
        /// Load Screen.
        /// </summary>
        public void ScreenLoad()
        {
            if (this._languageView == null)
            {
                this.Text = _resources.GetString(LabelText.LanguageNew.ToString());
            }
            else
            {
                this.Text = _resources.GetString(LabelText.LanguageEdit.ToString());

                this.txtLanguageCode.Text = this._languageView.CultureCode;
                this.txtLanguageName.Text = this._languageView.Name;

                this.txtLanguageCode.Enabled = false;
            }
        }

        /// <summary>
        /// Event click of Cancel.
        /// </summary>
        /// <param name="sender">Button Cancel.</param>
        /// <param name="e">Arguments of event.</param>
        private void btnLanguageCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event click of clear.
        /// </summary>
        /// <param name="sender">Button btnLanguageClear.</param>
        /// <param name="e">Event arguments</param>
        private void btnLanguageClear_Click(object sender, EventArgs e)
        {
            this.txtLanguageCode.Clear();
            this.txtLanguageName.Clear();
        }

        /// <summary>
        /// Event click of save.
        /// </summary>
        /// <param name="sender">Button btnLanguageSave.</param>
        /// <param name="e">Event arguments;</param>
        private void btnLanguageSave_Click(object sender, EventArgs e)
        {
            try
            {
                LanguageViewModel view = getDataFromScreen();

                if (this._languageView == null)
                {
                    this._languageController.Save(view);
                }
                else
                {
                    this._languageController.SaveEdited(view);
                }

                this.PrincipalScreen.ScreenLoad();

                PrincipalScreen.ScreenLoad();

                ShowSuccessMessage(view.CultureCode);

                this.ScreenClose();
            }
            catch (BiblioEException ex)
            {
                ShowAlertMessage(ex.Message);

                this.ScreenClose();
            }
            catch (Exception)
            {
                // TODO: create log
                string message = this._resources.GetString(MessageBiblioE.MSG_GenericError.ToString());

                ShowErrorMessage(message);

                this.ScreenClose();
            }
        }

        /// <summary>
        /// Get values from screen.
        /// </summary>
        /// <returns></returns>
        private LanguageViewModel getDataFromScreen()
        {
            LanguageViewModel view = new LanguageViewModel();
            view.CultureCode = txtLanguageCode.Text;
            view.Name = txtLanguageName.Text;

            return view;
        }

        /// <summary>
        /// Show alert message.
        /// </summary>
        /// <param name="message">Message to alert./param>
        private void ShowAlertMessage(string message)
        {
            MessageScreen messageAlert
                    = new MessageScreen(
                        MessageType.Alert,
                        message);

            messageAlert.ShowDialog();
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
        /// Show message sucess.
        /// </summary>
        /// <param name="cultureCode">Culture code to message.</param>
        private void ShowSuccessMessage(string cultureCode)
        {
            string messageSuccessSaved
                    = this._messageContract
                        .MountMessage(
                        MessageBiblioE.MSG_Success_Saved,
                        _resources.GetString(LabelText.Language.ToString()),
                        cultureCode);

            MessageScreen messageSuccess
                = new MessageScreen(MessageType.Success, messageSuccessSaved);
            messageSuccess.ShowDialog();
        }        
    }
}