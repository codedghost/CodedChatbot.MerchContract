using PrintfulLib.Models.WebhookResponses;

namespace CodedChatbot.MerchContract
{
    public class OrderFailedMessage : MerchMessage
    {
        public OrderStatusChange OrderStatusChange { get; set; }
    }
}