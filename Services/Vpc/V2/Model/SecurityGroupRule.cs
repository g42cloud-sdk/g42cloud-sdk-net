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
    public class SecurityGroupRule 
    {

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        [JsonProperty("ethertype", NullValueHandling = NullValueHandling.Ignore)]
        public string Ethertype { get; set; }

        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        [JsonProperty("port_range_min", NullValueHandling = NullValueHandling.Ignore)]
        public int? PortRangeMin { get; set; }

        [JsonProperty("port_range_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? PortRangeMax { get; set; }

        [JsonProperty("remote_ip_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteIpPrefix { get; set; }

        [JsonProperty("remote_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteGroupId { get; set; }

        [JsonProperty("remote_address_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteAddressGroupId { get; set; }

        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityGroupRule {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  ethertype: ").Append(Ethertype).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  portRangeMin: ").Append(PortRangeMin).Append("\n");
            sb.Append("  portRangeMax: ").Append(PortRangeMax).Append("\n");
            sb.Append("  remoteIpPrefix: ").Append(RemoteIpPrefix).Append("\n");
            sb.Append("  remoteGroupId: ").Append(RemoteGroupId).Append("\n");
            sb.Append("  remoteAddressGroupId: ").Append(RemoteAddressGroupId).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SecurityGroupRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SecurityGroupRule input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SecurityGroupId == input.SecurityGroupId ||
                    (this.SecurityGroupId != null &&
                    this.SecurityGroupId.Equals(input.SecurityGroupId))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Ethertype == input.Ethertype ||
                    (this.Ethertype != null &&
                    this.Ethertype.Equals(input.Ethertype))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.PortRangeMin == input.PortRangeMin ||
                    (this.PortRangeMin != null &&
                    this.PortRangeMin.Equals(input.PortRangeMin))
                ) && 
                (
                    this.PortRangeMax == input.PortRangeMax ||
                    (this.PortRangeMax != null &&
                    this.PortRangeMax.Equals(input.PortRangeMax))
                ) && 
                (
                    this.RemoteIpPrefix == input.RemoteIpPrefix ||
                    (this.RemoteIpPrefix != null &&
                    this.RemoteIpPrefix.Equals(input.RemoteIpPrefix))
                ) && 
                (
                    this.RemoteGroupId == input.RemoteGroupId ||
                    (this.RemoteGroupId != null &&
                    this.RemoteGroupId.Equals(input.RemoteGroupId))
                ) && 
                (
                    this.RemoteAddressGroupId == input.RemoteAddressGroupId ||
                    (this.RemoteAddressGroupId != null &&
                    this.RemoteAddressGroupId.Equals(input.RemoteAddressGroupId))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Ethertype != null)
                    hashCode = hashCode * 59 + this.Ethertype.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.PortRangeMin != null)
                    hashCode = hashCode * 59 + this.PortRangeMin.GetHashCode();
                if (this.PortRangeMax != null)
                    hashCode = hashCode * 59 + this.PortRangeMax.GetHashCode();
                if (this.RemoteIpPrefix != null)
                    hashCode = hashCode * 59 + this.RemoteIpPrefix.GetHashCode();
                if (this.RemoteGroupId != null)
                    hashCode = hashCode * 59 + this.RemoteGroupId.GetHashCode();
                if (this.RemoteAddressGroupId != null)
                    hashCode = hashCode * 59 + this.RemoteAddressGroupId.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }
    }
}
