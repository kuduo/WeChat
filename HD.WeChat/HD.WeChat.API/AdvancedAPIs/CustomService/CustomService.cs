﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HD.WeChat.API.CommonAPIs;

namespace HD.WeChat.API.AdvancedAPIs
{
    /// <summary>
    /// 多客服接口聊天记录接口，官方API：http://mp.weixin.qq.com/wiki/index.php?title=%E8%8E%B7%E5%8F%96%E5%AE%A2%E6%9C%8D%E8%81%8A%E5%A4%A9%E8%AE%B0%E5%BD%95
    /// </summary>
    public static class CustomService
    {
        /// <summary>
        /// 获取用户聊天记录
        /// </summary>
        /// <param name="accessToken">调用接口凭证</param>
        /// <param name="startTime">查询开始时间，会自动转为UNIX时间戳</param>
        /// <param name="endTime">查询结束时间，会自动转为UNIX时间戳，每次查询不能跨日查询</param>
        /// <param name="openId">（非必须）普通用户的标识，对当前公众号唯一</param>
        /// <param name="pageSize">每页大小，每页最多拉取1000条</param>
        /// <param name="pageIndex">查询第几页，从1开始</param>
        public static GetRecordResult GetRecord(string accessToken, DateTime startTime, DateTime endTime, string openId = null, int pageSize = 10, int pageIndex = 1)
        {
            var urlFormat = "https://api.weixin.qq.com/cgi-bin/customservice/getrecord?access_token={0}";

            //规范页码
            if (pageSize <= 0)
            {
                pageSize = 1;
            }
            else if (pageSize > 1000)
            {
                pageSize = 1000;
            }


            //组装发送消息
            var data = new
            {
                starttime = Helpers.DateTimeHelper.GetWeixinDateTime(startTime),
                endtime = Helpers.DateTimeHelper.GetWeixinDateTime(endTime),
                openId = openId,
                pagesize = pageSize,
                pageIndex = pageIndex
            };

            return CommonJsonSend.Send<GetRecordResult>(accessToken, urlFormat, data);
        }
    }
}
