using PrintfulLib.Models.WebhookResponses;

namespace CodedChatbot.MerchContract
{
    public class StockUpdatedMessage : MerchMessage
    {
        public ProductStock ProductStock { get; set; }
    }
}