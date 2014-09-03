using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HD.WeChat.API.Exceptions
{
    public class WXMenuException : WXException
    {
        public WXMenuException(string message)
            : base(message, null)
        {
        }

        public WXMenuException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
