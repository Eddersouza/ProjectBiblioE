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
            this.lblIdLanguage = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblIdLanguage
            // 
            this.lblIdLanguage.AutoSize = true;
            this.lblIdLanguage.Location = new System.Drawing.Point(24, 64);
            this.lblIdLanguage.Name = "lblIdLanguage";
            this.lblIdLanguage.Size = new System.Drawing.Size(53, 19);
            this.lblIdLanguage.TabIndex = 0;
            this.lblIdLanguage.Text = "Código";
            // 
            // LanguageAddEditScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.lblIdLanguage);
            this.Name = "LanguageAddEditScreen";
            this.Text = "LanguageAddEditScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblIdLanguage;
    }
}