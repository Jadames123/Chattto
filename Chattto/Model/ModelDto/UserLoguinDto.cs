﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chattto.Model
{
    public class UserLoguinDto
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        //[JsonProperty("email")]
        //public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
