using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 当前监听器关联的QUIC监听器配置信息，仅protocol为HTTPS时有效。  对于TCP/UDP/HTTP/QUIC监听器，若该字段非空则报错。  &gt; 客户端向服务端发送正常的HTTP协议请求并携带了支持QUIC协议的信息。 如果服务端监听器开启了升级QUIC，那么就会在响应头中加入服务端支持的QUIC端口和版本信息。 客户端再次请求时会同时发送TCP(HTTPS)和UDP(QUIC)请求，若QUIC请求成功，则后续继续使用QUIC交互。  [不支持QUIC协议。](tag:hws_eu,g42,hk_g42,hcso_dt)
    /// </summary>
    public class UpdateListenerQuicConfigOption 
    {

        [JsonProperty("quic_listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QuicListenerId { get; set; }

        [JsonProperty("enable_quic_upgrade", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableQuicUpgrade { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateListenerQuicConfigOption {\n");
            sb.Append("  quicListenerId: ").Append(QuicListenerId).Append("\n");
            sb.Append("  enableQuicUpgrade: ").Append(EnableQuicUpgrade).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateListenerQuicConfigOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateListenerQuicConfigOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuicListenerId == input.QuicListenerId ||
                    (this.QuicListenerId != null &&
                    this.QuicListenerId.Equals(input.QuicListenerId))
                ) && 
                (
                    this.EnableQuicUpgrade == input.EnableQuicUpgrade ||
                    (this.EnableQuicUpgrade != null &&
                    this.EnableQuicUpgrade.Equals(input.EnableQuicUpgrade))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.QuicListenerId != null)
                    hashCode = hashCode * 59 + this.QuicListenerId.GetHashCode();
                if (this.EnableQuicUpgrade != null)
                    hashCode = hashCode * 59 + this.EnableQuicUpgrade.GetHashCode();
                return hashCode;
            }
        }
    }
}
