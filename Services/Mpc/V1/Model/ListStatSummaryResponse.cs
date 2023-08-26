using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListStatSummaryResponse : SdkResponse
    {
        [JsonConverter(typeof(EnumClassConverter<StatTypeEnum>))]
        public class StatTypeEnum
        {
            /// <summary>
            /// Enum VIDEO_DURATION for value: video_duration
            /// </summary>
            public static readonly StatTypeEnum VIDEO_DURATION = new StatTypeEnum("video_duration");

            /// <summary>
            /// Enum REMUX_FILE_DURATION for value: remux_file_duration
            /// </summary>
            public static readonly StatTypeEnum REMUX_FILE_DURATION = new StatTypeEnum("remux_file_duration");

            /// <summary>
            /// Enum TRANSCODE_TASK_NUMBER for value: transcode_task_number
            /// </summary>
            public static readonly StatTypeEnum TRANSCODE_TASK_NUMBER = new StatTypeEnum("transcode_task_number");

            /// <summary>
            /// Enum TRANSCODE_DURATION for value: transcode_duration
            /// </summary>
            public static readonly StatTypeEnum TRANSCODE_DURATION = new StatTypeEnum("transcode_duration");

            private static readonly Dictionary<string, StatTypeEnum> StaticFields =
            new Dictionary<string, StatTypeEnum>()
            {
                { "video_duration", VIDEO_DURATION },
                { "remux_file_duration", REMUX_FILE_DURATION },
                { "transcode_task_number", TRANSCODE_TASK_NUMBER },
                { "transcode_duration", TRANSCODE_DURATION },
            };

            private string _value;

            public StatTypeEnum()
            {

            }

            public StatTypeEnum(string value)
            {
                _value = value;
            }

            public static StatTypeEnum FromValue(string value)
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

                if (this.Equals(obj as StatTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatTypeEnum a, StatTypeEnum b)
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

            public static bool operator !=(StatTypeEnum a, StatTypeEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatSummary> Summary { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public float? Total { get; set; }

        [JsonProperty("stat_type", NullValueHandling = NullValueHandling.Ignore)]
        public StatTypeEnum StatType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStatSummaryResponse {\n");
            sb.Append("  summary: ").Append(Summary).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  statType: ").Append(StatType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStatSummaryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStatSummaryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Summary == input.Summary ||
                    this.Summary != null &&
                    input.Summary != null &&
                    this.Summary.SequenceEqual(input.Summary)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.StatType == input.StatType ||
                    (this.StatType != null &&
                    this.StatType.Equals(input.StatType))
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
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.StatType != null)
                    hashCode = hashCode * 59 + this.StatType.GetHashCode();
                return hashCode;
            }
        }
    }
}
