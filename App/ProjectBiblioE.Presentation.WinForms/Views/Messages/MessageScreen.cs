using MetroFramework.Forms;
using ProjectBiblioE.CrossCutting.Resource;
using ProjectBiblioE.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    break;
                case MessageType.Error:
                    this.Text = Resources.MessageScreenTitleError;
                    this.imgMessage.Image = Resources.icon_message_close_rede_128_128;
                    break;
                case MessageType.Success:
                    this.Text = Resources.MessageScreenTitleSucess;
                    this.imgMessage.Image = Resources.icon_message_ok_green_128_128;
                    break;
                default:
                    break;
            }
        }
    }
}
