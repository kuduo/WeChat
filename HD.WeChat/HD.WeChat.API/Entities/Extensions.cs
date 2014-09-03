using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HD.WeChat.API.Entities
{
    public static class Extensions
    {
        /// <summary>
        /// 将RequestMessageEventBase转换成RequestMessageText类型，其中Content = requestMessage.EventKey
        /// </summary>
        /// <param name="requestMessageEvent"></param>
        /// <returns></returns>
        public static RequestMessageText ToRequestMessageText(this IRequestMessageEventBase requestMessageEvent)
        {
            var requestMessage = requestMessageEvent;
            var requestMessageText = new RequestMessageText()
            {
                FromUserName = requestMessage.FromUserName,
                ToUserName = requestMessage.ToUserName,
                CreateTime = requestMessage.CreateTime,
                MsgId = requestMessage.MsgId,
                Content = requestMessage.EventKey
            };
            return requestMessageText;
        }
    }
}
