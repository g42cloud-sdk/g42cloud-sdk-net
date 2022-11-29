using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateAlarmRequestBody 
    {
        [JsonConverter(typeof(EnumClassConverter<AlarmTypeEnum>))]
        public class AlarmTypeEnum
        {
            /// <summary>
            /// Enum EVENT_SYS for value: EVENT.SYS
            /// </summary>
            public static readonly AlarmTypeEnum EVENT_SYS = new AlarmTypeEnum("EVENT.SYS");

            /// <summary>
            /// Enum EVENT_CUSTOM for value: EVENT.CUSTOM
            /// </summary>
            public static readonly AlarmTypeEnum EVENT_CUSTOM = new AlarmTypeEnum("EVENT.CUSTOM");

            /// <summary>
            /// Enum RESOURCE_GROUP for value: RESOURCE_GROUP
            /// </summary>
            public static readonly AlarmTypeEnum RESOURCE_GROUP = new AlarmTypeEnum("RESOURCE_GROUP");

            private static readonly Dictionary<string, AlarmTypeEnum> StaticFields =
            new Dictionary<string, AlarmTypeEnum>()
            {
                { "EVENT.SYS", EVENT_SYS },
                { "EVENT.CUSTOM", EVENT_CUSTOM },
                { "RESOURCE_GROUP", RESOURCE_GROUP },
            };

            private string Value;

            public AlarmTypeEnum(string value)
            {
                Value = value;
            }

            public static AlarmTypeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as AlarmTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AlarmTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(AlarmTypeEnum a, AlarmTypeEnum b)
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

            public static bool operator !=(AlarmTypeEnum a, AlarmTypeEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("alarm_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmName { get; set; }

        [JsonProperty("alarm_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmDescription { get; set; }

        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public MetricForAlarm Metric { get; set; }

        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public Condition Condition { get; set; }

        [JsonProperty("alarm_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmEnabled { get; set; }

        [JsonProperty("alarm_action_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmActionEnabled { get; set; }

        [JsonProperty("alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlarmLevel { get; set; }

        [JsonProperty("alarm_type", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmTypeEnum AlarmType { get; set; }
        [JsonProperty("alarm_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmActions> AlarmActions { get; set; }

        [JsonProperty("insufficientdata_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmActions> InsufficientdataActions { get; set; }

        [JsonProperty("ok_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmActions> OkActions { get; set; }

        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAlarmRequestBody {\n");
            sb.Append("  alarmName: ").Append(AlarmName).Append("\n");
            sb.Append("  alarmDescription: ").Append(AlarmDescription).Append("\n");
            sb.Append("  metric: ").Append(Metric).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  alarmEnabled: ").Append(AlarmEnabled).Append("\n");
            sb.Append("  alarmActionEnabled: ").Append(AlarmActionEnabled).Append("\n");
            sb.Append("  alarmLevel: ").Append(AlarmLevel).Append("\n");
            sb.Append("  alarmType: ").Append(AlarmType).Append("\n");
            sb.Append("  alarmActions: ").Append(AlarmActions).Append("\n");
            sb.Append("  insufficientdataActions: ").Append(InsufficientdataActions).Append("\n");
            sb.Append("  okActions: ").Append(OkActions).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAlarmRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAlarmRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlarmName == input.AlarmName ||
                    (this.AlarmName != null &&
                    this.AlarmName.Equals(input.AlarmName))
                ) && 
                (
                    this.AlarmDescription == input.AlarmDescription ||
                    (this.AlarmDescription != null &&
                    this.AlarmDescription.Equals(input.AlarmDescription))
                ) && 
                (
                    this.Metric == input.Metric ||
                    (this.Metric != null &&
                    this.Metric.Equals(input.Metric))
                ) && 
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
                ) && 
                (
                    this.AlarmEnabled == input.AlarmEnabled ||
                    (this.AlarmEnabled != null &&
                    this.AlarmEnabled.Equals(input.AlarmEnabled))
                ) && 
                (
                    this.AlarmActionEnabled == input.AlarmActionEnabled ||
                    (this.AlarmActionEnabled != null &&
                    this.AlarmActionEnabled.Equals(input.AlarmActionEnabled))
                ) && 
                (
                    this.AlarmLevel == input.AlarmLevel ||
                    (this.AlarmLevel != null &&
                    this.AlarmLevel.Equals(input.AlarmLevel))
                ) && 
                (
                    this.AlarmType == input.AlarmType ||
                    (this.AlarmType != null &&
                    this.AlarmType.Equals(input.AlarmType))
                ) && 
                (
                    this.AlarmActions == input.AlarmActions ||
                    this.AlarmActions != null &&
                    input.AlarmActions != null &&
                    this.AlarmActions.SequenceEqual(input.AlarmActions)
                ) && 
                (
                    this.InsufficientdataActions == input.InsufficientdataActions ||
                    this.InsufficientdataActions != null &&
                    input.InsufficientdataActions != null &&
                    this.InsufficientdataActions.SequenceEqual(input.InsufficientdataActions)
                ) && 
                (
                    this.OkActions == input.OkActions ||
                    this.OkActions != null &&
                    input.OkActions != null &&
                    this.OkActions.SequenceEqual(input.OkActions)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.AlarmName != null)
                    hashCode = hashCode * 59 + this.AlarmName.GetHashCode();
                if (this.AlarmDescription != null)
                    hashCode = hashCode * 59 + this.AlarmDescription.GetHashCode();
                if (this.Metric != null)
                    hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.AlarmEnabled != null)
                    hashCode = hashCode * 59 + this.AlarmEnabled.GetHashCode();
                if (this.AlarmActionEnabled != null)
                    hashCode = hashCode * 59 + this.AlarmActionEnabled.GetHashCode();
                if (this.AlarmLevel != null)
                    hashCode = hashCode * 59 + this.AlarmLevel.GetHashCode();
                if (this.AlarmType != null)
                    hashCode = hashCode * 59 + this.AlarmType.GetHashCode();
                if (this.AlarmActions != null)
                    hashCode = hashCode * 59 + this.AlarmActions.GetHashCode();
                if (this.InsufficientdataActions != null)
                    hashCode = hashCode * 59 + this.InsufficientdataActions.GetHashCode();
                if (this.OkActions != null)
                    hashCode = hashCode * 59 + this.OkActions.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}