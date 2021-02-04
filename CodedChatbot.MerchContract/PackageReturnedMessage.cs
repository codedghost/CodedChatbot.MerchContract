using PrintfulLib.Models.WebhookResponses;

namespace CodedChatbot.MerchContract
{
    public class PackageReturnedMessage : MerchMessage
    {
        public ReturnInfo ReturnInfo { get; set; }
    }
}