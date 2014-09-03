using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HD.WeChat.API.Entities;

namespace HD.WeChat.API.AdvancedAPIs
{
    /// <summary>
    /// 获取用户分组ID返回结果
    /// </summary>
    public class GetGroupIdResult : WXJsonResult
    {
        public int groupid { get; set; }
    }
}
