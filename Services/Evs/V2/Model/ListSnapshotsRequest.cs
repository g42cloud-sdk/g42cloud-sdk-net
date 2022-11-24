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
    /// Request Object
    /// </summary>
    public class ListSnapshotsRequest 
    {

        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [SDKProperty("volume_id", IsQuery = true)]
        [JsonProperty("volume_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeId { get; set; }

        [SDKProperty("availability_zone", IsQuery = true)]
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [SDKProperty("dedicated_storage_name", IsQuery = true)]
        [JsonProperty("dedicated_storage_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedStorageName { get; set; }

        [SDKProperty("dedicated_storage_id", IsQuery = true)]
        [JsonProperty("dedicated_storage_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedStorageId { get; set; }

        [SDKProperty("service_type", IsQuery = true)]
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSnapshotsRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  volumeId: ").Append(VolumeId).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  dedicatedStorageName: ").Append(DedicatedStorageName).Append("\n");
            sb.Append("  dedicatedStorageId: ").Append(DedicatedStorageId).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSnapshotsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSnapshotsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.VolumeId == input.VolumeId ||
                    (this.VolumeId != null &&
                    this.VolumeId.Equals(input.VolumeId))
                ) && 
                (
                    this.AvailabilityZone == input.AvailabilityZone ||
                    (this.AvailabilityZone != null &&
                    this.AvailabilityZone.Equals(input.AvailabilityZone))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DedicatedStorageName == input.DedicatedStorageName ||
                    (this.DedicatedStorageName != null &&
                    this.DedicatedStorageName.Equals(input.DedicatedStorageName))
                ) && 
                (
                    this.DedicatedStorageId == input.DedicatedStorageId ||
                    (this.DedicatedStorageId != null &&
                    this.DedicatedStorageId.Equals(input.DedicatedStorageId))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    (this.ServiceType != null &&
                    this.ServiceType.Equals(input.ServiceType))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VolumeId != null)
                    hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                if (this.AvailabilityZone != null)
                    hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DedicatedStorageName != null)
                    hashCode = hashCode * 59 + this.DedicatedStorageName.GetHashCode();
                if (this.DedicatedStorageId != null)
                    hashCode = hashCode * 59 + this.DedicatedStorageId.GetHashCode();
                if (this.ServiceType != null)
                    hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
