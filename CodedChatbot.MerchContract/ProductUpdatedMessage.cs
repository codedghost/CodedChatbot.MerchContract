using PrintfulLib.Models.WebhookResponses;

namespace CodedChatbot.MerchContract
{
    public class ProductUpdatedMessage : MerchMessage
    {
        public SyncInfo SyncInfo { get; set; }
    }
}