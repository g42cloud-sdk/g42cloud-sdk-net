using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowMetricDataRequest 
    {
        [JsonConverter(typeof(EnumClassConverter<FilterEnum>))]
        public class FilterEnum
        {
            /// <summary>
            /// Enum MAX for value: max
            /// </summary>
            public static readonly FilterEnum MAX = new FilterEnum("max");

            /// <summary>
            /// Enum MIN for value: min
            /// </summary>
            public static readonly FilterEnum MIN = new FilterEnum("min");

            /// <summary>
            /// Enum AVERAGE for value: average
            /// </summary>
            public static readonly FilterEnum AVERAGE = new FilterEnum("average");

            /// <summary>
            /// Enum SUM for value: sum
            /// </summary>
            public static readonly FilterEnum SUM = new FilterEnum("sum");

            /// <summary>
            /// Enum VARIANCE for value: variance
            /// </summary>
            public static readonly FilterEnum VARIANCE = new FilterEnum("variance");

            private static readonly Dictionary<string, FilterEnum> StaticFields =
            new Dictionary<string, FilterEnum>()
            {
                { "max", MAX },
                { "min", MIN },
                { "average", AVERAGE },
                { "sum", SUM },
                { "variance", VARIANCE },
            };

            private string _value;

            public FilterEnum()
            {

            }

            public FilterEnum(string value)
            {
                _value = value;
            }

            public static FilterEnum FromValue(string value)
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

                if (this.Equals(obj as FilterEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FilterEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FilterEnum a, FilterEnum b)
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

            public static bool operator !=(FilterEnum a, FilterEnum b)
            {
                return !(a == b);
            }
        }


        [SDKProperty("Content-Type", IsHeader = true)]
        [JsonProperty("Content-Type", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }

        [SDKProperty("namespace", IsQuery = true)]
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        [SDKProperty("metric_name", IsQuery = true)]
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        [SDKProperty("dim.0", IsQuery = true)]
        [JsonProperty("dim.0", NullValueHandling = NullValueHandling.Ignore)]
        public string Dim0 { get; set; }

        [SDKProperty("dim.1", IsQuery = true)]
        [JsonProperty("dim.1", NullValueHandling = NullValueHandling.Ignore)]
        public string Dim1 { get; set; }

        [SDKProperty("dim.2", IsQuery = true)]
        [JsonProperty("dim.2", NullValueHandling = NullValueHandling.Ignore)]
        public string Dim2 { get; set; }

        [SDKProperty("dim.3", IsQuery = true)]
        [JsonProperty("dim.3", NullValueHandling = NullValueHandling.Ignore)]
        public string Dim3 { get; set; }

        [SDKProperty("filter", IsQuery = true)]
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public FilterEnum Filter { get; set; }
        [SDKProperty("period", IsQuery = true)]
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }

        [SDKProperty("from", IsQuery = true)]
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public long? From { get; set; }

        [SDKProperty("to", IsQuery = true)]
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public long? To { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMetricDataRequest {\n");
            sb.Append("  contentType: ").Append(ContentType).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  dim0: ").Append(Dim0).Append("\n");
            sb.Append("  dim1: ").Append(Dim1).Append("\n");
            sb.Append("  dim2: ").Append(Dim2).Append("\n");
            sb.Append("  dim3: ").Append(Dim3).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  to: ").Append(To).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMetricDataRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMetricDataRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.MetricName == input.MetricName ||
                    (this.MetricName != null &&
                    this.MetricName.Equals(input.MetricName))
                ) && 
                (
                    this.Dim0 == input.Dim0 ||
                    (this.Dim0 != null &&
                    this.Dim0.Equals(input.Dim0))
                ) && 
                (
                    this.Dim1 == input.Dim1 ||
                    (this.Dim1 != null &&
                    this.Dim1.Equals(input.Dim1))
                ) && 
                (
                    this.Dim2 == input.Dim2 ||
                    (this.Dim2 != null &&
                    this.Dim2.Equals(input.Dim2))
                ) && 
                (
                    this.Dim3 == input.Dim3 ||
                    (this.Dim3 != null &&
                    this.Dim3.Equals(input.Dim3))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
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
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.MetricName != null)
                    hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Dim0 != null)
                    hashCode = hashCode * 59 + this.Dim0.GetHashCode();
                if (this.Dim1 != null)
                    hashCode = hashCode * 59 + this.Dim1.GetHashCode();
                if (this.Dim2 != null)
                    hashCode = hashCode * 59 + this.Dim2.GetHashCode();
                if (this.Dim3 != null)
                    hashCode = hashCode * 59 + this.Dim3.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                return hashCode;
            }
        }
    }
}
