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
using ProjectBiblioE.Domain.Contracts.Utils;
using System.Resources;
using ProjectBiblioE.CrossCutting.IoC;
using ProjectBiblioE.CrossCutting.Helpers;

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
            throw new NotImplementedException();
        }
    }
}