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
    public class CreateThumbReq 
    {

        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Input { get; set; }

        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Output { get; set; }

        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        [JsonProperty("thumbnail_para", NullValueHandling = NullValueHandling.Ignore)]
        public ThumbnailPara ThumbnailPara { get; set; }

        [JsonProperty("tar", NullValueHandling = NullValueHandling.Ignore)]
        public int? Tar { get; set; }

        [JsonProperty("sync", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sync { get; set; }

        [JsonProperty("original_dir", NullValueHandling = NullValueHandling.Ignore)]
        public int? OriginalDir { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateThumbReq {\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  thumbnailPara: ").Append(ThumbnailPara).Append("\n");
            sb.Append("  tar: ").Append(Tar).Append("\n");
            sb.Append("  sync: ").Append(Sync).Append("\n");
            sb.Append("  originalDir: ").Append(OriginalDir).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateThumbReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateThumbReq input)
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
                    this.UserData == input.UserData ||
                    (this.UserData != null &&
                    this.UserData.Equals(input.UserData))
                ) && 
                (
                    this.ThumbnailPara == input.ThumbnailPara ||
                    (this.ThumbnailPara != null &&
                    this.ThumbnailPara.Equals(input.ThumbnailPara))
                ) && 
                (
                    this.Tar == input.Tar ||
                    (this.Tar != null &&
                    this.Tar.Equals(input.Tar))
                ) && 
                (
                    this.Sync == input.Sync ||
                    (this.Sync != null &&
                    this.Sync.Equals(input.Sync))
                ) && 
                (
                    this.OriginalDir == input.OriginalDir ||
                    (this.OriginalDir != null &&
                    this.OriginalDir.Equals(input.OriginalDir))
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
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.ThumbnailPara != null)
                    hashCode = hashCode * 59 + this.ThumbnailPara.GetHashCode();
                if (this.Tar != null)
                    hashCode = hashCode * 59 + this.Tar.GetHashCode();
                if (this.Sync != null)
                    hashCode = hashCode * 59 + this.Sync.GetHashCode();
                if (this.OriginalDir != null)
                    hashCode = hashCode * 59 + this.OriginalDir.GetHashCode();
                return hashCode;
            }
        }
    }
}
