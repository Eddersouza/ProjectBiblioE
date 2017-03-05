using System;
using System.Windows.Forms;

using MetroFramework.Forms;

using ProjectBiblioE.CrossCutting.Resource;
using ProjectBiblioE.Domain.Enums;

namespace ProjectBiblioE.Presentation.WinForms.Views.Messages
{
    public partial class MessageScreen : MetroForm
    {
        public MessageScreen(MessageType messageType, string messageText)
        {
            InitializeComponent();

            switch (messageType)
            {
                case MessageType.Alert:
                    this.Text = Resources.MessageScreenTitleSucess;
                    this.imgMessage.Image = Resources.icon_message_alert_yellow_128_28;
                    this.lblMessageText.Text = messageText;
                    this.pnlMessageOk.Visible = true;
                    pnlMessageYesNo.Visible = false;
                    break;
                case MessageType.Confirm:
                    this.Text = Resources.MessageScreenTitleConfirm;
                    this.imgMessage.Image = Resources.icon_message_confirm_blue_128_128;
                    this.lblMessageText.Text = messageText;
                    this.pnlMessageOk.Visible = false;
                    pnlMessageYesNo.Visible = true;
                    break;
                case MessageType.Error:
                    this.Text = Resources.MessageScreenTitleError;
                    this.imgMessage.Image = Resources.icon_message_close_rede_128_128;
                    this.lblMessageText.Text = messageText;
                    this.pnlMessageOk.Visible = true;
                    pnlMessageYesNo.Visible = false;
                    break;
                case MessageType.Success:
                    this.Text = Resources.MessageScreenTitleSucess;
                    this.imgMessage.Image = Resources.icon_message_ok_green_128_128;
                    this.lblMessageText.Text = messageText;
                    this.pnlMessageOk.Visible = true;
                    pnlMessageYesNo.Visible = false;
                    break;
                default:
                    this.Text = Resources.MessageScreenTitleError;
                    this.imgMessage.Image = Resources.icon_message_close_rede_128_128;
                    this.lblMessageText.Text = messageText;
                    this.pnlMessageOk.Visible = true;
                    pnlMessageYesNo.Visible = false;
                    break;
            }
        }

        public static DialogResult BtnResult
        {
            get; set;
        }

        private void btnMessageNo_Click(object sender, EventArgs e)
        {
            BtnResult = DialogResult.No;
            this.Close();
        }

        private void btnMessageOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMessageYes_Click(object sender, EventArgs e)
        {
            BtnResult = DialogResult.Yes;
            this.Close();
        }
    }
}