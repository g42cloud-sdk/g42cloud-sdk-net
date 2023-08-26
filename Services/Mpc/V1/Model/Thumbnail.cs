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
    public class Thumbnail 
    {

        [JsonProperty("tar", NullValueHandling = NullValueHandling.Ignore)]
        public int? Tar { get; set; }

        [JsonProperty("out", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Out { get; set; }

        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public ThumbnailPara Params { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Thumbnail {\n");
            sb.Append("  tar: ").Append(Tar).Append("\n");
            sb.Append("  Out: ").Append(Out).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Thumbnail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Thumbnail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tar == input.Tar ||
                    (this.Tar != null &&
                    this.Tar.Equals(input.Tar))
                ) && 
                (
                    this.Out == input.Out ||
                    (this.Out != null &&
                    this.Out.Equals(input.Out))
                ) && 
                (
                    this.Params == input.Params ||
                    (this.Params != null &&
                    this.Params.Equals(input.Params))
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
                if (this.Tar != null)
                    hashCode = hashCode * 59 + this.Tar.GetHashCode();
                if (this.Out != null)
                    hashCode = hashCode * 59 + this.Out.GetHashCode();
                if (this.Params != null)
                    hashCode = hashCode * 59 + this.Params.GetHashCode();
                return hashCode;
            }
        }
    }
}
