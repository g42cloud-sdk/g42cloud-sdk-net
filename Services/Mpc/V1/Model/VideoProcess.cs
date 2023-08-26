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
    /// 
    /// </summary>
    public class VideoProcess 
    {
        [JsonConverter(typeof(EnumClassConverter<AdaptationEnum>))]
        public class AdaptationEnum
        {
            /// <summary>
            /// Enum SHORT for value: SHORT
            /// </summary>
            public static readonly AdaptationEnum SHORT = new AdaptationEnum("SHORT");

            /// <summary>
            /// Enum LONG for value: LONG
            /// </summary>
            public static readonly AdaptationEnum LONG = new AdaptationEnum("LONG");

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            public static readonly AdaptationEnum NONE = new AdaptationEnum("NONE");

            private static readonly Dictionary<string, AdaptationEnum> StaticFields =
            new Dictionary<string, AdaptationEnum>()
            {
                { "SHORT", SHORT },
                { "LONG", LONG },
                { "NONE", NONE },
            };

            private string _value;

            public AdaptationEnum()
            {

            }

            public AdaptationEnum(string value)
            {
                _value = value;
            }

            public static AdaptationEnum FromValue(string value)
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

                if (this.Equals(obj as AdaptationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AdaptationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AdaptationEnum a, AdaptationEnum b)
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

            public static bool operator !=(AdaptationEnum a, AdaptationEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("hls_init_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? HlsInitCount { get; set; }

        [JsonProperty("hls_init_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? HlsInitInterval { get; set; }

        [JsonProperty("rotate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rotate { get; set; }

        [JsonProperty("adaptation", NullValueHandling = NullValueHandling.Ignore)]
        public AdaptationEnum Adaptation { get; set; }
        [JsonProperty("upsample", NullValueHandling = NullValueHandling.Ignore)]
        public int? Upsample { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoProcess {\n");
            sb.Append("  hlsInitCount: ").Append(HlsInitCount).Append("\n");
            sb.Append("  hlsInitInterval: ").Append(HlsInitInterval).Append("\n");
            sb.Append("  rotate: ").Append(Rotate).Append("\n");
            sb.Append("  adaptation: ").Append(Adaptation).Append("\n");
            sb.Append("  upsample: ").Append(Upsample).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoProcess);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoProcess input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HlsInitCount == input.HlsInitCount ||
                    (this.HlsInitCount != null &&
                    this.HlsInitCount.Equals(input.HlsInitCount))
                ) && 
                (
                    this.HlsInitInterval == input.HlsInitInterval ||
                    (this.HlsInitInterval != null &&
                    this.HlsInitInterval.Equals(input.HlsInitInterval))
                ) && 
                (
                    this.Rotate == input.Rotate ||
                    (this.Rotate != null &&
                    this.Rotate.Equals(input.Rotate))
                ) && 
                (
                    this.Adaptation == input.Adaptation ||
                    (this.Adaptation != null &&
                    this.Adaptation.Equals(input.Adaptation))
                ) && 
                (
                    this.Upsample == input.Upsample ||
                    (this.Upsample != null &&
                    this.Upsample.Equals(input.Upsample))
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
                if (this.HlsInitCount != null)
                    hashCode = hashCode * 59 + this.HlsInitCount.GetHashCode();
                if (this.HlsInitInterval != null)
                    hashCode = hashCode * 59 + this.HlsInitInterval.GetHashCode();
                if (this.Rotate != null)
                    hashCode = hashCode * 59 + this.Rotate.GetHashCode();
                if (this.Adaptation != null)
                    hashCode = hashCode * 59 + this.Adaptation.GetHashCode();
                if (this.Upsample != null)
                    hashCode = hashCode * 59 + this.Upsample.GetHashCode();
                return hashCode;
            }
        }
    }
}
