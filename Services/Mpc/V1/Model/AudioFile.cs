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
    public class AudioFile 
    {

        [JsonProperty("tracks_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<TracksInfo> TracksInfo { get; set; }

        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Input { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioFile {\n");
            sb.Append("  tracksInfo: ").Append(TracksInfo).Append("\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioFile);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioFile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TracksInfo == input.TracksInfo ||
                    this.TracksInfo != null &&
                    input.TracksInfo != null &&
                    this.TracksInfo.SequenceEqual(input.TracksInfo)
                ) && 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
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
                if (this.TracksInfo != null)
                    hashCode = hashCode * 59 + this.TracksInfo.GetHashCode();
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                return hashCode;
            }
        }
    }
}
