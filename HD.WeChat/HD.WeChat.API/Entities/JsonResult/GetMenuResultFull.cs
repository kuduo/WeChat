﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HD.WeChat.API.Entities;
using HD.WeChat.API.Entities.Menu;

namespace HD.WeChat.API
{
    /// <summary>
    /// 获取菜单时候的完整结构，用于接收微信服务器返回的Json信息
    /// </summary>
    public class GetMenuResultFull : WXJsonResult
    {
        public MenuFull_ButtonGroup menu { get; set; }
    }

    public class MenuFull_ButtonGroup
    {
        public List<MenuFull_RootButton> button { get; set; }
    }

    public class MenuFull_RootButton
    {
        public string type { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public List<MenuFull_RootButton> sub_button { get; set; }
    }
}
