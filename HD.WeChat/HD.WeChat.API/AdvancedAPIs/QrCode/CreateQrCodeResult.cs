using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HD.WeChat.API.Entities;

namespace HD.WeChat.API.AdvancedAPIs
{
    /// <summary>
    /// 二维码创建返回结果
    /// </summary>
    public class CreateQrCodeResult : WXJsonResult
    {
        public string ticket { get; set; }
        public int expire_seconds { get; set; }
    }
}
