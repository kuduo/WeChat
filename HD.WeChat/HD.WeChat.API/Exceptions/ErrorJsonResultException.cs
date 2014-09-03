using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HD.WeChat.API.Entities;

namespace HD.WeChat.API
{
    /// <summary>
    /// JSON返回错误代码（比如token_access相关操作中使用）。
    /// </summary>
    public class ErrorJsonResultException : WXException
    {
        public WXJsonResult JsonResult { get; set; }
        public ErrorJsonResultException(string message, Exception inner, WXJsonResult jsonResult)
            : base(message, inner)
        {
            JsonResult = jsonResult;
        }
    }
}
