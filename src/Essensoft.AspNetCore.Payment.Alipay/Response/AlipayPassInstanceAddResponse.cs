using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPassInstanceAddResponse.
    /// </summary>
    public class AlipayPassInstanceAddResponse : AlipayResponse
    {
        /// <summary>
        /// 接口调用返回结果信息  serialNumber：唯一核销凭证串号（必须由动态传参指定）  passId：券唯一id  operation：本次调用的操作类型，ADD  errorCode：处理结果码（错误码）  errorMsg：处理结果说明（错误说明）
        /// </summary>
        [JsonProperty("result")]
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 操作成功标识【true：成功；false：失败】
        /// </summary>
        [JsonProperty("success")]
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
