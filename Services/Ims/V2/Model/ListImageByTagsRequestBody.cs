using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Ims.V2.Model
{
    /// <summary>
    /// 请求参数
    /// </summary>
    public class ListImageByTagsRequestBody 
    {
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum FILTER for value: filter
            /// </summary>
            public static readonly ActionEnum FILTER = new ActionEnum("filter");

            /// <summary>
            /// Enum COUNT for value: count
            /// </summary>
            public static readonly ActionEnum COUNT = new ActionEnum("count");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "filter", FILTER },
                { "count", COUNT },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tags> Tags { get; set; }

        [JsonProperty("tags_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tags> TagsAny { get; set; }

        [JsonProperty("not_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tags> NotTags { get; set; }

        [JsonProperty("not_tags_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tags> NotTagsAny { get; set; }

        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        [JsonProperty("matches", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagKeyValue> Matches { get; set; }

        [JsonProperty("without_any_tag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithoutAnyTag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListImageByTagsRequestBody {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  tagsAny: ").Append(TagsAny).Append("\n");
            sb.Append("  notTags: ").Append(NotTags).Append("\n");
            sb.Append("  notTagsAny: ").Append(NotTagsAny).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  matches: ").Append(Matches).Append("\n");
            sb.Append("  withoutAnyTag: ").Append(WithoutAnyTag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListImageByTagsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListImageByTagsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.TagsAny == input.TagsAny ||
                    this.TagsAny != null &&
                    input.TagsAny != null &&
                    this.TagsAny.SequenceEqual(input.TagsAny)
                ) && 
                (
                    this.NotTags == input.NotTags ||
                    this.NotTags != null &&
                    input.NotTags != null &&
                    this.NotTags.SequenceEqual(input.NotTags)
                ) && 
                (
                    this.NotTagsAny == input.NotTagsAny ||
                    this.NotTagsAny != null &&
                    input.NotTagsAny != null &&
                    this.NotTagsAny.SequenceEqual(input.NotTagsAny)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Matches == input.Matches ||
                    this.Matches != null &&
                    input.Matches != null &&
                    this.Matches.SequenceEqual(input.Matches)
                ) && 
                (
                    this.WithoutAnyTag == input.WithoutAnyTag ||
                    (this.WithoutAnyTag != null &&
                    this.WithoutAnyTag.Equals(input.WithoutAnyTag))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TagsAny != null)
                    hashCode = hashCode * 59 + this.TagsAny.GetHashCode();
                if (this.NotTags != null)
                    hashCode = hashCode * 59 + this.NotTags.GetHashCode();
                if (this.NotTagsAny != null)
                    hashCode = hashCode * 59 + this.NotTagsAny.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Matches != null)
                    hashCode = hashCode * 59 + this.Matches.GetHashCode();
                if (this.WithoutAnyTag != null)
                    hashCode = hashCode * 59 + this.WithoutAnyTag.GetHashCode();
                return hashCode;
            }
        }
    }
}
