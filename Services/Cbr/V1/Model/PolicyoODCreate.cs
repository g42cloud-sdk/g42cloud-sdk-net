using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PolicyoODCreate 
    {

        [JsonProperty("day_backups", NullValueHandling = NullValueHandling.Ignore)]
        public int? DayBackups { get; set; }

        [JsonProperty("destination_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationProjectId { get; set; }

        [JsonProperty("destination_region", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationRegion { get; set; }

        [JsonProperty("enable_acceleration", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAcceleration { get; set; }

        [JsonProperty("max_backups", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxBackups { get; set; }

        [JsonProperty("month_backups", NullValueHandling = NullValueHandling.Ignore)]
        public int? MonthBackups { get; set; }

        [JsonProperty("retention_duration_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionDurationDays { get; set; }

        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }

        [JsonProperty("week_backups", NullValueHandling = NullValueHandling.Ignore)]
        public int? WeekBackups { get; set; }

        [JsonProperty("year_backups", NullValueHandling = NullValueHandling.Ignore)]
        public int? YearBackups { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyoODCreate {\n");
            sb.Append("  dayBackups: ").Append(DayBackups).Append("\n");
            sb.Append("  destinationProjectId: ").Append(DestinationProjectId).Append("\n");
            sb.Append("  destinationRegion: ").Append(DestinationRegion).Append("\n");
            sb.Append("  enableAcceleration: ").Append(EnableAcceleration).Append("\n");
            sb.Append("  maxBackups: ").Append(MaxBackups).Append("\n");
            sb.Append("  monthBackups: ").Append(MonthBackups).Append("\n");
            sb.Append("  retentionDurationDays: ").Append(RetentionDurationDays).Append("\n");
            sb.Append("  timezone: ").Append(Timezone).Append("\n");
            sb.Append("  weekBackups: ").Append(WeekBackups).Append("\n");
            sb.Append("  yearBackups: ").Append(YearBackups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyoODCreate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyoODCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DayBackups == input.DayBackups ||
                    (this.DayBackups != null &&
                    this.DayBackups.Equals(input.DayBackups))
                ) && 
                (
                    this.DestinationProjectId == input.DestinationProjectId ||
                    (this.DestinationProjectId != null &&
                    this.DestinationProjectId.Equals(input.DestinationProjectId))
                ) && 
                (
                    this.DestinationRegion == input.DestinationRegion ||
                    (this.DestinationRegion != null &&
                    this.DestinationRegion.Equals(input.DestinationRegion))
                ) && 
                (
                    this.EnableAcceleration == input.EnableAcceleration ||
                    (this.EnableAcceleration != null &&
                    this.EnableAcceleration.Equals(input.EnableAcceleration))
                ) && 
                (
                    this.MaxBackups == input.MaxBackups ||
                    (this.MaxBackups != null &&
                    this.MaxBackups.Equals(input.MaxBackups))
                ) && 
                (
                    this.MonthBackups == input.MonthBackups ||
                    (this.MonthBackups != null &&
                    this.MonthBackups.Equals(input.MonthBackups))
                ) && 
                (
                    this.RetentionDurationDays == input.RetentionDurationDays ||
                    (this.RetentionDurationDays != null &&
                    this.RetentionDurationDays.Equals(input.RetentionDurationDays))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.WeekBackups == input.WeekBackups ||
                    (this.WeekBackups != null &&
                    this.WeekBackups.Equals(input.WeekBackups))
                ) && 
                (
                    this.YearBackups == input.YearBackups ||
                    (this.YearBackups != null &&
                    this.YearBackups.Equals(input.YearBackups))
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
                if (this.DayBackups != null)
                    hashCode = hashCode * 59 + this.DayBackups.GetHashCode();
                if (this.DestinationProjectId != null)
                    hashCode = hashCode * 59 + this.DestinationProjectId.GetHashCode();
                if (this.DestinationRegion != null)
                    hashCode = hashCode * 59 + this.DestinationRegion.GetHashCode();
                if (this.EnableAcceleration != null)
                    hashCode = hashCode * 59 + this.EnableAcceleration.GetHashCode();
                if (this.MaxBackups != null)
                    hashCode = hashCode * 59 + this.MaxBackups.GetHashCode();
                if (this.MonthBackups != null)
                    hashCode = hashCode * 59 + this.MonthBackups.GetHashCode();
                if (this.RetentionDurationDays != null)
                    hashCode = hashCode * 59 + this.RetentionDurationDays.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.WeekBackups != null)
                    hashCode = hashCode * 59 + this.WeekBackups.GetHashCode();
                if (this.YearBackups != null)
                    hashCode = hashCode * 59 + this.YearBackups.GetHashCode();
                return hashCode;
            }
        }
    }
}
