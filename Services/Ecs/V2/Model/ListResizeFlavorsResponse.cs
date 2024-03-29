using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListResizeFlavorsResponse : SdkResponse
    {

        [JsonProperty("flavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListResizeFlavorsResult> Flavors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResizeFlavorsResponse {\n");
            sb.Append("  flavors: ").Append(Flavors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResizeFlavorsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResizeFlavorsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Flavors == input.Flavors ||
                    this.Flavors != null &&
                    input.Flavors != null &&
                    this.Flavors.SequenceEqual(input.Flavors)
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
                if (this.Flavors != null)
                    hashCode = hashCode * 59 + this.Flavors.GetHashCode();
                return hashCode;
            }
        }
    }
}
