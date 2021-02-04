using PrintfulLib.Models.WebhookResponses;

namespace CodedChatbot.MerchContract
{
    public class OrderCancelledMessage : MerchMessage
    {
        public OrderStatusChange OrderStatusChange { get; set; }
    }
}