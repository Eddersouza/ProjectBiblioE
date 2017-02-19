using System;

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
                case MessageType.Confirm:
                    this.Text = Resources.MessageScreenTitleConfirm;
                    this.imgMessage.Image = Resources.icon_message_confirm_blue_128_128;
                    this.lblMessageText.Text = messageText;
                    break;
                case MessageType.Error:
                    this.Text = Resources.MessageScreenTitleError;
                    this.imgMessage.Image = Resources.icon_message_close_rede_128_128;
                    this.lblMessageText.Text = messageText;
                    break;
                case MessageType.Success:
                    this.Text = Resources.MessageScreenTitleSucess;
                    this.imgMessage.Image = Resources.icon_message_ok_green_128_128;
                    this.lblMessageText.Text = messageText;
                    break;
                default:
                    break;
            }
        }

        private void btnMessageOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}