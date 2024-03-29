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
    public class QualityEnhanceVideo 
    {

        [JsonProperty("video_denoise", NullValueHandling = NullValueHandling.Ignore)]
        public VideoDenoise VideoDenoise { get; set; }

        [JsonProperty("video_sharp", NullValueHandling = NullValueHandling.Ignore)]
        public VideoSharp VideoSharp { get; set; }

        [JsonProperty("video_contrast", NullValueHandling = NullValueHandling.Ignore)]
        public VideoContrast VideoContrast { get; set; }

        [JsonProperty("video_superresolution", NullValueHandling = NullValueHandling.Ignore)]
        public VideoSuperresolution VideoSuperresolution { get; set; }

        [JsonProperty("video_deblock", NullValueHandling = NullValueHandling.Ignore)]
        public VideoDeblock VideoDeblock { get; set; }

        [JsonProperty("video_saturation", NullValueHandling = NullValueHandling.Ignore)]
        public VideoSaturation VideoSaturation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QualityEnhanceVideo {\n");
            sb.Append("  videoDenoise: ").Append(VideoDenoise).Append("\n");
            sb.Append("  videoSharp: ").Append(VideoSharp).Append("\n");
            sb.Append("  videoContrast: ").Append(VideoContrast).Append("\n");
            sb.Append("  videoSuperresolution: ").Append(VideoSuperresolution).Append("\n");
            sb.Append("  videoDeblock: ").Append(VideoDeblock).Append("\n");
            sb.Append("  videoSaturation: ").Append(VideoSaturation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QualityEnhanceVideo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QualityEnhanceVideo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VideoDenoise == input.VideoDenoise ||
                    (this.VideoDenoise != null &&
                    this.VideoDenoise.Equals(input.VideoDenoise))
                ) && 
                (
                    this.VideoSharp == input.VideoSharp ||
                    (this.VideoSharp != null &&
                    this.VideoSharp.Equals(input.VideoSharp))
                ) && 
                (
                    this.VideoContrast == input.VideoContrast ||
                    (this.VideoContrast != null &&
                    this.VideoContrast.Equals(input.VideoContrast))
                ) && 
                (
                    this.VideoSuperresolution == input.VideoSuperresolution ||
                    (this.VideoSuperresolution != null &&
                    this.VideoSuperresolution.Equals(input.VideoSuperresolution))
                ) && 
                (
                    this.VideoDeblock == input.VideoDeblock ||
                    (this.VideoDeblock != null &&
                    this.VideoDeblock.Equals(input.VideoDeblock))
                ) && 
                (
                    this.VideoSaturation == input.VideoSaturation ||
                    (this.VideoSaturation != null &&
                    this.VideoSaturation.Equals(input.VideoSaturation))
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
                if (this.VideoDenoise != null)
                    hashCode = hashCode * 59 + this.VideoDenoise.GetHashCode();
                if (this.VideoSharp != null)
                    hashCode = hashCode * 59 + this.VideoSharp.GetHashCode();
                if (this.VideoContrast != null)
                    hashCode = hashCode * 59 + this.VideoContrast.GetHashCode();
                if (this.VideoSuperresolution != null)
                    hashCode = hashCode * 59 + this.VideoSuperresolution.GetHashCode();
                if (this.VideoDeblock != null)
                    hashCode = hashCode * 59 + this.VideoDeblock.GetHashCode();
                if (this.VideoSaturation != null)
                    hashCode = hashCode * 59 + this.VideoSaturation.GetHashCode();
                return hashCode;
            }
        }
    }
}
