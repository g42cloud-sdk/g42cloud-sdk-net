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
    public class ShowResetPasswordFlagResponse : SdkResponse
    {

        [JsonProperty("resetpwd_flag", NullValueHandling = NullValueHandling.Ignore)]
        public string ResetpwdFlag { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowResetPasswordFlagResponse {\n");
            sb.Append("  resetpwdFlag: ").Append(ResetpwdFlag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowResetPasswordFlagResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowResetPasswordFlagResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResetpwdFlag == input.ResetpwdFlag ||
                    (this.ResetpwdFlag != null &&
                    this.ResetpwdFlag.Equals(input.ResetpwdFlag))
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
                if (this.ResetpwdFlag != null)
                    hashCode = hashCode * 59 + this.ResetpwdFlag.GetHashCode();
                return hashCode;
            }
        }
    }
}
