using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// GPSSD类型云硬盘预留的云硬盘个数，键值对，包含：reserved（预留）、limit（最大）和in_use（已使用）。
    /// </summary>
    public class QuotaDetailVolumesGPSSD 
    {

        [JsonProperty("in_use", NullValueHandling = NullValueHandling.Ignore)]
        public int? InUse { get; set; }

        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        [JsonProperty("reserved", NullValueHandling = NullValueHandling.Ignore)]
        public int? Reserved { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotaDetailVolumesGPSSD {\n");
            sb.Append("  inUse: ").Append(InUse).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  reserved: ").Append(Reserved).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuotaDetailVolumesGPSSD);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuotaDetailVolumesGPSSD input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InUse == input.InUse ||
                    (this.InUse != null &&
                    this.InUse.Equals(input.InUse))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Reserved == input.Reserved ||
                    (this.Reserved != null &&
                    this.Reserved.Equals(input.Reserved))
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
                if (this.InUse != null)
                    hashCode = hashCode * 59 + this.InUse.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Reserved != null)
                    hashCode = hashCode * 59 + this.Reserved.GetHashCode();
                return hashCode;
            }
        }
    }
}