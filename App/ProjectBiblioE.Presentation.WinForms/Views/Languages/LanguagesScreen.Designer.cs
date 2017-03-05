namespace ProjectBiblioE.Presentation.WinForms.Views.Languages
{
    partial class LanguagesScreen
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
            this.grpBoxLanguageSearch = new System.Windows.Forms.GroupBox();
            this.txtLanguageNameSearch = new MetroFramework.Controls.MetroTextBox();
            this.lblLanguageName = new MetroFramework.Controls.MetroLabel();
            this.txtLanguageSearch = new MetroFramework.Controls.MetroTextBox();
            this.lblLanguageSearch = new MetroFramework.Controls.MetroLabel();
            this.BtnLanguageNew = new MetroFramework.Controls.MetroButton();
            this.gridLanguages = new MetroFramework.Controls.MetroGrid();
            this.grpBoxLanguageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLanguages)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxLanguageSearch
            // 
            this.grpBoxLanguageSearch.Controls.Add(this.txtLanguageNameSearch);
            this.grpBoxLanguageSearch.Controls.Add(this.lblLanguageName);
            this.grpBoxLanguageSearch.Controls.Add(this.txtLanguageSearch);
            this.grpBoxLanguageSearch.Controls.Add(this.lblLanguageSearch);
            this.grpBoxLanguageSearch.Location = new System.Drawing.Point(23, 63);
            this.grpBoxLanguageSearch.Name = "grpBoxLanguageSearch";
            this.grpBoxLanguageSearch.Size = new System.Drawing.Size(654, 82);
            this.grpBoxLanguageSearch.TabIndex = 0;
            this.grpBoxLanguageSearch.TabStop = false;
            this.grpBoxLanguageSearch.Text = "Busca";
            // 
            // txtLanguageNameSearch
            // 
            // 
            // 
            // 
            this.txtLanguageNameSearch.CustomButton.Image = null;
            this.txtLanguageNameSearch.CustomButton.Location = new System.Drawing.Point(538, 1);
            this.txtLanguageNameSearch.CustomButton.Name = "";
            this.txtLanguageNameSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLanguageNameSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLanguageNameSearch.CustomButton.TabIndex = 1;
            this.txtLanguageNameSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLanguageNameSearch.CustomButton.UseSelectable = true;
            this.txtLanguageNameSearch.CustomButton.Visible = false;
            this.txtLanguageNameSearch.Lines = new string[0];
            this.txtLanguageNameSearch.Location = new System.Drawing.Point(74, 49);
            this.txtLanguageNameSearch.MaxLength = 32767;
            this.txtLanguageNameSearch.Name = "txtLanguageNameSearch";
            this.txtLanguageNameSearch.PasswordChar = '\0';
            this.txtLanguageNameSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLanguageNameSearch.SelectedText = "";
            this.txtLanguageNameSearch.SelectionLength = 0;
            this.txtLanguageNameSearch.SelectionStart = 0;
            this.txtLanguageNameSearch.ShortcutsEnabled = true;
            this.txtLanguageNameSearch.Size = new System.Drawing.Size(560, 23);
            this.txtLanguageNameSearch.TabIndex = 3;
            this.txtLanguageNameSearch.UseSelectable = true;
            this.txtLanguageNameSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLanguageNameSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLanguageNameSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLanguageNameSearch_KeyUp);
            // 
            // lblLanguageName
            // 
            this.lblLanguageName.AutoSize = true;
            this.lblLanguageName.Location = new System.Drawing.Point(13, 49);
            this.lblLanguageName.Name = "lblLanguageName";
            this.lblLanguageName.Size = new System.Drawing.Size(46, 19);
            this.lblLanguageName.TabIndex = 2;
            this.lblLanguageName.Text = "Nome";
            // 
            // txtLanguageSearch
            // 
            // 
            // 
            // 
            this.txtLanguageSearch.CustomButton.Image = null;
            this.txtLanguageSearch.CustomButton.Location = new System.Drawing.Point(538, 1);
            this.txtLanguageSearch.CustomButton.Name = "";
            this.txtLanguageSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLanguageSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLanguageSearch.CustomButton.TabIndex = 1;
            this.txtLanguageSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLanguageSearch.CustomButton.UseSelectable = true;
            this.txtLanguageSearch.CustomButton.Visible = false;
            this.txtLanguageSearch.Lines = new string[0];
            this.txtLanguageSearch.Location = new System.Drawing.Point(74, 19);
            this.txtLanguageSearch.MaxLength = 32767;
            this.txtLanguageSearch.Name = "txtLanguageSearch";
            this.txtLanguageSearch.PasswordChar = '\0';
            this.txtLanguageSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLanguageSearch.SelectedText = "";
            this.txtLanguageSearch.SelectionLength = 0;
            this.txtLanguageSearch.SelectionStart = 0;
            this.txtLanguageSearch.ShortcutsEnabled = true;
            this.txtLanguageSearch.Size = new System.Drawing.Size(560, 23);
            this.txtLanguageSearch.TabIndex = 1;
            this.txtLanguageSearch.UseSelectable = true;
            this.txtLanguageSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLanguageSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLanguageSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLanguageSearch_KeyUp);
            // 
            // lblLanguageSearch
            // 
            this.lblLanguageSearch.AutoSize = true;
            this.lblLanguageSearch.Location = new System.Drawing.Point(18, 20);
            this.lblLanguageSearch.Name = "lblLanguageSearch";
            this.lblLanguageSearch.Size = new System.Drawing.Size(41, 19);
            this.lblLanguageSearch.TabIndex = 0;
            this.lblLanguageSearch.Text = "Code";
            // 
            // BtnLanguageNew
            // 
            this.BtnLanguageNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLanguageNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLanguageNew.Location = new System.Drawing.Point(115, 28);
            this.BtnLanguageNew.Name = "BtnLanguageNew";
            this.BtnLanguageNew.Size = new System.Drawing.Size(112, 23);
            this.BtnLanguageNew.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnLanguageNew.TabIndex = 1;
            this.BtnLanguageNew.Text = "Novo Idioma";
            this.BtnLanguageNew.UseSelectable = true;
            this.BtnLanguageNew.UseStyleColors = true;
            this.BtnLanguageNew.Click += new System.EventHandler(this.BtnLanguageNew_Click);
            // 
            // gridLanguages
            // 
            this.gridLanguages.AllowUserToAddRows = false;
            this.gridLanguages.AllowUserToDeleteRows = false;
            this.gridLanguages.AllowUserToResizeRows = false;
            this.gridLanguages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLanguages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridLanguages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridLanguages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridLanguages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLanguages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridLanguages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLanguages.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridLanguages.EnableHeadersVisualStyles = false;
            this.gridLanguages.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridLanguages.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridLanguages.Location = new System.Drawing.Point(23, 151);
            this.gridLanguages.MultiSelect = false;
            this.gridLanguages.Name = "gridLanguages";
            this.gridLanguages.ReadOnly = true;
            this.gridLanguages.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLanguages.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridLanguages.RowHeadersVisible = false;
            this.gridLanguages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridLanguages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLanguages.Size = new System.Drawing.Size(654, 226);
            this.gridLanguages.TabIndex = 2;
            this.gridLanguages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLanguages_CellContentClick);
            // 
            // LanguagesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.gridLanguages);
            this.Controls.Add(this.BtnLanguageNew);
            this.Controls.Add(this.grpBoxLanguageSearch);
            this.Name = "LanguagesScreen";
            this.Resizable = false;
            this.Text = "Idiomas";
            this.grpBoxLanguageSearch.ResumeLayout(false);
            this.grpBoxLanguageSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLanguages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxLanguageSearch;
        private MetroFramework.Controls.MetroTextBox txtLanguageSearch;
        private MetroFramework.Controls.MetroLabel lblLanguageSearch;
        private MetroFramework.Controls.MetroButton BtnLanguageNew;
        private MetroFramework.Controls.MetroGrid gridLanguages;
        private MetroFramework.Controls.MetroLabel lblLanguageName;
        private MetroFramework.Controls.MetroTextBox txtLanguageNameSearch;
    }
}