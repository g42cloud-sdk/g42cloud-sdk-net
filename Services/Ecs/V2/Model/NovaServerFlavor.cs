using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Ecs.V2.Model
{
    /// <summary>
    ///  
    /// </summary>
    public class NovaServerFlavor 
    {

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<NovaLink> Links { get; set; }

        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public int? Vcpus { get; set; }

        [JsonProperty("ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ram { get; set; }

        [JsonProperty("disk", NullValueHandling = NullValueHandling.Ignore)]
        public int? Disk { get; set; }

        [JsonProperty("ephemeral", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ephemeral { get; set; }

        [JsonProperty("swap", NullValueHandling = NullValueHandling.Ignore)]
        public int? Swap { get; set; }

        [JsonProperty("original_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalName { get; set; }

        [JsonProperty("extra_specs", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ExtraSpecs { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaServerFlavor {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("  ram: ").Append(Ram).Append("\n");
            sb.Append("  disk: ").Append(Disk).Append("\n");
            sb.Append("  ephemeral: ").Append(Ephemeral).Append("\n");
            sb.Append("  swap: ").Append(Swap).Append("\n");
            sb.Append("  originalName: ").Append(OriginalName).Append("\n");
            sb.Append("  extraSpecs: ").Append(ExtraSpecs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaServerFlavor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaServerFlavor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.Vcpus == input.Vcpus ||
                    (this.Vcpus != null &&
                    this.Vcpus.Equals(input.Vcpus))
                ) && 
                (
                    this.Ram == input.Ram ||
                    (this.Ram != null &&
                    this.Ram.Equals(input.Ram))
                ) && 
                (
                    this.Disk == input.Disk ||
                    (this.Disk != null &&
                    this.Disk.Equals(input.Disk))
                ) && 
                (
                    this.Ephemeral == input.Ephemeral ||
                    (this.Ephemeral != null &&
                    this.Ephemeral.Equals(input.Ephemeral))
                ) && 
                (
                    this.Swap == input.Swap ||
                    (this.Swap != null &&
                    this.Swap.Equals(input.Swap))
                ) && 
                (
                    this.OriginalName == input.OriginalName ||
                    (this.OriginalName != null &&
                    this.OriginalName.Equals(input.OriginalName))
                ) && 
                (
                    this.ExtraSpecs == input.ExtraSpecs ||
                    this.ExtraSpecs != null &&
                    input.ExtraSpecs != null &&
                    this.ExtraSpecs.SequenceEqual(input.ExtraSpecs)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Vcpus != null)
                    hashCode = hashCode * 59 + this.Vcpus.GetHashCode();
                if (this.Ram != null)
                    hashCode = hashCode * 59 + this.Ram.GetHashCode();
                if (this.Disk != null)
                    hashCode = hashCode * 59 + this.Disk.GetHashCode();
                if (this.Ephemeral != null)
                    hashCode = hashCode * 59 + this.Ephemeral.GetHashCode();
                if (this.Swap != null)
                    hashCode = hashCode * 59 + this.Swap.GetHashCode();
                if (this.OriginalName != null)
                    hashCode = hashCode * 59 + this.OriginalName.GetHashCode();
                if (this.ExtraSpecs != null)
                    hashCode = hashCode * 59 + this.ExtraSpecs.GetHashCode();
                return hashCode;
            }
        }
    }
}
