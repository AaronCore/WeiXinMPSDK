﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2025 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2025 Senparc
    
    文件名：LibraryListJsonResult.cs
    文件功能描述：“获取小程序模板库标题列表”接口：LibraryList 结果
    
    
    创建标识：Senparc - 20170827

----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Senparc.Weixin.Entities;

namespace Senparc.Weixin.WxOpen.AdvancedAPIs.Template
{
    /// <summary>
    /// “获取小程序模板库标题列表”接口：LibraryList 结果
    /// </summary>
    public class LibraryListJsonResult : WxJsonResult
    {
        public List<LibraryListJsonResult_List> list { get; set; }
        /// <summary>
        /// 模板库标题总数
        /// </summary>
        public int total_count { get; set; }
    }

    public class LibraryListJsonResult_List
    {
        /// <summary>
        /// 模板标题id（获取模板标题下的关键词库时需要）
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 模板标题内容
        /// </summary>
        public string title { get; set; }
    }
}
