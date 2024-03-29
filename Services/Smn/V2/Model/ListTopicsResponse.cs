using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListTopicsResponse : SdkResponse
    {

        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        [JsonProperty("topic_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopicCount { get; set; }

        [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListTopicsItem> Topics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTopicsResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  topicCount: ").Append(TopicCount).Append("\n");
            sb.Append("  topics: ").Append(Topics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTopicsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTopicsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.TopicCount == input.TopicCount ||
                    (this.TopicCount != null &&
                    this.TopicCount.Equals(input.TopicCount))
                ) && 
                (
                    this.Topics == input.Topics ||
                    this.Topics != null &&
                    input.Topics != null &&
                    this.Topics.SequenceEqual(input.Topics)
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.TopicCount != null)
                    hashCode = hashCode * 59 + this.TopicCount.GetHashCode();
                if (this.Topics != null)
                    hashCode = hashCode * 59 + this.Topics.GetHashCode();
                return hashCode;
            }
        }
    }
}
