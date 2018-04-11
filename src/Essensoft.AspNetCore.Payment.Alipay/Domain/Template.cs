using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Template Data Structure.
    /// </summary>
    [Serializable]
    public class Template : AlipayObject
    {
        /// <summary>
        /// 消息模板上下文，即模板中定义的参数及参数值
        /// </summary>
        [JsonProperty("context")]
        [XmlElement("context")]
        public Context Context { get; set; }

        /// <summary>
        /// 消息模板ID
        /// </summary>
        [JsonProperty("template_id")]
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
