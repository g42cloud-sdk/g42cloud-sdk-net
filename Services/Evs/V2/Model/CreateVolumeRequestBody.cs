using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class CreateVolumeRequestBody 
    {

        [JsonProperty("bssParam", NullValueHandling = NullValueHandling.Ignore)]
        public BssParamForCreateVolume BssParam { get; set; }

        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public CreateVolumeOption Volume { get; set; }

        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        [JsonProperty("OS-SCH-HNT:scheduler_hints", NullValueHandling = NullValueHandling.Ignore)]
        public CreateVolumeSchedulerHints OSSCHHNTschedulerHints { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVolumeRequestBody {\n");
            sb.Append("  bssParam: ").Append(BssParam).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  oSSCHHNTschedulerHints: ").Append(OSSCHHNTschedulerHints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateVolumeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateVolumeRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BssParam == input.BssParam ||
                    (this.BssParam != null &&
                    this.BssParam.Equals(input.BssParam))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.ServerId == input.ServerId ||
                    (this.ServerId != null &&
                    this.ServerId.Equals(input.ServerId))
                ) && 
                (
                    this.OSSCHHNTschedulerHints == input.OSSCHHNTschedulerHints ||
                    (this.OSSCHHNTschedulerHints != null &&
                    this.OSSCHHNTschedulerHints.Equals(input.OSSCHHNTschedulerHints))
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
                if (this.BssParam != null)
                    hashCode = hashCode * 59 + this.BssParam.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.ServerId != null)
                    hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.OSSCHHNTschedulerHints != null)
                    hashCode = hashCode * 59 + this.OSSCHHNTschedulerHints.GetHashCode();
                return hashCode;
            }
        }
    }
}
