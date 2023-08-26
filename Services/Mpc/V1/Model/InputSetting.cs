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
    public class InputSetting 
    {
        [JsonConverter(typeof(EnumClassConverter<AudioPolicyEnum>))]
        public class AudioPolicyEnum
        {
            /// <summary>
            /// Enum DISCARD for value: DISCARD
            /// </summary>
            public static readonly AudioPolicyEnum DISCARD = new AudioPolicyEnum("DISCARD");

            /// <summary>
            /// Enum RESERVE for value: RESERVE
            /// </summary>
            public static readonly AudioPolicyEnum RESERVE = new AudioPolicyEnum("RESERVE");

            private static readonly Dictionary<string, AudioPolicyEnum> StaticFields =
            new Dictionary<string, AudioPolicyEnum>()
            {
                { "DISCARD", DISCARD },
                { "RESERVE", RESERVE },
            };

            private string _value;

            public AudioPolicyEnum()
            {

            }

            public AudioPolicyEnum(string value)
            {
                _value = value;
            }

            public static AudioPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as AudioPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AudioPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AudioPolicyEnum a, AudioPolicyEnum b)
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

            public static bool operator !=(AudioPolicyEnum a, AudioPolicyEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Input { get; set; }

        [JsonProperty("pane_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PaneId { get; set; }

        [JsonProperty("audio_policy", NullValueHandling = NullValueHandling.Ignore)]
        public AudioPolicyEnum AudioPolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputSetting {\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  paneId: ").Append(PaneId).Append("\n");
            sb.Append("  audioPolicy: ").Append(AudioPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InputSetting);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InputSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.PaneId == input.PaneId ||
                    (this.PaneId != null &&
                    this.PaneId.Equals(input.PaneId))
                ) && 
                (
                    this.AudioPolicy == input.AudioPolicy ||
                    (this.AudioPolicy != null &&
                    this.AudioPolicy.Equals(input.AudioPolicy))
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
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.PaneId != null)
                    hashCode = hashCode * 59 + this.PaneId.GetHashCode();
                if (this.AudioPolicy != null)
                    hashCode = hashCode * 59 + this.AudioPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
