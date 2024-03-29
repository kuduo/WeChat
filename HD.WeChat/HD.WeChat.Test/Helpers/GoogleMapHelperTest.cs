﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HD.WeChat.API.Test
{
    using HD.WeChat.API.Entities.GoogleMap;
    using HD.WeChat.API.Helpers;

    [TestClass]
    public class GoogleMapHelperTest
    {
        [TestMethod]
        public void GetGoogleStaticMapTest()
        {
            var markersList = new List<GoogleMapMarkers>();
            markersList.Add(new GoogleMapMarkers()
                                {
                                    X = 31.285774,
                                    Y = 120.597610,
                                    Color="red",
                                    Label="O",
                                    Size= GoogleMapMarkerSize.Default,
                                });
            markersList.Add(new GoogleMapMarkers()
                                {
                                    X = 31.289774,
                                    Y = 120.597910,
                                    Color = "blue",
                                    Label = "T",
                                    Size = GoogleMapMarkerSize.Default,
                                });

            var url = GoogleMapHelper.GetGoogleStaticMap(19, markersList, size: "640x640");
            Console.WriteLine(url);
            Assert.IsNotNull(url);
        }
    }
}
