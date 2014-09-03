using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HD.WeChat.API.Entities;

namespace HD.WeChat.API.AdvancedAPIs
{
    /// <summary>
    /// 聊天记录结果
    /// </summary>
    public class GetRecordResult : WXJsonResult
    {
        public List<RecordJson> recordlist { get; set; }
    }
}
