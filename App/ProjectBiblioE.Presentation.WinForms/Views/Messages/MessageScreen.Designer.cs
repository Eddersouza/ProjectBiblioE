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
            this.pnlMessageOk = new MetroFramework.Controls.MetroPanel();
            this.btnMessageYes = new MetroFramework.Controls.MetroButton();
            this.btnMessageOK = new MetroFramework.Controls.MetroButton();
            this.btnMessageNo = new MetroFramework.Controls.MetroButton();
            this.pnlMessageYesNo = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.imgMessage)).BeginInit();
            this.pnlMessageOk.SuspendLayout();
            this.pnlMessageYesNo.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgMessage
            // 
            this.imgMessage.Location = new System.Drawing.Point(23, 63);
            this.imgMessage.Name = "imgMessage";
            this.imgMessage.Size = new System.Drawing.Size(85, 85);
            this.imgMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            // pnlMessageOk
            // 
            this.pnlMessageOk.Controls.Add(this.btnMessageOK);
            this.pnlMessageOk.HorizontalScrollbarBarColor = true;
            this.pnlMessageOk.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMessageOk.HorizontalScrollbarSize = 10;
            this.pnlMessageOk.Location = new System.Drawing.Point(23, 154);
            this.pnlMessageOk.Name = "pnlMessageOk";
            this.pnlMessageOk.Size = new System.Drawing.Size(654, 62);
            this.pnlMessageOk.TabIndex = 2;
            this.pnlMessageOk.VerticalScrollbarBarColor = true;
            this.pnlMessageOk.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMessageOk.VerticalScrollbarSize = 10;
            // 
            // btnMessageYes
            // 
            this.btnMessageYes.Location = new System.Drawing.Point(482, 22);
            this.btnMessageYes.Name = "btnMessageYes";
            this.btnMessageYes.Size = new System.Drawing.Size(75, 23);
            this.btnMessageYes.TabIndex = 3;
            this.btnMessageYes.Text = "Sim";
            this.btnMessageYes.UseSelectable = true;
            this.btnMessageYes.Click += new System.EventHandler(this.btnMessageYes_Click);
            // 
            // btnMessageOK
            // 
            this.btnMessageOK.Location = new System.Drawing.Point(563, 22);
            this.btnMessageOK.Name = "btnMessageOK";
            this.btnMessageOK.Size = new System.Drawing.Size(75, 23);
            this.btnMessageOK.TabIndex = 2;
            this.btnMessageOK.Text = "OK";
            this.btnMessageOK.UseSelectable = true;
            this.btnMessageOK.Click += new System.EventHandler(this.btnMessageOK_Click);
            // 
            // btnMessageNo
            // 
            this.btnMessageNo.Location = new System.Drawing.Point(563, 22);
            this.btnMessageNo.Name = "btnMessageNo";
            this.btnMessageNo.Size = new System.Drawing.Size(75, 23);
            this.btnMessageNo.TabIndex = 4;
            this.btnMessageNo.Text = "Não";
            this.btnMessageNo.UseSelectable = true;
            this.btnMessageNo.Click += new System.EventHandler(this.btnMessageNo_Click);
            // 
            // pnlMessageYesNo
            // 
            this.pnlMessageYesNo.Controls.Add(this.btnMessageNo);
            this.pnlMessageYesNo.Controls.Add(this.btnMessageYes);
            this.pnlMessageYesNo.HorizontalScrollbarBarColor = true;
            this.pnlMessageYesNo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMessageYesNo.HorizontalScrollbarSize = 10;
            this.pnlMessageYesNo.Location = new System.Drawing.Point(23, 154);
            this.pnlMessageYesNo.Name = "pnlMessageYesNo";
            this.pnlMessageYesNo.Size = new System.Drawing.Size(654, 62);
            this.pnlMessageYesNo.TabIndex = 3;
            this.pnlMessageYesNo.VerticalScrollbarBarColor = true;
            this.pnlMessageYesNo.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMessageYesNo.VerticalScrollbarSize = 10;
            // 
            // MessageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 232);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMessageYesNo);
            this.Controls.Add(this.pnlMessageOk);
            this.Controls.Add(this.lblMessageText);
            this.Controls.Add(this.imgMessage);
            this.Name = "MessageScreen";
            this.Resizable = false;
            this.Text = "MessageScreen";
            ((System.ComponentModel.ISupportInitialize)(this.imgMessage)).EndInit();
            this.pnlMessageOk.ResumeLayout(false);
            this.pnlMessageYesNo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMessage;
        private MetroFramework.Controls.MetroLabel lblMessageText;
        private MetroFramework.Controls.MetroPanel pnlMessageOk;
        private MetroFramework.Controls.MetroButton btnMessageOK;
        private MetroFramework.Controls.MetroButton btnMessageYes;
        private MetroFramework.Controls.MetroButton btnMessageNo;
        private MetroFramework.Controls.MetroPanel pnlMessageYesNo;
    }
}