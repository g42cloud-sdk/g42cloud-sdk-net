using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Runtime 
    {
        [JsonConverter(typeof(EnumClassConverter<NameEnum>))]
        public class NameEnum
        {
            /// <summary>
            /// Enum DOCKER for value: docker
            /// </summary>
            public static readonly NameEnum DOCKER = new NameEnum("docker");

            /// <summary>
            /// Enum CONTAINERD for value: containerd
            /// </summary>
            public static readonly NameEnum CONTAINERD = new NameEnum("containerd");

            private static readonly Dictionary<string, NameEnum> StaticFields =
            new Dictionary<string, NameEnum>()
            {
                { "docker", DOCKER },
                { "containerd", CONTAINERD },
            };

            private string _value;

            public NameEnum()
            {

            }

            public NameEnum(string value)
            {
                _value = value;
            }

            public static NameEnum FromValue(string value)
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

                if (this.Equals(obj as NameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NameEnum a, NameEnum b)
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

            public static bool operator !=(NameEnum a, NameEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public NameEnum Name { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Runtime {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Runtime);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Runtime input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
