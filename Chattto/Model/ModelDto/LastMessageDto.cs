using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chattto.Model.ModelDto
{
    public class LastMessageDto
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("sent")]
        public int Sent { get; set; }

        //[JsonProperty("edited")]
        //public int Edited { get; set; }

        //[JsonProperty("read")]
        //public bool Read { get; set; }
    }
}
