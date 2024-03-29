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
    /// 云硬盘挂载信息。
    /// </summary>
    public class Attachment 
    {

        [JsonProperty("attached_at", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedAt { get; set; }

        [JsonProperty("attachment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachmentId { get; set; }

        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        [JsonProperty("host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        [JsonProperty("volume_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attachment {\n");
            sb.Append("  attachedAt: ").Append(AttachedAt).Append("\n");
            sb.Append("  attachmentId: ").Append(AttachmentId).Append("\n");
            sb.Append("  device: ").Append(Device).Append("\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  volumeId: ").Append(VolumeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Attachment);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Attachment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttachedAt == input.AttachedAt ||
                    (this.AttachedAt != null &&
                    this.AttachedAt.Equals(input.AttachedAt))
                ) && 
                (
                    this.AttachmentId == input.AttachmentId ||
                    (this.AttachmentId != null &&
                    this.AttachmentId.Equals(input.AttachmentId))
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
                ) && 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ServerId == input.ServerId ||
                    (this.ServerId != null &&
                    this.ServerId.Equals(input.ServerId))
                ) && 
                (
                    this.VolumeId == input.VolumeId ||
                    (this.VolumeId != null &&
                    this.VolumeId.Equals(input.VolumeId))
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
                if (this.AttachedAt != null)
                    hashCode = hashCode * 59 + this.AttachedAt.GetHashCode();
                if (this.AttachmentId != null)
                    hashCode = hashCode * 59 + this.AttachmentId.GetHashCode();
                if (this.Device != null)
                    hashCode = hashCode * 59 + this.Device.GetHashCode();
                if (this.HostName != null)
                    hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ServerId != null)
                    hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.VolumeId != null)
                    hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                return hashCode;
            }
        }
    }
}
