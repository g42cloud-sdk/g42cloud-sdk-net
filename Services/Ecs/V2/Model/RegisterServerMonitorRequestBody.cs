using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class RegisterServerMonitorRequestBody 
    {
        [JsonConverter(typeof(EnumClassConverter<MonitorMetricsEnum>))]
        public class MonitorMetricsEnum
        {
            /// <summary>
            /// Enum EMPTY for value: 
            /// </summary>
            public static readonly MonitorMetricsEnum EMPTY = new MonitorMetricsEnum("");

            private static readonly Dictionary<string, MonitorMetricsEnum> StaticFields =
            new Dictionary<string, MonitorMetricsEnum>()
            {
                { "", EMPTY },
            };

            private string Value;

            public MonitorMetricsEnum(string value)
            {
                Value = value;
            }

            public static MonitorMetricsEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as MonitorMetricsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MonitorMetricsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(MonitorMetricsEnum a, MonitorMetricsEnum b)
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

            public static bool operator !=(MonitorMetricsEnum a, MonitorMetricsEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("monitorMetrics", NullValueHandling = NullValueHandling.Ignore)]
        public MonitorMetricsEnum MonitorMetrics { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterServerMonitorRequestBody {\n");
            sb.Append("  monitorMetrics: ").Append(MonitorMetrics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegisterServerMonitorRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegisterServerMonitorRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MonitorMetrics == input.MonitorMetrics ||
                    (this.MonitorMetrics != null &&
                    this.MonitorMetrics.Equals(input.MonitorMetrics))
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
                if (this.MonitorMetrics != null)
                    hashCode = hashCode * 59 + this.MonitorMetrics.GetHashCode();
                return hashCode;
            }
        }
    }
}