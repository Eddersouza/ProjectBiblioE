namespace ProjectBiblioE.Presentation.WinForms.Views.Messages
{
    partial class MessageScreen
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
            this.components = new System.ComponentModel.Container();
            this.metroStyleManagerMessageScreen = new MetroFramework.Components.MetroStyleManager(this.components);
            this.imgMessageScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerMessageScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMessageScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManagerMessageScreen
            // 
            this.metroStyleManagerMessageScreen.Owner = null;
            // 
            // imgMessageScreen
            // 
            this.imgMessageScreen.Location = new System.Drawing.Point(23, 63);
            this.imgMessageScreen.Name = "imgMessageScreen";
            this.imgMessageScreen.Size = new System.Drawing.Size(128, 128);
            this.imgMessageScreen.TabIndex = 0;
            this.imgMessageScreen.TabStop = false;
            // 
            // MessageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.imgMessageScreen);
            this.Name = "MessageScreen";
            this.Text = "MessageScreen";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerMessageScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMessageScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManagerMessageScreen;
        private System.Windows.Forms.PictureBox imgMessageScreen;
    }
}