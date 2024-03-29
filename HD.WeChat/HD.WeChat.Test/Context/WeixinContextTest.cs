﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HD.WeChat.API.Context;
using HD.WeChat.API.MessageHandlers;
using HD.WeChat.API.Test.MessageHandlers;

namespace HD.WeChat.API.Test.Context
{
    [TestClass]
    public class WeixinContextTest
    {
        string xmlText = @"<?xml version=""1.0"" encoding=""utf-8""?>
<xml>
    <ToUserName><![CDATA[gh_a96a4a619366]]></ToUserName>
    <FromUserName><![CDATA[olPjZjsXuQPJoV0HlruZkNzKc91E]]></FromUserName>
    <CreateTime>1357986928</CreateTime>
    <MsgType><![CDATA[text]]></MsgType>
    <Content><![CDATA[TNT2]]></Content>
    <MsgId>5832509444155992350</MsgId>
</xml>
";
        [TestMethod]
        public void LimitRecordCountTest()
        {
            var doc = XDocument.Parse(xmlText);
            var maxRecordCount = 1;
            for (int i = 0; i < 100; i++)
            {
                var messageHandler = new CustomerMessageHandlers(doc,maxRecordCount);
                messageHandler.Execute();
            }
            var weixinContext = MessageHandler<MessageContext>.GlobalWeixinContext.MessageQueue.FirstOrDefault();
            var recordCount = MessageHandler<MessageContext>.GlobalWeixinContext.MaxRecordCount;

            Assert.IsNotNull(weixinContext);
            Assert.AreEqual(recordCount, weixinContext.RequestMessages.Count);
            Assert.AreEqual(recordCount, weixinContext.ResponseMessages.Count);
        }
    }
}
