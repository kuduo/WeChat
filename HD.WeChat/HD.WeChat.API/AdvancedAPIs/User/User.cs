﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HD.WeChat.API.HttpUtility;

namespace HD.WeChat.API.AdvancedAPIs
{
    //接口详见：http://mp.weixin.qq.com/wiki/index.php?title=%E8%8E%B7%E5%8F%96%E7%94%A8%E6%88%B7%E5%9F%BA%E6%9C%AC%E4%BF%A1%E6%81%AF
    
    /// <summary>
    /// 用户接口
    /// </summary>
    public static class User
    {
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="accessToken">调用接口凭证</param>
        /// <param name="openId">普通用户的标识，对当前公众号唯一</param>
        /// <param name="lang">返回国家地区语言版本，zh_CN 简体，zh_TW 繁体，en 英语</param>
        /// <returns></returns>
        public static UserInfoJson Info(string accessToken, string openId, Language lang = Language.zh_CN)
        {
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/user/info?access_token={0}&openid={1}&lang={2}",
                accessToken, openId, lang.ToString());
            return HttpUtility.Get.GetJson<UserInfoJson>(url);

            //错误时微信会返回错误码等信息，JSON数据包示例如下（该示例为AppID无效错误）:
            //{"errcode":40013,"errmsg":"invalid appid"}
        }

        /// <summary>
        /// 获取关注着OpenId信息
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="nextOpenId"></param>
        /// <returns></returns>
        public static OpenIdResultJson Get(string accessToken, string nextOpenId)
        {
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/user/get?access_token={0}",
                accessToken);
            if (!string.IsNullOrEmpty(nextOpenId))
            {
                url += "&next_openid=" + nextOpenId;
            }
            return HttpUtility.Get.GetJson<OpenIdResultJson>(url);
        }
    }
}
