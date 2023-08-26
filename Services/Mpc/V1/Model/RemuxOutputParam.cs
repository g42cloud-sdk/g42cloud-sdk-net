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
    public class RemuxOutputParam 
    {

        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        [JsonProperty("segment_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? SegmentDuration { get; set; }

        [JsonProperty("remove_meta", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RemoveMeta { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemuxOutputParam {\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  segmentDuration: ").Append(SegmentDuration).Append("\n");
            sb.Append("  removeMeta: ").Append(RemoveMeta).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemuxOutputParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemuxOutputParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.SegmentDuration == input.SegmentDuration ||
                    (this.SegmentDuration != null &&
                    this.SegmentDuration.Equals(input.SegmentDuration))
                ) && 
                (
                    this.RemoveMeta == input.RemoveMeta ||
                    (this.RemoveMeta != null &&
                    this.RemoveMeta.Equals(input.RemoveMeta))
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
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.SegmentDuration != null)
                    hashCode = hashCode * 59 + this.SegmentDuration.GetHashCode();
                if (this.RemoveMeta != null)
                    hashCode = hashCode * 59 + this.RemoveMeta.GetHashCode();
                return hashCode;
            }
        }
    }
}
