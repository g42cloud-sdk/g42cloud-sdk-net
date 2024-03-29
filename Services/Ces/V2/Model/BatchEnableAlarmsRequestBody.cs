using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchEnableAlarmsRequestBody 
    {

        [JsonProperty("alarm_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlarmIds { get; set; }

        [JsonProperty("alarm_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchEnableAlarmsRequestBody {\n");
            sb.Append("  alarmIds: ").Append(AlarmIds).Append("\n");
            sb.Append("  alarmEnabled: ").Append(AlarmEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchEnableAlarmsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchEnableAlarmsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlarmIds == input.AlarmIds ||
                    this.AlarmIds != null &&
                    input.AlarmIds != null &&
                    this.AlarmIds.SequenceEqual(input.AlarmIds)
                ) && 
                (
                    this.AlarmEnabled == input.AlarmEnabled ||
                    (this.AlarmEnabled != null &&
                    this.AlarmEnabled.Equals(input.AlarmEnabled))
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
                if (this.AlarmIds != null)
                    hashCode = hashCode * 59 + this.AlarmIds.GetHashCode();
                if (this.AlarmEnabled != null)
                    hashCode = hashCode * 59 + this.AlarmEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
