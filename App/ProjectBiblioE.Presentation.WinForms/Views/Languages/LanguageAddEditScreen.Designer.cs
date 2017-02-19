namespace ProjectBiblioE.Presentation.WinForms.Views.Languages
{
    partial class LanguageAddEditScreen
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
            this.lblCodeLanguage = new MetroFramework.Controls.MetroLabel();
            this.txtLanguageCode = new MetroFramework.Controls.MetroTextBox();
            this.lblLanguageName = new MetroFramework.Controls.MetroLabel();
            this.txtLanguageName = new MetroFramework.Controls.MetroTextBox();
            this.btnLanguageClear = new MetroFramework.Controls.MetroButton();
            this.btnLanguageSave = new MetroFramework.Controls.MetroButton();
            this.btnLanguageCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblCodeLanguage
            // 
            this.lblCodeLanguage.AutoSize = true;
            this.lblCodeLanguage.Location = new System.Drawing.Point(24, 68);
            this.lblCodeLanguage.Name = "lblCodeLanguage";
            this.lblCodeLanguage.Size = new System.Drawing.Size(53, 19);
            this.lblCodeLanguage.TabIndex = 0;
            this.lblCodeLanguage.Text = "Código";
            // 
            // txtLanguageCode
            // 
            // 
            // 
            // 
            this.txtLanguageCode.CustomButton.Image = null;
            this.txtLanguageCode.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtLanguageCode.CustomButton.Name = "";
            this.txtLanguageCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLanguageCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLanguageCode.CustomButton.TabIndex = 1;
            this.txtLanguageCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLanguageCode.CustomButton.UseSelectable = true;
            this.txtLanguageCode.CustomButton.Visible = false;
            this.txtLanguageCode.Lines = new string[0];
            this.txtLanguageCode.Location = new System.Drawing.Point(83, 67);
            this.txtLanguageCode.MaxLength = 32767;
            this.txtLanguageCode.Name = "txtLanguageCode";
            this.txtLanguageCode.PasswordChar = '\0';
            this.txtLanguageCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLanguageCode.SelectedText = "";
            this.txtLanguageCode.SelectionLength = 0;
            this.txtLanguageCode.SelectionStart = 0;
            this.txtLanguageCode.ShortcutsEnabled = true;
            this.txtLanguageCode.Size = new System.Drawing.Size(121, 23);
            this.txtLanguageCode.TabIndex = 1;
            this.txtLanguageCode.UseSelectable = true;
            this.txtLanguageCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLanguageCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblLanguageName
            // 
            this.lblLanguageName.AutoSize = true;
            this.lblLanguageName.Location = new System.Drawing.Point(210, 68);
            this.lblLanguageName.Name = "lblLanguageName";
            this.lblLanguageName.Size = new System.Drawing.Size(46, 19);
            this.lblLanguageName.TabIndex = 2;
            this.lblLanguageName.Text = "Nome";
            // 
            // txtLanguageName
            // 
            // 
            // 
            // 
            this.txtLanguageName.CustomButton.Image = null;
            this.txtLanguageName.CustomButton.Location = new System.Drawing.Point(343, 1);
            this.txtLanguageName.CustomButton.Name = "";
            this.txtLanguageName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLanguageName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLanguageName.CustomButton.TabIndex = 1;
            this.txtLanguageName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLanguageName.CustomButton.UseSelectable = true;
            this.txtLanguageName.CustomButton.Visible = false;
            this.txtLanguageName.Lines = new string[0];
            this.txtLanguageName.Location = new System.Drawing.Point(262, 68);
            this.txtLanguageName.MaxLength = 32767;
            this.txtLanguageName.Name = "txtLanguageName";
            this.txtLanguageName.PasswordChar = '\0';
            this.txtLanguageName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLanguageName.SelectedText = "";
            this.txtLanguageName.SelectionLength = 0;
            this.txtLanguageName.SelectionStart = 0;
            this.txtLanguageName.ShortcutsEnabled = true;
            this.txtLanguageName.Size = new System.Drawing.Size(365, 23);
            this.txtLanguageName.TabIndex = 3;
            this.txtLanguageName.UseSelectable = true;
            this.txtLanguageName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLanguageName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLanguageClear
            // 
            this.btnLanguageClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLanguageClear.Location = new System.Drawing.Point(105, 109);
            this.btnLanguageClear.Name = "btnLanguageClear";
            this.btnLanguageClear.Size = new System.Drawing.Size(75, 23);
            this.btnLanguageClear.TabIndex = 4;
            this.btnLanguageClear.Text = "Limpar";
            this.btnLanguageClear.UseSelectable = true;
            this.btnLanguageClear.Click += new System.EventHandler(this.btnLanguageClear_Click);
            // 
            // btnLanguageSave
            // 
            this.btnLanguageSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLanguageSave.Location = new System.Drawing.Point(186, 109);
            this.btnLanguageSave.Name = "btnLanguageSave";
            this.btnLanguageSave.Size = new System.Drawing.Size(75, 23);
            this.btnLanguageSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnLanguageSave.TabIndex = 5;
            this.btnLanguageSave.Text = "Salvar";
            this.btnLanguageSave.UseSelectable = true;
            this.btnLanguageSave.UseStyleColors = true;
            this.btnLanguageSave.Click += new System.EventHandler(this.btnLanguageSave_Click);
            // 
            // btnLanguageCancel
            // 
            this.btnLanguageCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLanguageCancel.Location = new System.Drawing.Point(24, 109);
            this.btnLanguageCancel.Name = "btnLanguageCancel";
            this.btnLanguageCancel.Size = new System.Drawing.Size(75, 23);
            this.btnLanguageCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.btnLanguageCancel.TabIndex = 6;
            this.btnLanguageCancel.Text = "Cancelar";
            this.btnLanguageCancel.UseSelectable = true;
            this.btnLanguageCancel.UseStyleColors = true;
            this.btnLanguageCancel.Click += new System.EventHandler(this.btnLanguageCancel_Click);
            // 
            // LanguageAddEditScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 152);
            this.Controls.Add(this.btnLanguageCancel);
            this.Controls.Add(this.btnLanguageSave);
            this.Controls.Add(this.btnLanguageClear);
            this.Controls.Add(this.txtLanguageName);
            this.Controls.Add(this.lblLanguageName);
            this.Controls.Add(this.txtLanguageCode);
            this.Controls.Add(this.lblCodeLanguage);
            this.Name = "LanguageAddEditScreen";
            this.Resizable = false;
            this.Text = "LanguageAddEditScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblCodeLanguage;
        private MetroFramework.Controls.MetroTextBox txtLanguageCode;
        private MetroFramework.Controls.MetroLabel lblLanguageName;
        private MetroFramework.Controls.MetroTextBox txtLanguageName;
        private MetroFramework.Controls.MetroButton btnLanguageClear;
        private MetroFramework.Controls.MetroButton btnLanguageSave;
        private MetroFramework.Controls.MetroButton btnLanguageCancel;
    }
}