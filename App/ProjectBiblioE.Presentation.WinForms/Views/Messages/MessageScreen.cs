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
        public MessageScreen(MessageType messageType, string message)
        {
            InitializeComponent();

            this.StyleManager = metroStyleManagerMessageScreen;

            //switch (messageType)
            //{
            //    case MessageType.Confirm:
            //        this.Text = Resources.MessageScreenTitleConfirm;
            //        this.imgMessageScreen.Image = Resources.icon_message_confirm_blue_128_128;
            //        break;
            //    case MessageType.Error:
            //        this.Text = Resources.MessageScreenTitleError;
            //        break;
            //    case MessageType.Success:
            //        this.Text = Resources.MessageScreenTitleSucess;
            //        break;
            //    default:
            //        break;
            //}

            //switch (message)
            //{
            //    case MessageType.SuccessMessageSucess:
            //        //metroStyleManagerMessages.Style = MetroFramework.MetroColorStyle.Green;
            //        this.Text = "Alert";
            //        //this.pictureBox1.Image = Resources.Alarm_Tick_icon;
            //        break;
            //    case MessageType.MessageWarning:
            //        //metroStyleManagerMessages.Style = MetroFramework.MetroColorStyle.Orange;
            //        this.Text = "Warning";
            //        //this.pictureBox1.Image = Resources.Alarm_Warning_icon;
            //        break;
            //    case MessageType.MessageError:
            //        //metroStyleManagerMessages.Style = MetroFramework.MetroColorStyle.Red;
            //        this.Text = "Error";
            //        //this.pictureBox1.Image = Resources.Alarm_Error_icon;
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
