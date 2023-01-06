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
    public class NeutronCreateFirewallPolicyRequestBody 
    {

        [JsonProperty("firewall_policy", NullValueHandling = NullValueHandling.Ignore)]
        public NeutronCreateFirewallPolicyOption FirewallPolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronCreateFirewallPolicyRequestBody {\n");
            sb.Append("  firewallPolicy: ").Append(FirewallPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronCreateFirewallPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronCreateFirewallPolicyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirewallPolicy == input.FirewallPolicy ||
                    (this.FirewallPolicy != null &&
                    this.FirewallPolicy.Equals(input.FirewallPolicy))
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
                if (this.FirewallPolicy != null)
                    hashCode = hashCode * 59 + this.FirewallPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
