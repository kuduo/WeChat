using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HD.WeChat.API.CommonAPIs;
using HD.WeChat.API.Entities;

namespace HD.WeChat.API.AdvancedAPIs
{
    /// <summary>
    /// 模板消息接口
    /// </summary>
    public static class Template
    {
        public static WXJsonResult SendTemplateMessage<T>(string accessToken, string openId, string templateId, string topcolor, T data)
        {
            const string urlFormat = "https://api.weixin.qq.com/cgi-bin/message/template/send?access_token={0}";
            var msgData = new TempleteModel()
            {
                template_id = templateId,
                topcolor = topcolor,
                touser = openId,
                data = data
            };
            return CommonJsonSend.Send<WXJsonResult>(accessToken, urlFormat, msgData);
        }
    }
}