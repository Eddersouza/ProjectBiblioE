using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;

using ProjectBiblioE.Presentation.WinForms.Contracts;
using ProjectBiblioE.Presentation.WinForms.Controllers;
using ProjectBiblioE.Presentation.WinForms.ViewModels;
using ProjectBiblioE.Domain.Contracts.Utils;
using System.Resources;
using ProjectBiblioE.Domain.Enums;
using ProjectBiblioE.Domain.Exceptions;
using ProjectBiblioE.Presentation.WinForms.Views.Messages;

namespace ProjectBiblioE.Presentation.WinForms.Views.Genres
{
    /// <summary>
    /// Represent Screen to add or change genre.
    /// </summary>
    public partial class GenreAddEditScreen : MetroForm, ScreenContract
    {
        private readonly GenreController _genreController;
        private readonly GenreViewModel _genreView;
        private readonly MessageContract _messageContract;
        private readonly ResourceManager _resources;

        /// <summary>
        /// Defaut Contructor.
        /// </summary>
        /// <param name="genreView">Genre View.</param>
        /// <param name="genreController">Genre controller.</param>
        /// <param name="message">Instance of message.</param>
        /// <param name="resources">Instance Resources.</param>
        public GenreAddEditScreen(
            GenreViewModel genreView,
            GenreController genreController,
            MessageContract message,
            ResourceManager resources)
        {
            InitializeComponent();

            _genreView = genreView;
            _genreController = genreController;
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
            this.Text = _resources.GetString(LabelText.GenreNew.ToString());
            this.txtHiddenGenreId.Text = "0";
        }

        /// <summary>
        /// Event click of Cancel.
        /// </summary>
        /// <param name="sender">Button Cancel.</param>
        /// <param name="e">Arguments of event.</param>
        private void btnGenreCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event click of clear.
        /// </summary>
        /// <param name="sender">Button btnGenreClear.</param>
        /// <param name="e">Event arguments</param>
        private void btnGenreClear_Click(object sender, EventArgs e)
        {
            this.txtGenreName.Clear();
            this.txtHiddenGenreId.Text = "0";
        }

        /// <summary>
        /// Event of click button save.
        /// </summary>
        /// <param name="sender">Button Save.</param>
        /// <param name="e">Event argument.</param>
        private void btnGenreSave_Click(object sender, EventArgs e)
        {
            try
            {
                GenreViewModel view = getDataFromScreen();
                
                this._genreController.Save(view);

                this.PrincipalScreen.ScreenLoad();
                
                ShowSuccessMessage(view.Name);

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
        private GenreViewModel getDataFromScreen()
        {
            GenreViewModel view = new GenreViewModel();

            view.Name = txtGenreName.Text;

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
                        _resources.GetString(LabelText.Genre.ToString()),
                        cultureCode);

            MessageScreen messageSuccess
                = new MessageScreen(MessageType.Success, messageSuccessSaved);
            messageSuccess.ShowDialog();
        }
    }
}