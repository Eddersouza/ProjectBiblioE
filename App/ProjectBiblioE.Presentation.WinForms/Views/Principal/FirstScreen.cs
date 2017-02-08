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
using ProjectBiblioE.Presentation.WinForms.Views.Genres;
using ProjectBiblioE.Presentation.WinForms.Views.Languages;
using ProjectBiblioE.Presentation.WinForms.Views.Films;

namespace ProjectBiblioE.Presentation.WinForms.Views.Principal
{
    public partial class FirstScreen : MetroForm
    {
        public FirstScreen()
        {
            InitializeComponent();
        }

        private void TileGenres_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            GenresScreen genresScreen = new GenresScreen();
            genresScreen.ShowDialog();

            this.Cursor = Cursors.Default;
        }

        private void TileLanguages_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            LanguagesScreen languagenScreen = new LanguagesScreen();
            languagenScreen.ScreenLoad();
            languagenScreen.ShowDialog();

            this.Cursor = Cursors.Default;
        }

        private void TileFilms_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            FilmsScreen filmsScreen = new FilmsScreen();
            filmsScreen.ShowDialog();

            this.Cursor = Cursors.Default;
        }
    }
}