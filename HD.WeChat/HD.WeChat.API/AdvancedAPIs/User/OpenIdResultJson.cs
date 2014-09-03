using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HD.WeChat.API.Entities;

namespace HD.WeChat.API.AdvancedAPIs
{
    public class OpenIdResultJson : WXJsonResult
    {
       public int total { get; set; }
       public int count { get; set; }
       public OpenIdResultJson_Data data { get; set; }
       public string next_openid { get; set; }
    }

    public class OpenIdResultJson_Data
    {
        public List<string> openid { get; set; }
    }
}
