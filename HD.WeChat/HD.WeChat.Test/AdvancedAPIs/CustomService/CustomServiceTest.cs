﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HD.WeChat.API.AdvancedAPIs;
using HD.WeChat.API.CommonAPIs;
using HD.WeChat.API.Test.CommonAPIs;

namespace HD.WeChat.API.Test.AdvancedAPIs
{
    [TestClass]
    public class CustomServiceTest : CommonApiTest
    {
        [TestMethod]
        public void GetRecordTest()
        {
            var openId = "o3IHxjkke04__4n1kFeXpfMjjRBc";
            var accessToken = AccessTokenContainer.GetToken(_appId);
            var result = CustomService.GetRecord(accessToken, DateTime.Today, DateTime.Now, null, 10, 1);
            Assert.IsTrue(result.recordlist.Count > 0);
        }
    }
}
