using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BindingVifDetails 
    {

        [JsonProperty("primary_interface", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrimaryInterface { get; set; }

        [JsonProperty("port_filter", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortFilter { get; set; }

        [JsonProperty("ovs_hybrid_plug", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OvsHybridPlug { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BindingVifDetails {\n");
            sb.Append("  primaryInterface: ").Append(PrimaryInterface).Append("\n");
            sb.Append("  portFilter: ").Append(PortFilter).Append("\n");
            sb.Append("  ovsHybridPlug: ").Append(OvsHybridPlug).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BindingVifDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BindingVifDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrimaryInterface == input.PrimaryInterface ||
                    (this.PrimaryInterface != null &&
                    this.PrimaryInterface.Equals(input.PrimaryInterface))
                ) && 
                (
                    this.PortFilter == input.PortFilter ||
                    (this.PortFilter != null &&
                    this.PortFilter.Equals(input.PortFilter))
                ) && 
                (
                    this.OvsHybridPlug == input.OvsHybridPlug ||
                    (this.OvsHybridPlug != null &&
                    this.OvsHybridPlug.Equals(input.OvsHybridPlug))
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
                if (this.PrimaryInterface != null)
                    hashCode = hashCode * 59 + this.PrimaryInterface.GetHashCode();
                if (this.PortFilter != null)
                    hashCode = hashCode * 59 + this.PortFilter.GetHashCode();
                if (this.OvsHybridPlug != null)
                    hashCode = hashCode * 59 + this.OvsHybridPlug.GetHashCode();
                return hashCode;
            }
        }
    }
}
