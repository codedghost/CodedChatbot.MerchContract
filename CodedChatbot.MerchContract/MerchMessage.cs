using System;
using CodedGhost.RabbitMQTools.Models;

namespace CodedChatbot.MerchContract
{
    public abstract class MerchMessage : RabbitMessage
    {
        public DateTime EventCreated { get; set; }
    }
}