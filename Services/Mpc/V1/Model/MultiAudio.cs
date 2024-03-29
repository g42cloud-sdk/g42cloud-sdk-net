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
    public class MultiAudio 
    {

        [JsonProperty("tracks_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<TracksInfo> TracksInfo { get; set; }

        [JsonProperty("audio_files", NullValueHandling = NullValueHandling.Ignore)]
        public List<AudioFile> AudioFiles { get; set; }

        [JsonProperty("default_language", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultLanguage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiAudio {\n");
            sb.Append("  tracksInfo: ").Append(TracksInfo).Append("\n");
            sb.Append("  audioFiles: ").Append(AudioFiles).Append("\n");
            sb.Append("  defaultLanguage: ").Append(DefaultLanguage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MultiAudio);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MultiAudio input)
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
                    this.AudioFiles == input.AudioFiles ||
                    this.AudioFiles != null &&
                    input.AudioFiles != null &&
                    this.AudioFiles.SequenceEqual(input.AudioFiles)
                ) && 
                (
                    this.DefaultLanguage == input.DefaultLanguage ||
                    (this.DefaultLanguage != null &&
                    this.DefaultLanguage.Equals(input.DefaultLanguage))
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
                if (this.AudioFiles != null)
                    hashCode = hashCode * 59 + this.AudioFiles.GetHashCode();
                if (this.DefaultLanguage != null)
                    hashCode = hashCode * 59 + this.DefaultLanguage.GetHashCode();
                return hashCode;
            }
        }
    }
}
