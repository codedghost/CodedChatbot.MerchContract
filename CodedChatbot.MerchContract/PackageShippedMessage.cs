using PrintfulLib.Models.WebhookResponses;

namespace CodedChatbot.MerchContract
{
    public class PackageShippedMessage : MerchMessage
    {
        public ShipmentInfo ShipmentInfo { get; set; }
    }
}