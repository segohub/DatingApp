using System;
using Newtonsoft.Json;

namespace DatingApp.API.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        
        [JsonIgnore]
        public User Sender { get; set; }
        public int RecipientId { get; set; }

        [JsonIgnore]
        public User Recipient { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime MessageSent { get; set; }
        public bool SenderDeleted { get; set; }
        public bool RecipientDeleted { get; set; }
    }
}