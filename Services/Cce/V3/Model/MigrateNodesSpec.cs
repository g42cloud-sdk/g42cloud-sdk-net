using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MigrateNodesSpec 
    {

        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public MigrateNodeExtendParam ExtendParam { get; set; }

        [JsonProperty("login", NullValueHandling = NullValueHandling.Ignore)]
        public Login Login { get; set; }

        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodeItem> Nodes { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrateNodesSpec {\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("  login: ").Append(Login).Append("\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrateNodesSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrateNodesSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.ExtendParam == input.ExtendParam ||
                    (this.ExtendParam != null &&
                    this.ExtendParam.Equals(input.ExtendParam))
                ) && 
                (
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
                ) && 
                (
                    this.Nodes == input.Nodes ||
                    this.Nodes != null &&
                    input.Nodes != null &&
                    this.Nodes.SequenceEqual(input.Nodes)
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
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.ExtendParam != null)
                    hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                if (this.Login != null)
                    hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.Nodes != null)
                    hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
