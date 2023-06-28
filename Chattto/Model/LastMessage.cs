using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chattto.Model
{
    public class LastMessage
    {
        public string Text { get; set; }
        public int Sent { get; set; }

        //public int Edited { get; set; }

        //public bool Read { get; set; }
    }
}
