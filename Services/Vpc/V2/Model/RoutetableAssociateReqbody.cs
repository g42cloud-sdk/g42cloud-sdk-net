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
    public class RoutetableAssociateReqbody 
    {

        [JsonProperty("routetable", NullValueHandling = NullValueHandling.Ignore)]
        public AsscoiateReq Routetable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutetableAssociateReqbody {\n");
            sb.Append("  routetable: ").Append(Routetable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RoutetableAssociateReqbody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RoutetableAssociateReqbody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Routetable == input.Routetable ||
                    (this.Routetable != null &&
                    this.Routetable.Equals(input.Routetable))
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
                if (this.Routetable != null)
                    hashCode = hashCode * 59 + this.Routetable.GetHashCode();
                return hashCode;
            }
        }
    }
}
