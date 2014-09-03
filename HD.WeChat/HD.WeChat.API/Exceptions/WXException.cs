using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HD.WeChat.API
{
    /// <summary>
    /// 微信自定义异常基类
    /// </summary>
    public class WXException : ApplicationException
    {
        public WXException(string message)
            : base(message, null)
        {
        }

        public WXException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
