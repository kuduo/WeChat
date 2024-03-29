﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HD.WeChat.API.Entities
{
    /// <summary>
    /// 事件之二维码扫描（关注微信）
    /// </summary>
    public class RequestMessageEvent_Scan : RequestMessageEventBase, IRequestMessageEventBase
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public override Event Event
        {
            get { return Event.scan; }
        }

        public string Ticket { get; set; }
    }
}
