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
    /// Response Object
    /// </summary>
    public class UpdateVolumeResponse : SdkResponse
    {

        [JsonProperty("attachments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Attachment> Attachments { get; set; }

        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        [JsonProperty("bootable", NullValueHandling = NullValueHandling.Ignore)]
        public string Bootable { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Link> Links { get; set; }

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeMetadata Metadata { get; set; }

        [JsonProperty("multiattach", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multiattach { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("os-vol-host-attr:host", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVolHostAttrhost { get; set; }

        [JsonProperty("os-vol-tenant-attr:tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVolTenantAttrtenantId { get; set; }

        [JsonProperty("shareable", NullValueHandling = NullValueHandling.Ignore)]
        public string Shareable { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        [JsonProperty("snapshot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotId { get; set; }

        [JsonProperty("source_volid", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceVolid { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("volume_image_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Object VolumeImageMetadata { get; set; }

        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeType { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("os-volume-replication:extended_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVolumeReplicationextendedStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateVolumeResponse {\n");
            sb.Append("  attachments: ").Append(Attachments).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  bootable: ").Append(Bootable).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  multiattach: ").Append(Multiattach).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  osVolHostAttrhost: ").Append(OsVolHostAttrhost).Append("\n");
            sb.Append("  osVolTenantAttrtenantId: ").Append(OsVolTenantAttrtenantId).Append("\n");
            sb.Append("  shareable: ").Append(Shareable).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  snapshotId: ").Append(SnapshotId).Append("\n");
            sb.Append("  sourceVolid: ").Append(SourceVolid).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  volumeImageMetadata: ").Append(VolumeImageMetadata).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  osVolumeReplicationextendedStatus: ").Append(OsVolumeReplicationextendedStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateVolumeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateVolumeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.AvailabilityZone == input.AvailabilityZone ||
                    (this.AvailabilityZone != null &&
                    this.AvailabilityZone.Equals(input.AvailabilityZone))
                ) && 
                (
                    this.Bootable == input.Bootable ||
                    (this.Bootable != null &&
                    this.Bootable.Equals(input.Bootable))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
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
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Multiattach == input.Multiattach ||
                    (this.Multiattach != null &&
                    this.Multiattach.Equals(input.Multiattach))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OsVolHostAttrhost == input.OsVolHostAttrhost ||
                    (this.OsVolHostAttrhost != null &&
                    this.OsVolHostAttrhost.Equals(input.OsVolHostAttrhost))
                ) && 
                (
                    this.OsVolTenantAttrtenantId == input.OsVolTenantAttrtenantId ||
                    (this.OsVolTenantAttrtenantId != null &&
                    this.OsVolTenantAttrtenantId.Equals(input.OsVolTenantAttrtenantId))
                ) && 
                (
                    this.Shareable == input.Shareable ||
                    (this.Shareable != null &&
                    this.Shareable.Equals(input.Shareable))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.SnapshotId == input.SnapshotId ||
                    (this.SnapshotId != null &&
                    this.SnapshotId.Equals(input.SnapshotId))
                ) && 
                (
                    this.SourceVolid == input.SourceVolid ||
                    (this.SourceVolid != null &&
                    this.SourceVolid.Equals(input.SourceVolid))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.VolumeImageMetadata == input.VolumeImageMetadata ||
                    (this.VolumeImageMetadata != null &&
                    this.VolumeImageMetadata.Equals(input.VolumeImageMetadata))
                ) && 
                (
                    this.VolumeType == input.VolumeType ||
                    (this.VolumeType != null &&
                    this.VolumeType.Equals(input.VolumeType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.OsVolumeReplicationextendedStatus == input.OsVolumeReplicationextendedStatus ||
                    (this.OsVolumeReplicationextendedStatus != null &&
                    this.OsVolumeReplicationextendedStatus.Equals(input.OsVolumeReplicationextendedStatus))
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
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.AvailabilityZone != null)
                    hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.Bootable != null)
                    hashCode = hashCode * 59 + this.Bootable.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Multiattach != null)
                    hashCode = hashCode * 59 + this.Multiattach.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OsVolHostAttrhost != null)
                    hashCode = hashCode * 59 + this.OsVolHostAttrhost.GetHashCode();
                if (this.OsVolTenantAttrtenantId != null)
                    hashCode = hashCode * 59 + this.OsVolTenantAttrtenantId.GetHashCode();
                if (this.Shareable != null)
                    hashCode = hashCode * 59 + this.Shareable.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.SnapshotId != null)
                    hashCode = hashCode * 59 + this.SnapshotId.GetHashCode();
                if (this.SourceVolid != null)
                    hashCode = hashCode * 59 + this.SourceVolid.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VolumeImageMetadata != null)
                    hashCode = hashCode * 59 + this.VolumeImageMetadata.GetHashCode();
                if (this.VolumeType != null)
                    hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.OsVolumeReplicationextendedStatus != null)
                    hashCode = hashCode * 59 + this.OsVolumeReplicationextendedStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
