namespace ProjectBiblioE.Presentation.WinForms.Views.Genres
{
    partial class GenresScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnGenreNew = new MetroFramework.Controls.MetroButton();
            this.grpGenreSearch = new System.Windows.Forms.GroupBox();
            this.txtGenreNameSearch = new MetroFramework.Controls.MetroTextBox();
            this.lblGenreNameSearch = new MetroFramework.Controls.MetroLabel();
            this.gridGenres = new MetroFramework.Controls.MetroGrid();
            this.grpGenreSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGenres)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGenreNew
            // 
            this.BtnGenreNew.Location = new System.Drawing.Point(115, 28);
            this.BtnGenreNew.Name = "BtnGenreNew";
            this.BtnGenreNew.Size = new System.Drawing.Size(112, 23);
            this.BtnGenreNew.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnGenreNew.TabIndex = 0;
            this.BtnGenreNew.Text = "Novo Gênero";
            this.BtnGenreNew.UseSelectable = true;
            this.BtnGenreNew.UseStyleColors = true;
            // 
            // grpGenreSearch
            // 
            this.grpGenreSearch.Controls.Add(this.txtGenreNameSearch);
            this.grpGenreSearch.Controls.Add(this.lblGenreNameSearch);
            this.grpGenreSearch.Location = new System.Drawing.Point(23, 62);
            this.grpGenreSearch.Name = "grpGenreSearch";
            this.grpGenreSearch.Size = new System.Drawing.Size(654, 61);
            this.grpGenreSearch.TabIndex = 1;
            this.grpGenreSearch.TabStop = false;
            this.grpGenreSearch.Text = "Busca";
            // 
            // txtGenreNameSearch
            // 
            // 
            // 
            // 
            this.txtGenreNameSearch.CustomButton.Image = null;
            this.txtGenreNameSearch.CustomButton.Location = new System.Drawing.Point(538, 1);
            this.txtGenreNameSearch.CustomButton.Name = "";
            this.txtGenreNameSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGenreNameSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGenreNameSearch.CustomButton.TabIndex = 1;
            this.txtGenreNameSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGenreNameSearch.CustomButton.UseSelectable = true;
            this.txtGenreNameSearch.CustomButton.Visible = false;
            this.txtGenreNameSearch.Lines = new string[0];
            this.txtGenreNameSearch.Location = new System.Drawing.Point(74, 19);
            this.txtGenreNameSearch.MaxLength = 32767;
            this.txtGenreNameSearch.Name = "txtGenreNameSearch";
            this.txtGenreNameSearch.PasswordChar = '\0';
            this.txtGenreNameSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGenreNameSearch.SelectedText = "";
            this.txtGenreNameSearch.SelectionLength = 0;
            this.txtGenreNameSearch.SelectionStart = 0;
            this.txtGenreNameSearch.ShortcutsEnabled = true;
            this.txtGenreNameSearch.Size = new System.Drawing.Size(560, 23);
            this.txtGenreNameSearch.TabIndex = 1;
            this.txtGenreNameSearch.UseSelectable = true;
            this.txtGenreNameSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGenreNameSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGenreNameSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGenreNameSearch_KeyUp);
            // 
            // lblGenreNameSearch
            // 
            this.lblGenreNameSearch.AutoSize = true;
            this.lblGenreNameSearch.Location = new System.Drawing.Point(18, 20);
            this.lblGenreNameSearch.Name = "lblGenreNameSearch";
            this.lblGenreNameSearch.Size = new System.Drawing.Size(46, 19);
            this.lblGenreNameSearch.TabIndex = 0;
            this.lblGenreNameSearch.Text = "Nome";
            // 
            // gridGenres
            // 
            this.gridGenres.AllowUserToAddRows = false;
            this.gridGenres.AllowUserToDeleteRows = false;
            this.gridGenres.AllowUserToResizeRows = false;
            this.gridGenres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridGenres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridGenres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridGenres.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridGenres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridGenres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridGenres.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridGenres.EnableHeadersVisualStyles = false;
            this.gridGenres.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridGenres.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridGenres.Location = new System.Drawing.Point(23, 129);
            this.gridGenres.MultiSelect = false;
            this.gridGenres.Name = "gridGenres";
            this.gridGenres.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridGenres.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridGenres.RowHeadersVisible = false;
            this.gridGenres.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridGenres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridGenres.Size = new System.Drawing.Size(654, 248);
            this.gridGenres.TabIndex = 2;
            // 
            // GenresScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.gridGenres);
            this.Controls.Add(this.grpGenreSearch);
            this.Controls.Add(this.BtnGenreNew);
            this.Name = "GenresScreen";
            this.Text = "Gêneros";
            this.grpGenreSearch.ResumeLayout(false);
            this.grpGenreSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGenres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnGenreNew;
        private System.Windows.Forms.GroupBox grpGenreSearch;
        private MetroFramework.Controls.MetroLabel lblGenreNameSearch;
        private MetroFramework.Controls.MetroTextBox txtGenreNameSearch;
        private MetroFramework.Controls.MetroGrid gridGenres;
    }
}