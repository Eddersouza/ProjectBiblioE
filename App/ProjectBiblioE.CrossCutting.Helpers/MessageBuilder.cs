using System;
using System.Collections.Generic;
using System.Resources;

using ProjectBiblioE.CrossCutting.Resource;
using ProjectBiblioE.Domain.Contracts.Utils;
using ProjectBiblioE.Domain.Enums;
using System.Collections;

namespace ProjectBiblioE.CrossCutting.Helpers
{
    /// <summary>
    /// Class to build message.
    /// </summary>
    public class MessageBuilder : MessageContract
    {
        /// <summary>
        /// Instance of Resources.
        /// </summary>
        private readonly ResourceManager _resources;

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public MessageBuilder()
        {
            this._resources = new ResourceManager(typeof(Resources));
        }

        /// <summary>
        /// Mount message.
        /// </summary>
        /// <param name="message">Message pattern.</param>
        /// <param name="paramsMessage">Params to message.</param>
        /// <returns>Mounted message.</returns>
        public string MountMessage(
            MessageBiblioE message,
            params string[] paramsMessage)
        {
            string messageComplete = string.Empty;

            string messagetemp = this._resources.GetString(message.ToString());

            messageComplete = string.Format(messagetemp, paramsMessage);

            return messageComplete;
        }

        /// <summary>
        /// Mount message.
        /// </summary>
        /// <param name="message">Pattern message.</param>
        /// <param name="subjectMessage">Subject message.</param>
        /// <param name="paramsMessage">Params to message.</param>
        /// <returns>Mounted message.</returns>
        public string MountMessage(
            MessageBiblioE message,
            LabelText subjectMessage,
            params string[] paramsMessage)
        {
            string messageComplete = string.Empty;

            string messagetemp = this._resources.GetString(message.ToString());

            List<string> listParams = new List<string>();

            listParams.Add(_resources.GetString(subjectMessage.ToString()));

            foreach (var param in paramsMessage)
            {
                listParams.Add(param);
            }

            messageComplete = this.MountMessage(message, listParams.ToArray());

            return messageComplete;
        }
    }
}