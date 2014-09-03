using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HD.WeChat.API.Entities;

namespace HD.WeChat.API.AdvancedAPIs
{
    /// <summary>
    /// 创建分组返回结果
    /// </summary>
    public class CreateGroupResult : WXJsonResult
    {
        public GroupsJson_Group group { get; set; }
    }
}
