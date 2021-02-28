﻿using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 服务时间段
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_1.shtml">创单结单合并API</a> - 最新更新时间：2020.04.23</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_14.shtml">创建支付分订单API</a> - 最新更新时间：2020.03.05</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_15.shtml">查询支付分订单API</a> - 最新更新时间：2020.05.25</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_17.shtml">修改订单金额API</a> - 最新更新时间：2020.03.05</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_18.shtml">完结支付分订单API</a> - 最新更新时间：2020.06.02</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_20.shtml">同步服务订单信息API</a> - 最新更新时间：2020.03.05</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_21.shtml">确认订单回调通知API</a> - 最新更新时间：2020.03.05</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_22.shtml">支付成功回调通知API</a> - 最新更新时间：2020.05.25</para>
    /// </remarks>
    public class TimeRange : WeChatPayObject
    {
        /// <summary>
        /// 服务开始时间
        /// </summary>
        /// <remarks>
        /// 用户端展示用途
        /// 用户下单时确认的服务开始时间（比如用户今天下单，明天开始接受服务，这里指的是明天的服务开始时间）.
        /// 1、不能比【商户使用创建订单时间】早；
        /// 2、不能比【商户使用完结订单时间】晚。
        /// 3、根据传入时间精度进行校验，若传入时间精确到秒，则校验精确到秒；若传入时间精确到日，则校验精确到日。
        /// 4、要求时间格式必须与首次传入格式保持一致，在一致前提下可修改。
        /// 支持三种格式：“yyyyMMddHHmmss”、“yyyyMMdd” 和 “OnAccept”。
        /// ● 传入20091225091010表示2009年12月25日9点10分10秒
        /// ● 传入20091225默认认为时间为2009年12月25日
        /// ● 传入OnAccept表示用户确认订单成功时间为【服务开始时间】
        /// 【服务开始时间】不能早于调用接口时间。
        /// 【建议】
        ///   实际服务开始时间与创建订单填写的“服务开始时间”一致时，不填写
        /// 示例值：20091225091010
        /// </remarks>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 服务开始时间备注
        /// </summary>
        /// <remarks>
        /// 服务开始时间备注说明。
        /// 1、服务开始时间有填时，可填写服务开始时间备注
        /// 2、若与【服务开始时间备注】不一致，则以【实际服务开始时间备注】为准，不超过20个字符，超出报错处理。
        /// 示例值：出账日
        /// </remarks>
        [JsonPropertyName("start_time_remark")]
        public string StartTimeRemark { get; set; }

        /// <summary>
        /// 服务结束时间
        /// </summary>
        /// <remarks>
        /// 创建订单未填写服务结束时间，则完结的时候，服务结束时间必填
        /// 1、【实际服务结束时间】＞【服务开始时间】。
        /// 2、不能比【商户使用完结订单时间】晚。
        /// 3、要求时间格式必须与首次传入格式保持一致，在一致前提下可修改。
        /// 4、若创建时，服务开始时间为格式3=OnAccept，则完结时间默认精确到秒级。
        /// 用户端展示用途，支持两种格式：yyyyMMddHHmmss和yyyyMMdd
        /// ● 传入20091225091010表示2009年12月25日9点10分10秒
        /// ● 传入20091225默认认为时间为2009年12月25日
        /// 【建议】
        ///   实际服务结束实际和预计服务结束时间一致时，不填写
        /// 示例值：20091225121010
        /// </remarks>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 服务结束时间备注
        /// </summary>
        /// <remarks>
        /// 服务结束时间备注说明。
        /// 1、服务结束时间有填时，可填写服务结束时间备注
        /// 2、若与【服务结束时间备注】不一致，则以【实际服务结束时间备注】为准，不超过20个字符，超出报错处理。
        /// 示例值：结束租借时间
        /// </remarks>
        [JsonPropertyName("end_time_remark")]
        public string EndTimeRemark { get; set; }
    }
}
