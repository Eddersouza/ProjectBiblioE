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
            this.imgMessage = new System.Windows.Forms.PictureBox();
            this.lblMessageText = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imgMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMessage
            // 
            this.imgMessage.Location = new System.Drawing.Point(23, 63);
            this.imgMessage.Name = "imgMessage";
            this.imgMessage.Size = new System.Drawing.Size(128, 128);
            this.imgMessage.TabIndex = 0;
            this.imgMessage.TabStop = false;
            // 
            // lblMessageText
            // 
            this.lblMessageText.AutoSize = true;
            this.lblMessageText.Location = new System.Drawing.Point(157, 63);
            this.lblMessageText.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblMessageText.Name = "lblMessageText";
            this.lblMessageText.Size = new System.Drawing.Size(0, 0);
            this.lblMessageText.TabIndex = 1;
            // 
            // MessageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.lblMessageText);
            this.Controls.Add(this.imgMessage);
            this.Name = "MessageScreen";
            this.Text = "MessageScreen";
            ((System.ComponentModel.ISupportInitialize)(this.imgMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMessage;
        private MetroFramework.Controls.MetroLabel lblMessageText;
    }
}