using PrintfulLib.Models.WebhookResponses;

namespace CodedChatbot.MerchContract
{
    public class OrderRemoveHoldMessage : MerchMessage
    {
        public OrderStatusChange OrderStatusChange { get; set; }
    }
}