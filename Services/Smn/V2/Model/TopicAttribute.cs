using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TopicAttribute 
    {

        [JsonProperty("access_policy", NullValueHandling = NullValueHandling.Ignore)]
        public AccessPolicy AccessPolicy { get; set; }

        [JsonProperty("introduction", NullValueHandling = NullValueHandling.Ignore)]
        public string Introduction { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopicAttribute {\n");
            sb.Append("  accessPolicy: ").Append(AccessPolicy).Append("\n");
            sb.Append("  introduction: ").Append(Introduction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TopicAttribute);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TopicAttribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessPolicy == input.AccessPolicy ||
                    (this.AccessPolicy != null &&
                    this.AccessPolicy.Equals(input.AccessPolicy))
                ) && 
                (
                    this.Introduction == input.Introduction ||
                    (this.Introduction != null &&
                    this.Introduction.Equals(input.Introduction))
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
                if (this.AccessPolicy != null)
                    hashCode = hashCode * 59 + this.AccessPolicy.GetHashCode();
                if (this.Introduction != null)
                    hashCode = hashCode * 59 + this.Introduction.GetHashCode();
                return hashCode;
            }
        }
    }
}
