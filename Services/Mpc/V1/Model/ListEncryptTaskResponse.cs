using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListEncryptTaskResponse : SdkResponse
    {

        [JsonProperty("task_array", NullValueHandling = NullValueHandling.Ignore)]
        public List<EachEncryptRsp> TaskArray { get; set; }

        [JsonProperty("is_truncated", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsTruncated { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEncryptTaskResponse {\n");
            sb.Append("  taskArray: ").Append(TaskArray).Append("\n");
            sb.Append("  isTruncated: ").Append(IsTruncated).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEncryptTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEncryptTaskResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskArray == input.TaskArray ||
                    this.TaskArray != null &&
                    input.TaskArray != null &&
                    this.TaskArray.SequenceEqual(input.TaskArray)
                ) && 
                (
                    this.IsTruncated == input.IsTruncated ||
                    (this.IsTruncated != null &&
                    this.IsTruncated.Equals(input.IsTruncated))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.TaskArray != null)
                    hashCode = hashCode * 59 + this.TaskArray.GetHashCode();
                if (this.IsTruncated != null)
                    hashCode = hashCode * 59 + this.IsTruncated.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
