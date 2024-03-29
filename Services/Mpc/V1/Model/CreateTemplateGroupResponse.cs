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
    public class CreateTemplateGroupResponse : SdkResponse
    {

        [JsonProperty("template_group", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateGroup TemplateGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTemplateGroupResponse {\n");
            sb.Append("  templateGroup: ").Append(TemplateGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTemplateGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTemplateGroupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateGroup == input.TemplateGroup ||
                    (this.TemplateGroup != null &&
                    this.TemplateGroup.Equals(input.TemplateGroup))
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
                if (this.TemplateGroup != null)
                    hashCode = hashCode * 59 + this.TemplateGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
