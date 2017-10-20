using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WechatWeb.Models;

namespace WechatWeb.Controllers
{
    public class WechatResponseController : Controller
    {
        [HttpGet]
        public string ServerVerify(ServerVerifyModel model)
        {
            var stringList = new List<string>() {
                
            };
        
            return "true";
        }
    }
}