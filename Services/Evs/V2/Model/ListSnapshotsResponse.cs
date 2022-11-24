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
    /// Response Object
    /// </summary>
    public class ListSnapshotsResponse : SdkResponse
    {

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        [JsonProperty("snapshots", NullValueHandling = NullValueHandling.Ignore)]
        public List<SnapshotList> Snapshots { get; set; }

        [JsonProperty("snapshots_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Link> SnapshotsLinks { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSnapshotsResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  snapshots: ").Append(Snapshots).Append("\n");
            sb.Append("  snapshotsLinks: ").Append(SnapshotsLinks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSnapshotsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSnapshotsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Snapshots == input.Snapshots ||
                    this.Snapshots != null &&
                    input.Snapshots != null &&
                    this.Snapshots.SequenceEqual(input.Snapshots)
                ) && 
                (
                    this.SnapshotsLinks == input.SnapshotsLinks ||
                    this.SnapshotsLinks != null &&
                    input.SnapshotsLinks != null &&
                    this.SnapshotsLinks.SequenceEqual(input.SnapshotsLinks)
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Snapshots != null)
                    hashCode = hashCode * 59 + this.Snapshots.GetHashCode();
                if (this.SnapshotsLinks != null)
                    hashCode = hashCode * 59 + this.SnapshotsLinks.GetHashCode();
                return hashCode;
            }
        }
    }
}