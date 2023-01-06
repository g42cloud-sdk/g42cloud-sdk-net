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
    /// Request Object
    /// </summary>
    public class AcceptVpcPeeringRequest 
    {

        [SDKProperty("peering_id", IsPath = true)]
        [JsonProperty("peering_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PeeringId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcceptVpcPeeringRequest {\n");
            sb.Append("  peeringId: ").Append(PeeringId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AcceptVpcPeeringRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AcceptVpcPeeringRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PeeringId == input.PeeringId ||
                    (this.PeeringId != null &&
                    this.PeeringId.Equals(input.PeeringId))
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
                if (this.PeeringId != null)
                    hashCode = hashCode * 59 + this.PeeringId.GetHashCode();
                return hashCode;
            }
        }
    }
}
