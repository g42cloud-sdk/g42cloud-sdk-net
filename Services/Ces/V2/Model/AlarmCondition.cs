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
    /// 告警触发条件
    /// </summary>
    public class AlarmCondition 
    {
        [JsonConverter(typeof(EnumClassConverter<PeriodEnum>))]
        public class PeriodEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly PeriodEnum NUMBER_0 = new PeriodEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly PeriodEnum NUMBER_1 = new PeriodEnum(1);

            /// <summary>
            /// Enum NUMBER_300 for value: 300
            /// </summary>
            public static readonly PeriodEnum NUMBER_300 = new PeriodEnum(300);

            /// <summary>
            /// Enum NUMBER_1200 for value: 1200
            /// </summary>
            public static readonly PeriodEnum NUMBER_1200 = new PeriodEnum(1200);

            /// <summary>
            /// Enum NUMBER_3600 for value: 3600
            /// </summary>
            public static readonly PeriodEnum NUMBER_3600 = new PeriodEnum(3600);

            /// <summary>
            /// Enum NUMBER_14400 for value: 14400
            /// </summary>
            public static readonly PeriodEnum NUMBER_14400 = new PeriodEnum(14400);

            /// <summary>
            /// Enum NUMBER_86400 for value: 86400
            /// </summary>
            public static readonly PeriodEnum NUMBER_86400 = new PeriodEnum(86400);

            private static readonly Dictionary<int?, PeriodEnum> StaticFields =
            new Dictionary<int?, PeriodEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 300, NUMBER_300 },
                { 1200, NUMBER_1200 },
                { 3600, NUMBER_3600 },
                { 14400, NUMBER_14400 },
                { 86400, NUMBER_86400 },
            };

            private int? _value;

            public PeriodEnum()
            {

            }

            public PeriodEnum(int? value)
            {
                _value = value;
            }

            public static PeriodEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as PeriodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PeriodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PeriodEnum a, PeriodEnum b)
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

            public static bool operator !=(PeriodEnum a, PeriodEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<SuppressDurationEnum>))]
        public class SuppressDurationEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_0 = new SuppressDurationEnum(0);

            /// <summary>
            /// Enum NUMBER_300 for value: 300
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_300 = new SuppressDurationEnum(300);

            /// <summary>
            /// Enum NUMBER_600 for value: 600
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_600 = new SuppressDurationEnum(600);

            /// <summary>
            /// Enum NUMBER_900 for value: 900
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_900 = new SuppressDurationEnum(900);

            /// <summary>
            /// Enum NUMBER_1800 for value: 1800
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_1800 = new SuppressDurationEnum(1800);

            /// <summary>
            /// Enum NUMBER_3600 for value: 3600
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_3600 = new SuppressDurationEnum(3600);

            /// <summary>
            /// Enum NUMBER_10800 for value: 10800
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_10800 = new SuppressDurationEnum(10800);

            /// <summary>
            /// Enum NUMBER_21600 for value: 21600
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_21600 = new SuppressDurationEnum(21600);

            /// <summary>
            /// Enum NUMBER_43200 for value: 43200
            /// </summary>
            public static readonly SuppressDurationEnum NUMBER_43200 = new SuppressDurationEnum(43200);

            private static readonly Dictionary<int?, SuppressDurationEnum> StaticFields =
            new Dictionary<int?, SuppressDurationEnum>()
            {
                { 0, NUMBER_0 },
                { 300, NUMBER_300 },
                { 600, NUMBER_600 },
                { 900, NUMBER_900 },
                { 1800, NUMBER_1800 },
                { 3600, NUMBER_3600 },
                { 10800, NUMBER_10800 },
                { 21600, NUMBER_21600 },
                { 43200, NUMBER_43200 },
            };

            private int? _value;

            public SuppressDurationEnum()
            {

            }

            public SuppressDurationEnum(int? value)
            {
                _value = value;
            }

            public static SuppressDurationEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as SuppressDurationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SuppressDurationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SuppressDurationEnum a, SuppressDurationEnum b)
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

            public static bool operator !=(SuppressDurationEnum a, SuppressDurationEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodEnum Period { get; set; }
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }

        [JsonProperty("comparison_operator", NullValueHandling = NullValueHandling.Ignore)]
        public string ComparisonOperator { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }

        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        [JsonProperty("suppress_duration", NullValueHandling = NullValueHandling.Ignore)]
        public SuppressDurationEnum SuppressDuration { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmCondition {\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  comparisonOperator: ").Append(ComparisonOperator).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  suppressDuration: ").Append(SuppressDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.ComparisonOperator == input.ComparisonOperator ||
                    (this.ComparisonOperator != null &&
                    this.ComparisonOperator.Equals(input.ComparisonOperator))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.SuppressDuration == input.SuppressDuration ||
                    (this.SuppressDuration != null &&
                    this.SuppressDuration.Equals(input.SuppressDuration))
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
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.ComparisonOperator != null)
                    hashCode = hashCode * 59 + this.ComparisonOperator.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.SuppressDuration != null)
                    hashCode = hashCode * 59 + this.SuppressDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
