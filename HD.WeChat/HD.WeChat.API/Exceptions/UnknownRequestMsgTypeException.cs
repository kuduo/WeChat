﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HD.WeChat.API
{
    /// <summary>
    /// 未知请求类型。
    /// </summary>
    public class UnknownRequestMsgTypeException : WXException //ArgumentOutOfRangeException
    {
        public UnknownRequestMsgTypeException(string message)
            : base(message, null)
        {
        }

        public UnknownRequestMsgTypeException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
