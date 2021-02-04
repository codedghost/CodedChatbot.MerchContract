using System;
using CodedGhost.RabbitMQTools.Models;
using PrintfulLib.Models.WebhookResponses;

namespace CodedChatbot.MerchContract
{
    public class PackageShippedMessage : RabbitMessage
    {
        public DateTime EventCreated { get; set; }
        public ShipmentInfo ShipmentInfo { get; set; }
    }
}