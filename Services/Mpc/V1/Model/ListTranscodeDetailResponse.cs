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
    public class ListTranscodeDetailResponse : SdkResponse
    {

        [JsonProperty("task_array", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskDetailInfo> TaskArray { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTranscodeDetailResponse {\n");
            sb.Append("  taskArray: ").Append(TaskArray).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTranscodeDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTranscodeDetailResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskArray == input.TaskArray ||
                    this.TaskArray != null &&
                    input.TaskArray != null &&
                    this.TaskArray.SequenceEqual(input.TaskArray)
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
                return hashCode;
            }
        }
    }
}
