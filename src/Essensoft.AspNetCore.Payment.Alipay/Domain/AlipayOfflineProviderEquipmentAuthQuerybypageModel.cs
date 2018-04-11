using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineProviderEquipmentAuthQuerybypageModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderEquipmentAuthQuerybypageModel : AlipayObject
    {
        /// <summary>
        /// 解绑起始时间
        /// </summary>
        [JsonProperty("begin_time")]
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 机具类型
        /// </summary>
        [JsonProperty("device_type")]
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 解绑截止时间
        /// </summary>
        [JsonProperty("end_time")]
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展信息，传json格式的字符串，包含operator=操作人；operator_id =操作人ID
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 机具厂商PID
        /// </summary>
        [JsonProperty("merchant_pid")]
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 当前页，***注意页数从1开始***
        /// </summary>
        [JsonProperty("page_num")]
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页容量：最小1，最大100
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
