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
    public class ModifyTransTemplateGroup 
    {

        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("videos", NullValueHandling = NullValueHandling.Ignore)]
        public List<VideoObj> Videos { get; set; }

        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        public Audio Audio { get; set; }

        [JsonProperty("video_common", NullValueHandling = NullValueHandling.Ignore)]
        public VideoCommon VideoCommon { get; set; }

        [JsonProperty("common", NullValueHandling = NullValueHandling.Ignore)]
        public Common Common { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyTransTemplateGroup {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  videos: ").Append(Videos).Append("\n");
            sb.Append("  audio: ").Append(Audio).Append("\n");
            sb.Append("  videoCommon: ").Append(VideoCommon).Append("\n");
            sb.Append("  common: ").Append(Common).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyTransTemplateGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyTransTemplateGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Videos == input.Videos ||
                    this.Videos != null &&
                    input.Videos != null &&
                    this.Videos.SequenceEqual(input.Videos)
                ) && 
                (
                    this.Audio == input.Audio ||
                    (this.Audio != null &&
                    this.Audio.Equals(input.Audio))
                ) && 
                (
                    this.VideoCommon == input.VideoCommon ||
                    (this.VideoCommon != null &&
                    this.VideoCommon.Equals(input.VideoCommon))
                ) && 
                (
                    this.Common == input.Common ||
                    (this.Common != null &&
                    this.Common.Equals(input.Common))
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Videos != null)
                    hashCode = hashCode * 59 + this.Videos.GetHashCode();
                if (this.Audio != null)
                    hashCode = hashCode * 59 + this.Audio.GetHashCode();
                if (this.VideoCommon != null)
                    hashCode = hashCode * 59 + this.VideoCommon.GetHashCode();
                if (this.Common != null)
                    hashCode = hashCode * 59 + this.Common.GetHashCode();
                return hashCode;
            }
        }
    }
}
