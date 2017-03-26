namespace ProjectBiblioE.Presentation.WinForms.Views.Genres
{
    partial class GenreAddEditScreen
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
            this.txtGenreName = new MetroFramework.Controls.MetroTextBox();
            this.lblGenreName = new MetroFramework.Controls.MetroLabel();
            this.btnGenreCancel = new MetroFramework.Controls.MetroButton();
            this.btnGenreSave = new MetroFramework.Controls.MetroButton();
            this.btnGenreClear = new MetroFramework.Controls.MetroButton();
            this.txtHiddenGenreId = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // txtGenreName
            // 
            // 
            // 
            // 
            this.txtGenreName.CustomButton.Image = null;
            this.txtGenreName.CustomButton.Location = new System.Drawing.Point(522, 1);
            this.txtGenreName.CustomButton.Name = "";
            this.txtGenreName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGenreName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGenreName.CustomButton.TabIndex = 1;
            this.txtGenreName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGenreName.CustomButton.UseSelectable = true;
            this.txtGenreName.CustomButton.Visible = false;
            this.txtGenreName.Lines = new string[0];
            this.txtGenreName.Location = new System.Drawing.Point(83, 67);
            this.txtGenreName.MaxLength = 32767;
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.PasswordChar = '\0';
            this.txtGenreName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGenreName.SelectedText = "";
            this.txtGenreName.SelectionLength = 0;
            this.txtGenreName.SelectionStart = 0;
            this.txtGenreName.ShortcutsEnabled = true;
            this.txtGenreName.Size = new System.Drawing.Size(544, 23);
            this.txtGenreName.TabIndex = 5;
            this.txtGenreName.UseSelectable = true;
            this.txtGenreName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGenreName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Location = new System.Drawing.Point(24, 68);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(46, 19);
            this.lblGenreName.TabIndex = 4;
            this.lblGenreName.Text = "Nome";
            // 
            // btnGenreCancel
            // 
            this.btnGenreCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenreCancel.Location = new System.Drawing.Point(24, 109);
            this.btnGenreCancel.Name = "btnGenreCancel";
            this.btnGenreCancel.Size = new System.Drawing.Size(75, 23);
            this.btnGenreCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.btnGenreCancel.TabIndex = 9;
            this.btnGenreCancel.Text = "Cancelar";
            this.btnGenreCancel.UseSelectable = true;
            this.btnGenreCancel.UseStyleColors = true;
            this.btnGenreCancel.Click += new System.EventHandler(this.btnGenreCancel_Click);
            // 
            // btnGenreSave
            // 
            this.btnGenreSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenreSave.Location = new System.Drawing.Point(186, 109);
            this.btnGenreSave.Name = "btnGenreSave";
            this.btnGenreSave.Size = new System.Drawing.Size(75, 23);
            this.btnGenreSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnGenreSave.TabIndex = 8;
            this.btnGenreSave.Text = "Salvar";
            this.btnGenreSave.UseSelectable = true;
            this.btnGenreSave.UseStyleColors = true;
            this.btnGenreSave.Click += new System.EventHandler(this.btnGenreSave_Click);
            // 
            // btnGenreClear
            // 
            this.btnGenreClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenreClear.Location = new System.Drawing.Point(105, 109);
            this.btnGenreClear.Name = "btnGenreClear";
            this.btnGenreClear.Size = new System.Drawing.Size(75, 23);
            this.btnGenreClear.TabIndex = 7;
            this.btnGenreClear.Text = "Limpar";
            this.btnGenreClear.UseSelectable = true;
            this.btnGenreClear.Click += new System.EventHandler(this.btnGenreClear_Click);
            // 
            // txtHiddenGenreId
            // 
            // 
            // 
            // 
            this.txtHiddenGenreId.CustomButton.Image = null;
            this.txtHiddenGenreId.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtHiddenGenreId.CustomButton.Name = "";
            this.txtHiddenGenreId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHiddenGenreId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHiddenGenreId.CustomButton.TabIndex = 1;
            this.txtHiddenGenreId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHiddenGenreId.CustomButton.UseSelectable = true;
            this.txtHiddenGenreId.CustomButton.Visible = false;
            this.txtHiddenGenreId.Lines = new string[0];
            this.txtHiddenGenreId.Location = new System.Drawing.Point(267, 109);
            this.txtHiddenGenreId.MaxLength = 32767;
            this.txtHiddenGenreId.Name = "txtHiddenGenreId";
            this.txtHiddenGenreId.PasswordChar = '\0';
            this.txtHiddenGenreId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHiddenGenreId.SelectedText = "";
            this.txtHiddenGenreId.SelectionLength = 0;
            this.txtHiddenGenreId.SelectionStart = 0;
            this.txtHiddenGenreId.ShortcutsEnabled = true;
            this.txtHiddenGenreId.Size = new System.Drawing.Size(75, 23);
            this.txtHiddenGenreId.TabIndex = 10;
            this.txtHiddenGenreId.UseSelectable = true;
            this.txtHiddenGenreId.Visible = false;
            this.txtHiddenGenreId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHiddenGenreId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GenreAddEditScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 152);
            this.Controls.Add(this.txtHiddenGenreId);
            this.Controls.Add(this.btnGenreCancel);
            this.Controls.Add(this.btnGenreSave);
            this.Controls.Add(this.btnGenreClear);
            this.Controls.Add(this.txtGenreName);
            this.Controls.Add(this.lblGenreName);
            this.Name = "GenreAddEditScreen";
            this.Text = "GenreAddEditScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtGenreName;
        private MetroFramework.Controls.MetroLabel lblGenreName;
        private MetroFramework.Controls.MetroButton btnGenreCancel;
        private MetroFramework.Controls.MetroButton btnGenreSave;
        private MetroFramework.Controls.MetroButton btnGenreClear;
        private MetroFramework.Controls.MetroTextBox txtHiddenGenreId;
    }
}