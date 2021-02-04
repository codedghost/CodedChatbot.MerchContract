using PrintfulLib.Models.WebhookResponses;

namespace CodedChatbot.MerchContract
{
    public class ProductSyncedMessage : MerchMessage
    {
        public SyncInfo SyncInfo { get; set; }
    }
}