using Chattto.Model.ModelDto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chattto.Model
{
    public class Data
    {
        public int UnreadCount { get; set; }

        public string Username { get; set; }

        public LastMessage Last_Message { get; set; }
    }
}
 