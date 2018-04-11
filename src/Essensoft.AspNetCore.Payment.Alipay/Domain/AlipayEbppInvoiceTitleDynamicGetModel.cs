using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTitleDynamicGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceTitleDynamicGetModel : AlipayObject
    {
        /// <summary>
        /// 抬头动态码
        /// </summary>
        [JsonProperty("bar_code")]
        [XmlElement("bar_code")]
        public string BarCode { get; set; }
    }
}
