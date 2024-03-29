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
    public class TracksInfo 
    {

        [JsonProperty("channel_layout", NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelLayout { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TracksInfo {\n");
            sb.Append("  channelLayout: ").Append(ChannelLayout).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TracksInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TracksInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelLayout == input.ChannelLayout ||
                    (this.ChannelLayout != null &&
                    this.ChannelLayout.Equals(input.ChannelLayout))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
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
                if (this.ChannelLayout != null)
                    hashCode = hashCode * 59 + this.ChannelLayout.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                return hashCode;
            }
        }
    }
}
