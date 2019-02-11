using System;

namespace EntityDTH
{
    [Serializable]
    public class Entity
    {
      
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public int SubscriptionId { get; set; }
        public string CustomerName { get; set; }
        public string ChannelName { get; set; }
        public DateTime subscription_date { get; set; }
        public Channel_Category ChannelCategory { get; set; }
        public string unsubscription { get; set; } = "false";
        public DateTime unsubscription_date { get; set; }

    }


    public enum Channel_Category
    {
        Movies , New, Music, Sports, Lifestyle, Religious
    }
}
