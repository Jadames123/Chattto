using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using static Xamarin.Forms.Internals.Profile;

namespace Chattto.Model.ModelDto
{
    public class DialogsDto
    {
        //[JsonProperty("page")]
        //public int Page { get; set; }

        //[JsonProperty("pages")]
        //public int Pages { get; set; }
         
        [JsonProperty("data")]
        public List<DataDto> Data { get; set; }
    }
}
