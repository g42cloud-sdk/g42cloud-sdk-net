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
    public class VideoCommon 
    {
        [JsonConverter(typeof(EnumClassConverter<OutputPolicyEnum>))]
        public class OutputPolicyEnum
        {
            /// <summary>
            /// Enum TRANSCODE for value: transcode
            /// </summary>
            public static readonly OutputPolicyEnum TRANSCODE = new OutputPolicyEnum("transcode");

            /// <summary>
            /// Enum DISCARD for value: discard
            /// </summary>
            public static readonly OutputPolicyEnum DISCARD = new OutputPolicyEnum("discard");

            /// <summary>
            /// Enum COPY for value: copy
            /// </summary>
            public static readonly OutputPolicyEnum COPY = new OutputPolicyEnum("copy");

            private static readonly Dictionary<string, OutputPolicyEnum> StaticFields =
            new Dictionary<string, OutputPolicyEnum>()
            {
                { "transcode", TRANSCODE },
                { "discard", DISCARD },
                { "copy", COPY },
            };

            private string _value;

            public OutputPolicyEnum()
            {

            }

            public OutputPolicyEnum(string value)
            {
                _value = value;
            }

            public static OutputPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as OutputPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OutputPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OutputPolicyEnum a, OutputPolicyEnum b)
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

            public static bool operator !=(OutputPolicyEnum a, OutputPolicyEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("output_policy", NullValueHandling = NullValueHandling.Ignore)]
        public OutputPolicyEnum OutputPolicy { get; set; }
        [JsonProperty("codec", NullValueHandling = NullValueHandling.Ignore)]
        public int? Codec { get; set; }

        [JsonProperty("profile", NullValueHandling = NullValueHandling.Ignore)]
        public int? Profile { get; set; }

        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; }

        [JsonProperty("preset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Preset { get; set; }

        [JsonProperty("max_iframes_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxIframesInterval { get; set; }

        [JsonProperty("bframes_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? BframesCount { get; set; }

        [JsonProperty("frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrameRate { get; set; }

        [JsonProperty("black_cut", NullValueHandling = NullValueHandling.Ignore)]
        public int? BlackCut { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoCommon {\n");
            sb.Append("  outputPolicy: ").Append(OutputPolicy).Append("\n");
            sb.Append("  codec: ").Append(Codec).Append("\n");
            sb.Append("  profile: ").Append(Profile).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  preset: ").Append(Preset).Append("\n");
            sb.Append("  maxIframesInterval: ").Append(MaxIframesInterval).Append("\n");
            sb.Append("  bframesCount: ").Append(BframesCount).Append("\n");
            sb.Append("  frameRate: ").Append(FrameRate).Append("\n");
            sb.Append("  blackCut: ").Append(BlackCut).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoCommon);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoCommon input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OutputPolicy == input.OutputPolicy ||
                    (this.OutputPolicy != null &&
                    this.OutputPolicy.Equals(input.OutputPolicy))
                ) && 
                (
                    this.Codec == input.Codec ||
                    (this.Codec != null &&
                    this.Codec.Equals(input.Codec))
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.Preset == input.Preset ||
                    (this.Preset != null &&
                    this.Preset.Equals(input.Preset))
                ) && 
                (
                    this.MaxIframesInterval == input.MaxIframesInterval ||
                    (this.MaxIframesInterval != null &&
                    this.MaxIframesInterval.Equals(input.MaxIframesInterval))
                ) && 
                (
                    this.BframesCount == input.BframesCount ||
                    (this.BframesCount != null &&
                    this.BframesCount.Equals(input.BframesCount))
                ) && 
                (
                    this.FrameRate == input.FrameRate ||
                    (this.FrameRate != null &&
                    this.FrameRate.Equals(input.FrameRate))
                ) && 
                (
                    this.BlackCut == input.BlackCut ||
                    (this.BlackCut != null &&
                    this.BlackCut.Equals(input.BlackCut))
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
                if (this.OutputPolicy != null)
                    hashCode = hashCode * 59 + this.OutputPolicy.GetHashCode();
                if (this.Codec != null)
                    hashCode = hashCode * 59 + this.Codec.GetHashCode();
                if (this.Profile != null)
                    hashCode = hashCode * 59 + this.Profile.GetHashCode();
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Preset != null)
                    hashCode = hashCode * 59 + this.Preset.GetHashCode();
                if (this.MaxIframesInterval != null)
                    hashCode = hashCode * 59 + this.MaxIframesInterval.GetHashCode();
                if (this.BframesCount != null)
                    hashCode = hashCode * 59 + this.BframesCount.GetHashCode();
                if (this.FrameRate != null)
                    hashCode = hashCode * 59 + this.FrameRate.GetHashCode();
                if (this.BlackCut != null)
                    hashCode = hashCode * 59 + this.BlackCut.GetHashCode();
                return hashCode;
            }
        }
    }
}
