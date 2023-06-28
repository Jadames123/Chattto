using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chattto.Model.ModelDto
{
    public class TokenDto
    {
        [JsonProperty("key")]
        public String Key { get; set; }
    }
}
