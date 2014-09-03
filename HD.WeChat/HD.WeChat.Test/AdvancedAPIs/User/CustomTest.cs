using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HD.WeChat.API.AdvancedAPIs;
using HD.WeChat.API.CommonAPIs;
using HD.WeChat.API.Entities;
using HD.WeChat.API.Test.CommonAPIs;

namespace HD.WeChat.API.Test.AdvancedAPIs
{
    //已经通过测试
    //[TestClass]
    public class UserTest : CommonApiTest
    {

        [TestMethod]
        public void InfoTest()
        {
            var accessToken = AccessTokenContainer.GetToken(_appId);

            var result = User.Info(accessToken, _testOpenId);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetTest()
        {
            var accessToken = AccessTokenContainer.GetToken(_appId);

            var result = User.Get(accessToken, _testOpenId);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.total > 0);
            Assert.IsTrue(result.data == null || result.data.openid.Count > 0);
        }
    }
}
