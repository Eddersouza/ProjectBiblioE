using System.Collections.Generic;
using System.Windows.Forms;

using MetroFramework.Forms;

using ProjectBiblioE.CrossCutting.IoC;
using ProjectBiblioE.CrossCutting.Resource;
using ProjectBiblioE.Presentation.WinForms.Contracts;
using ProjectBiblioE.Presentation.WinForms.Controllers;
using ProjectBiblioE.Presentation.WinForms.Utils.Extensions;
using ProjectBiblioE.Presentation.WinForms.ViewModels;
using ProjectBiblioE.Domain.Contracts.Filters;

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

        /// <summary>
        /// Default constructor.
        /// </summary>
        public LanguagesScreen()
        {
            InitializeComponent();
            CompositionRoot.Wire(new IoCModule());
            _languageController = CompositionRoot.Resolve<LanguageController>();
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
            LanguageFilter filter = new LanguageFilter();
            List<LanguageViewModel> list
                = _languageController.GetLanguages(filter);

            this.PopulateGridLanguage(list);
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

            gridLanguages.CreateColumnsByView(typeof(LanguageViewModel));
            gridLanguages.AddEditColumn(Resources.Language_Module, ColumnNameEdit);
            gridLanguages.AddRemoveColumn(Resources.Language_Module, ColumnNameRemove);
        }

        /// <summary>
        /// Get the language by typed text.
        /// </summary>
        /// <param name="sender">Textbox txtLanguageSearch.</param>
        /// <param name="e">Arguments of event.</param>
        private void txtLanguageSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtLanguageSearch.Text.Length > 3)
            {

            }
        }
    }
}