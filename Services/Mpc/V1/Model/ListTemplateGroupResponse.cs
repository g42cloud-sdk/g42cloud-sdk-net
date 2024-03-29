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
    public class ListTemplateGroupResponse : SdkResponse
    {

        [JsonProperty("template_group_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TemplateGroup> TemplateGroupList { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTemplateGroupResponse {\n");
            sb.Append("  templateGroupList: ").Append(TemplateGroupList).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTemplateGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTemplateGroupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateGroupList == input.TemplateGroupList ||
                    this.TemplateGroupList != null &&
                    input.TemplateGroupList != null &&
                    this.TemplateGroupList.SequenceEqual(input.TemplateGroupList)
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
                if (this.TemplateGroupList != null)
                    hashCode = hashCode * 59 + this.TemplateGroupList.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
