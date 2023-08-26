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
    /// 
    /// </summary>
    public class MixInfoLayout 
    {

        [JsonProperty("panes", NullValueHandling = NullValueHandling.Ignore)]
        public List<PaneSetting> Panes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MixInfoLayout {\n");
            sb.Append("  panes: ").Append(Panes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MixInfoLayout);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MixInfoLayout input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Panes == input.Panes ||
                    this.Panes != null &&
                    input.Panes != null &&
                    this.Panes.SequenceEqual(input.Panes)
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
                if (this.Panes != null)
                    hashCode = hashCode * 59 + this.Panes.GetHashCode();
                return hashCode;
            }
        }
    }
}
