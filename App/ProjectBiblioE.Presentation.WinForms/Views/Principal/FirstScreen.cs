using System;
using System.Resources;
using System.Windows.Forms;

using MetroFramework.Forms;

using ProjectBiblioE.CrossCutting.Resource;
using ProjectBiblioE.Presentation.WinForms.Views.Films;
using ProjectBiblioE.Presentation.WinForms.Views.Genres;
using ProjectBiblioE.Presentation.WinForms.Views.Languages;

namespace ProjectBiblioE.Presentation.WinForms.Views.Principal
{
    public partial class FirstScreen : MetroForm
    {
        private readonly ResourceManager _resources;

        public FirstScreen()
        {
            InitializeComponent();

            this._resources
                = new ResourceManager(typeof(Resources));
        }

        private void TileFilms_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            FilmsScreen filmsScreen = new FilmsScreen();
            filmsScreen.ShowDialog();

            this.Cursor = Cursors.Default;
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

            LanguagesScreen languagenScreen 
                = new LanguagesScreen(this._resources);
            languagenScreen.ScreenLoad();
            languagenScreen.ShowDialog();

            this.Cursor = Cursors.Default;
        }
    }
}