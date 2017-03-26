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

        private void btnGenreSave_Click(object sender, EventArgs e)
        {

        }
    }
}