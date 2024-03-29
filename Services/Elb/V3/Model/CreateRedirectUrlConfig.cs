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
    /// 转发到的url配置。  当监听器的高级转发策略功能（enhance_l7policy_enable）开启后才会生效，未开启传入该字段会报错。  当action为REDIRECT_TO_URL时生效，且为必选字段，其他action不可指定，否则报错。  格式：protocol://host:port/path?query  protocol、host、port、path不允许同时不传或同时传${xxx} （${xxx}表示原值，如${host}表示被转发的请求URL的host部分）。 protocol和port传入的值不能与l7policy关联的监听器一致且host、path同时不传或同时传${xxx}。   [共享型负载均衡器下的转发策略不支持该字段，传入会报错。 ](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,fcs,dt)  [不支持该字段，请勿使用。](tag:hcso_dt)
    /// </summary>
    public class CreateRedirectUrlConfig 
    {
        [JsonConverter(typeof(EnumClassConverter<ProtocolEnum>))]
        public class ProtocolEnum
        {
            /// <summary>
            /// Enum HTTP for value: HTTP
            /// </summary>
            public static readonly ProtocolEnum HTTP = new ProtocolEnum("HTTP");

            /// <summary>
            /// Enum HTTPS for value: HTTPS
            /// </summary>
            public static readonly ProtocolEnum HTTPS = new ProtocolEnum("HTTPS");

            /// <summary>
            /// Enum _PROTOCOL_ for value: ${protocol}
            /// </summary>
            public static readonly ProtocolEnum _PROTOCOL_ = new ProtocolEnum("${protocol}");

            private static readonly Dictionary<string, ProtocolEnum> StaticFields =
            new Dictionary<string, ProtocolEnum>()
            {
                { "HTTP", HTTP },
                { "HTTPS", HTTPS },
                { "${protocol}", _PROTOCOL_ },
            };

            private string _value;

            public ProtocolEnum()
            {

            }

            public ProtocolEnum(string value)
            {
                _value = value;
            }

            public static ProtocolEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ProtocolEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtocolEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtocolEnum a, ProtocolEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ProtocolEnum a, ProtocolEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<StatusCodeEnum>))]
        public class StatusCodeEnum
        {
            /// <summary>
            /// Enum _301 for value: 301
            /// </summary>
            public static readonly StatusCodeEnum _301 = new StatusCodeEnum("301");

            /// <summary>
            /// Enum _302 for value: 302
            /// </summary>
            public static readonly StatusCodeEnum _302 = new StatusCodeEnum("302");

            /// <summary>
            /// Enum _303 for value: 303
            /// </summary>
            public static readonly StatusCodeEnum _303 = new StatusCodeEnum("303");

            /// <summary>
            /// Enum _307 for value: 307
            /// </summary>
            public static readonly StatusCodeEnum _307 = new StatusCodeEnum("307");

            /// <summary>
            /// Enum _308 for value: 308
            /// </summary>
            public static readonly StatusCodeEnum _308 = new StatusCodeEnum("308");

            private static readonly Dictionary<string, StatusCodeEnum> StaticFields =
            new Dictionary<string, StatusCodeEnum>()
            {
                { "301", _301 },
                { "302", _302 },
                { "303", _303 },
                { "307", _307 },
                { "308", _308 },
            };

            private string _value;

            public StatusCodeEnum()
            {

            }

            public StatusCodeEnum(string value)
            {
                _value = value;
            }

            public static StatusCodeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as StatusCodeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusCodeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusCodeEnum a, StatusCodeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(StatusCodeEnum a, StatusCodeEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolEnum Protocol { get; set; }
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        [JsonProperty("status_code", NullValueHandling = NullValueHandling.Ignore)]
        public StatusCodeEnum StatusCode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRedirectUrlConfig {\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  host: ").Append(Host).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("  statusCode: ").Append(StatusCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRedirectUrlConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRedirectUrlConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
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
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
