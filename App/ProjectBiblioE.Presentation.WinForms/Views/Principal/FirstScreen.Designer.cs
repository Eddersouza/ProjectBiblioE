using ProjectBiblioE.CrossCutting.Resource;

namespace ProjectBiblioE.Presentation.WinForms.Views.Principal
{
    partial class FirstScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstScreen));
            this.TileGenres = new MetroFramework.Controls.MetroTile();
            this.TileLanguages = new MetroFramework.Controls.MetroTile();
            this.TileFilms = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // TileGenres
            // 
            this.TileGenres.ActiveControl = null;
            this.TileGenres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TileGenres.Location = new System.Drawing.Point(23, 72);
            this.TileGenres.Name = "TileGenres";
            this.TileGenres.Size = new System.Drawing.Size(125, 125);
            this.TileGenres.TabIndex = 0;
            this.TileGenres.Text = "Gêneros";
            this.TileGenres.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TileGenres.TileImage = ((System.Drawing.Image)(resources.GetObject("TileGenres.TileImage")));
            this.TileGenres.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileGenres.UseSelectable = true;
            this.TileGenres.UseTileImage = true;
            this.TileGenres.Click += new System.EventHandler(this.TileGenres_Click);
            // 
            // TileLanguages
            // 
            this.TileLanguages.ActiveControl = null;
            this.TileLanguages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TileLanguages.Location = new System.Drawing.Point(154, 72);
            this.TileLanguages.Name = "TileLanguages";
            this.TileLanguages.Size = new System.Drawing.Size(125, 125);
            this.TileLanguages.TabIndex = 1;
            this.TileLanguages.Text = "Idiomas";
            this.TileLanguages.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TileLanguages.TileImage = ((System.Drawing.Image)(resources.GetObject("TileLanguages.TileImage")));
            this.TileLanguages.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileLanguages.UseSelectable = true;
            this.TileLanguages.UseTileImage = true;
            this.TileLanguages.Click += new System.EventHandler(this.TileLanguages_Click);
            // 
            // TileFilms
            // 
            this.TileFilms.ActiveControl = null;
            this.TileFilms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TileFilms.Location = new System.Drawing.Point(285, 72);
            this.TileFilms.Name = "TileFilms";
            this.TileFilms.Size = new System.Drawing.Size(125, 125);
            this.TileFilms.TabIndex = 2;
            this.TileFilms.Text = "Filmes";
            this.TileFilms.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TileFilms.TileImage = ((System.Drawing.Image)(resources.GetObject("TileFilms.TileImage")));
            this.TileFilms.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileFilms.UseSelectable = true;
            this.TileFilms.UseTileImage = true;
            this.TileFilms.Click += new System.EventHandler(this.TileFilms_Click);
            // 
            // FirstScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 223);
            this.Controls.Add(this.TileFilms);
            this.Controls.Add(this.TileLanguages);
            this.Controls.Add(this.TileGenres);
            this.Name = "FirstScreen";
            this.Text = "BiblioE";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile TileGenres;
        private MetroFramework.Controls.MetroTile TileLanguages;
        private MetroFramework.Controls.MetroTile TileFilms;
    }
}