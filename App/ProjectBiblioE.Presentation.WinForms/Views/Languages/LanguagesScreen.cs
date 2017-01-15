using MetroFramework.Forms;
using ProjectBiblioE.Presentation.WinForms.Contracts;
using ProjectBiblioE.Presentation.WinForms.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBiblioE.Presentation.WinForms.Views.Languages
{
    public partial class LanguagesScreen : MetroForm, ScreenContract
    {
        public LanguagesScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close screeen
        /// </summary>
        public void ScreenClose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Load screen data
        /// </summary>
        public void ScreenLoad()
        {
            List<LanguageViewModel> list = new List<LanguageViewModel>();
            this.gridLanguages.DataSource = list;
        }
    }
}
