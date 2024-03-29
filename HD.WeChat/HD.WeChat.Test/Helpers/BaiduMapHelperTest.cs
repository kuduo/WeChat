﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HD.WeChat.API.Test
{
    using HD.WeChat.API.Entities.BaiduMap;
    using HD.WeChat.API.Helpers;

    [TestClass]
    public class BaiduMapHelperTest
    {
        [TestMethod]
        public void GetBaiduStaticMapTest()
        {
            var markersList = new List<BaiduMarkers>();
            markersList.Add(new BaiduMarkers()
                                {
                                    Longitude = 31.285774,
                                    Latitude = 120.597610,
                                    Color="red",
                                    Label="O",
                                    Size=  BaiduMarkerSize.Default,
                                });
            markersList.Add(new BaiduMarkers()
                                {
                                    Longitude = 31.289774,
                                    Latitude = 120.597910,
                                    Color = "blue",
                                    Label = "T",
                                    Size = BaiduMarkerSize.Default,
                                });

            var url = BaiduMapHelper.GetBaiduStaticMap(31.285774, 120.597610,2,16, markersList);
            Console.WriteLine(url);
            Assert.IsNotNull(url);
        }
    }
}
