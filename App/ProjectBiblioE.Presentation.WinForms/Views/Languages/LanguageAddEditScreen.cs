using System;

using MetroFramework.Forms;

using ProjectBiblioE.Domain.Enums;
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

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public LanguageAddEditScreen(LanguageController controller)
        {
            InitializeComponent();
            _languageController = controller;

            this.Text = "Novo Idioma";
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
            throw new NotImplementedException();
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
            LanguageViewModel view = new LanguageViewModel();
            view.CultureCode = txtLanguageCode.Text;
            view.Name = txtLanguageName.Text;

            this._languageController.Save(view);

            this.PrincipalScreen.ScreenLoad();

            PrincipalScreen.ScreenLoad();

            MessageScreen mess = new MessageScreen(MessageType.Success, "Idioma Salvo com Sucesso!");
            mess.ShowDialog();

            this.ScreenClose();
        }
    }
}