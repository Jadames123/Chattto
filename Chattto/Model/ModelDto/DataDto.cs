using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chattto.Model.ModelDto
{
    public class DataDto
    {
        [JsonProperty("unread_count")] 
        public int UnreadCount { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("last_message")]
        public LastMessageDto Last_Message { get; set; }
    }
}
