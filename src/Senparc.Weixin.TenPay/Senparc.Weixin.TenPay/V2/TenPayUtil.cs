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
 
    文件名：TenPayUtil.cs
    文件功能描述：微信支付配置文件
    
    
    创建标识：Senparc - 20150211
    
    修改标识：Senparc - 20150303
    修改描述：整理接口
 
    修改标识：Senparc - 20161014
    修改描述：修改TenPayUtil.BuildRandomStr()方法
        
    修改标识：Senparc - 20171010
    修改描述：v14.8.1 修复几处GetNoncestr还在使用GBK编码
        
    修改标识：Senparc - 20230628
    修改描述：v1.12.8 TenPayUtil.GetNoncestr() 弃用 MD5 加密方法

----------------------------------------------------------------*/

using System;
using System.Text;

using System.Net;
using Senparc.Weixin.Helpers;
using Senparc.CO2NET.Helpers;

namespace Senparc.Weixin.TenPay.V2
{
    /// <summary>
    /// TenpayUtil 的摘要说明。
    /// 配置文件
    /// </summary>
    public class TenPayUtil
    {
        /// <summary>
        /// 随机生成Noncestr
        /// </summary>
        /// <returns></returns>
        public static string GetNoncestr()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }

        public static string GetTimestamp()
        {
            TimeSpan ts = DateTimeOffset.Now - new DateTimeOffset(1970, 1, 1, 0, 0, 0, 0, TimeSpan.Zero);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }

        /// <summary>
        /// 对字符串进行URL编码
        /// </summary>
        /// <param name="instr"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public static string UrlEncode(string instr, string charset)
        {
            //return instr;
            if (instr == null || instr.Trim() == "")
                return "";
            else
            {
                //string res;

                try
                {
#if NET462
                    return System.Web.HttpUtility.UrlEncode(instr, Encoding.GetEncoding(charset));
#else
                    return WebUtility.UrlEncode(instr);
#endif
                }
                catch (Exception ex)
                {
#if NET462
                    return System.Web.HttpUtility.UrlEncode(instr, Encoding.GetEncoding("GB2312"));
#else
                    return WebUtility.UrlEncode(instr);
#endif
                }

                //return res;
            }
        }

        /// <summary>
        /// 对字符串进行URL解码
        /// </summary>
        /// <param name="instr"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public static string UrlDecode(string instr, string charset)
        {
            if (instr == null || instr.Trim() == "")
                return "";
            else
            {
                string res;

                try
                {
#if NET462
                    return System.Web.HttpUtility.UrlDecode(instr, Encoding.GetEncoding(charset));
#else
                    return WebUtility.UrlDecode(instr);
#endif
                }
                catch (Exception ex)
                {
#if NET462
                    return System.Web.HttpUtility.UrlDecode(instr, Encoding.GetEncoding("GB2312"));
#else
                    return WebUtility.UrlDecode(instr);
#endif
                }

                //return res;

            }
        }

        /// <summary>
        /// 取时间戳生成随即数,替换交易单号中的后10位流水号
        /// </summary>
        /// <returns></returns>
        public static UInt32 UnixStamp()
        {
//#if NET462
//            TimeSpan ts = DateTime.Now - TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
//#else
            TimeSpan ts = SystemTime.Now - new DateTimeOffset(1970, 1, 1, 0, 0, 0, 0, TimeSpan.Zero);
//#endif
            return Convert.ToUInt32(ts.TotalSeconds);
        }

        /// <summary>
        /// 取随机数
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string BuildRandomStr(int length)
        {
            Random rand = new Random();

            int num = rand.Next();

            string str = num.ToString();

            if (str.Length > length)
            {
                str = str.Substring(0, length);
            }
            else if (str.Length < length)
            {
                int n = length - str.Length;
                while (n > 0)
                {
                    str = str.Insert(0, "0");
                    n--;
                }
            }

            return str;
        }

    }
}