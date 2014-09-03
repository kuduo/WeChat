﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HD.WeChat.API.Entities
{
    /// <summary>
    /// 事件之取消订阅
    /// </summary>
    public class RequestMessageEvent_Click : RequestMessageEventBase, IRequestMessageEventBase
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public override Event Event
        {
            get { return Event.CLICK; }
        }
    }
}
