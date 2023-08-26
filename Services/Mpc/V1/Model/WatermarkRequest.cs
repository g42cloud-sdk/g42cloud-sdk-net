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
    public class WatermarkRequest 
    {

        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Input { get; set; }

        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        [JsonProperty("text_context", NullValueHandling = NullValueHandling.Ignore)]
        public string TextContext { get; set; }

        [JsonProperty("image_watermark", NullValueHandling = NullValueHandling.Ignore)]
        public ImageWatermark ImageWatermark { get; set; }

        [JsonProperty("text_watermark", NullValueHandling = NullValueHandling.Ignore)]
        public TextWatermark TextWatermark { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WatermarkRequest {\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  textContext: ").Append(TextContext).Append("\n");
            sb.Append("  imageWatermark: ").Append(ImageWatermark).Append("\n");
            sb.Append("  textWatermark: ").Append(TextWatermark).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WatermarkRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WatermarkRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.TextContext == input.TextContext ||
                    (this.TextContext != null &&
                    this.TextContext.Equals(input.TextContext))
                ) && 
                (
                    this.ImageWatermark == input.ImageWatermark ||
                    (this.ImageWatermark != null &&
                    this.ImageWatermark.Equals(input.ImageWatermark))
                ) && 
                (
                    this.TextWatermark == input.TextWatermark ||
                    (this.TextWatermark != null &&
                    this.TextWatermark.Equals(input.TextWatermark))
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
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.TextContext != null)
                    hashCode = hashCode * 59 + this.TextContext.GetHashCode();
                if (this.ImageWatermark != null)
                    hashCode = hashCode * 59 + this.ImageWatermark.GetHashCode();
                if (this.TextWatermark != null)
                    hashCode = hashCode * 59 + this.TextWatermark.GetHashCode();
                return hashCode;
            }
        }
    }
}
