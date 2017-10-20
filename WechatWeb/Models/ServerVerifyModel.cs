﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WechatWeb.Models
{
    public class ServerVerifyModel
    {
        public string signature { get; set; }
        public string timestamp { get; set; }
        public string nonce { get; set; }
        public string echostr { get; set; }
    }
}