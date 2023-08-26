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
    public class CreateTranscodingReq 
    {

        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Input { get; set; }

        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Output { get; set; }

        [JsonProperty("trans_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> TransTemplateId { get; set; }

        [JsonProperty("av_parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<AvParameters> AvParameters { get; set; }

        [JsonProperty("output_filenames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OutputFilenames { get; set; }

        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        [JsonProperty("watermarks", NullValueHandling = NullValueHandling.Ignore)]
        public List<WatermarkRequest> Watermarks { get; set; }

        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Thumbnail Thumbnail { get; set; }

        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        [JsonProperty("subtitle", NullValueHandling = NullValueHandling.Ignore)]
        public Subtitle Subtitle { get; set; }

        [JsonProperty("encryption", NullValueHandling = NullValueHandling.Ignore)]
        public Encryption Encryption { get; set; }

        [JsonProperty("crop", NullValueHandling = NullValueHandling.Ignore)]
        public Crop Crop { get; set; }

        [JsonProperty("audio_track", NullValueHandling = NullValueHandling.Ignore)]
        public AudioTrack AudioTrack { get; set; }

        [JsonProperty("multi_audio", NullValueHandling = NullValueHandling.Ignore)]
        public MultiAudio MultiAudio { get; set; }

        [JsonProperty("video_process", NullValueHandling = NullValueHandling.Ignore)]
        public VideoProcess VideoProcess { get; set; }

        [JsonProperty("audio_process", NullValueHandling = NullValueHandling.Ignore)]
        public AudioProcess AudioProcess { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTranscodingReq {\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  transTemplateId: ").Append(TransTemplateId).Append("\n");
            sb.Append("  avParameters: ").Append(AvParameters).Append("\n");
            sb.Append("  outputFilenames: ").Append(OutputFilenames).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  watermarks: ").Append(Watermarks).Append("\n");
            sb.Append("  thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  encryption: ").Append(Encryption).Append("\n");
            sb.Append("  crop: ").Append(Crop).Append("\n");
            sb.Append("  audioTrack: ").Append(AudioTrack).Append("\n");
            sb.Append("  multiAudio: ").Append(MultiAudio).Append("\n");
            sb.Append("  videoProcess: ").Append(VideoProcess).Append("\n");
            sb.Append("  audioProcess: ").Append(AudioProcess).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTranscodingReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTranscodingReq input)
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
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
                ) && 
                (
                    this.TransTemplateId == input.TransTemplateId ||
                    this.TransTemplateId != null &&
                    input.TransTemplateId != null &&
                    this.TransTemplateId.SequenceEqual(input.TransTemplateId)
                ) && 
                (
                    this.AvParameters == input.AvParameters ||
                    this.AvParameters != null &&
                    input.AvParameters != null &&
                    this.AvParameters.SequenceEqual(input.AvParameters)
                ) && 
                (
                    this.OutputFilenames == input.OutputFilenames ||
                    this.OutputFilenames != null &&
                    input.OutputFilenames != null &&
                    this.OutputFilenames.SequenceEqual(input.OutputFilenames)
                ) && 
                (
                    this.UserData == input.UserData ||
                    (this.UserData != null &&
                    this.UserData.Equals(input.UserData))
                ) && 
                (
                    this.Watermarks == input.Watermarks ||
                    this.Watermarks != null &&
                    input.Watermarks != null &&
                    this.Watermarks.SequenceEqual(input.Watermarks)
                ) && 
                (
                    this.Thumbnail == input.Thumbnail ||
                    (this.Thumbnail != null &&
                    this.Thumbnail.Equals(input.Thumbnail))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Subtitle == input.Subtitle ||
                    (this.Subtitle != null &&
                    this.Subtitle.Equals(input.Subtitle))
                ) && 
                (
                    this.Encryption == input.Encryption ||
                    (this.Encryption != null &&
                    this.Encryption.Equals(input.Encryption))
                ) && 
                (
                    this.Crop == input.Crop ||
                    (this.Crop != null &&
                    this.Crop.Equals(input.Crop))
                ) && 
                (
                    this.AudioTrack == input.AudioTrack ||
                    (this.AudioTrack != null &&
                    this.AudioTrack.Equals(input.AudioTrack))
                ) && 
                (
                    this.MultiAudio == input.MultiAudio ||
                    (this.MultiAudio != null &&
                    this.MultiAudio.Equals(input.MultiAudio))
                ) && 
                (
                    this.VideoProcess == input.VideoProcess ||
                    (this.VideoProcess != null &&
                    this.VideoProcess.Equals(input.VideoProcess))
                ) && 
                (
                    this.AudioProcess == input.AudioProcess ||
                    (this.AudioProcess != null &&
                    this.AudioProcess.Equals(input.AudioProcess))
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
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.TransTemplateId != null)
                    hashCode = hashCode * 59 + this.TransTemplateId.GetHashCode();
                if (this.AvParameters != null)
                    hashCode = hashCode * 59 + this.AvParameters.GetHashCode();
                if (this.OutputFilenames != null)
                    hashCode = hashCode * 59 + this.OutputFilenames.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.Watermarks != null)
                    hashCode = hashCode * 59 + this.Watermarks.GetHashCode();
                if (this.Thumbnail != null)
                    hashCode = hashCode * 59 + this.Thumbnail.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Subtitle != null)
                    hashCode = hashCode * 59 + this.Subtitle.GetHashCode();
                if (this.Encryption != null)
                    hashCode = hashCode * 59 + this.Encryption.GetHashCode();
                if (this.Crop != null)
                    hashCode = hashCode * 59 + this.Crop.GetHashCode();
                if (this.AudioTrack != null)
                    hashCode = hashCode * 59 + this.AudioTrack.GetHashCode();
                if (this.MultiAudio != null)
                    hashCode = hashCode * 59 + this.MultiAudio.GetHashCode();
                if (this.VideoProcess != null)
                    hashCode = hashCode * 59 + this.VideoProcess.GetHashCode();
                if (this.AudioProcess != null)
                    hashCode = hashCode * 59 + this.AudioProcess.GetHashCode();
                return hashCode;
            }
        }
    }
}
