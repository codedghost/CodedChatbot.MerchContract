using PrintfulLib.Models.WebhookResponses;

namespace CodedChatbot.MerchContract
{
    public class OrderPutOnHoldMessage : MerchMessage
    {
        public OrderStatusChange OrderStatusChange { get; set; }
    }
}