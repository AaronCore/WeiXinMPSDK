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
    
    文件名：IsTradeManagementConfirmationCompletedJsonResult.cs
    文件功能描述：查询小程序是否已完成交易结算管理确认 接口返回参数
    
    创建标识：Guili95 - 20240623

----------------------------------------------------------------*/

using Senparc.Weixin.Entities;

namespace Senparc.Weixin.WxOpen.AdvancedAPIs.Sec
{
    /// <summary>
    /// 查询小程序是否已完成交易结算管理确认
    /// </summary>
    public class IsTradeManagementConfirmationCompletedJsonResult : WxJsonResult
    {
        /// <summary>
        /// 是否已完成交易结算管理确认
        /// </summary>
        public bool completed { get; set; }
    }
}
