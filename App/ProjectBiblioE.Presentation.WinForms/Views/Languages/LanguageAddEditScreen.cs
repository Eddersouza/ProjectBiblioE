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

namespace ProjectBiblioE.Presentation.WinForms.Views.Languages
{
    /// <summary>
    /// Represents screen to add or edit languages.
    /// </summary>
    public partial class LanguageAddEditScreen : MetroForm, ScreenContract
    {
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public LanguageAddEditScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close Screen.
        /// </summary>
        public void ScreenClose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Load Screen.
        /// </summary>
        public void ScreenLoad()
        {
            throw new NotImplementedException();
        }
    }
}