using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListHealthMonitorsRequest 
    {

        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        [SDKProperty("monitor_port", IsQuery = true)]
        [JsonProperty("monitor_port", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> MonitorPort { get; set; }

        [SDKProperty("domain_name", IsQuery = true)]
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DomainName { get; set; }

        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        [SDKProperty("delay", IsQuery = true)]
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Delay { get; set; }

        [SDKProperty("max_retries", IsQuery = true)]
        [JsonProperty("max_retries", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> MaxRetries { get; set; }

        [SDKProperty("admin_state_up", IsQuery = true)]
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        [SDKProperty("max_retries_down", IsQuery = true)]
        [JsonProperty("max_retries_down", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> MaxRetriesDown { get; set; }

        [SDKProperty("timeout", IsQuery = true)]
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Type { get; set; }

        [SDKProperty("expected_codes", IsQuery = true)]
        [JsonProperty("expected_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExpectedCodes { get; set; }

        [SDKProperty("url_path", IsQuery = true)]
        [JsonProperty("url_path", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UrlPath { get; set; }

        [SDKProperty("http_method", IsQuery = true)]
        [JsonProperty("http_method", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HttpMethod { get; set; }

        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHealthMonitorsRequest {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  monitorPort: ").Append(MonitorPort).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("  maxRetries: ").Append(MaxRetries).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  maxRetriesDown: ").Append(MaxRetriesDown).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  expectedCodes: ").Append(ExpectedCodes).Append("\n");
            sb.Append("  urlPath: ").Append(UrlPath).Append("\n");
            sb.Append("  httpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHealthMonitorsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHealthMonitorsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.PageReverse == input.PageReverse ||
                    (this.PageReverse != null &&
                    this.PageReverse.Equals(input.PageReverse))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id != null &&
                    input.Id != null &&
                    this.Id.SequenceEqual(input.Id)
                ) && 
                (
                    this.MonitorPort == input.MonitorPort ||
                    this.MonitorPort != null &&
                    input.MonitorPort != null &&
                    this.MonitorPort.SequenceEqual(input.MonitorPort)
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    this.DomainName != null &&
                    input.DomainName != null &&
                    this.DomainName.SequenceEqual(input.DomainName)
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.Delay == input.Delay ||
                    this.Delay != null &&
                    input.Delay != null &&
                    this.Delay.SequenceEqual(input.Delay)
                ) && 
                (
                    this.MaxRetries == input.MaxRetries ||
                    this.MaxRetries != null &&
                    input.MaxRetries != null &&
                    this.MaxRetries.SequenceEqual(input.MaxRetries)
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.MaxRetriesDown == input.MaxRetriesDown ||
                    this.MaxRetriesDown != null &&
                    input.MaxRetriesDown != null &&
                    this.MaxRetriesDown.SequenceEqual(input.MaxRetriesDown)
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type != null &&
                    input.Type != null &&
                    this.Type.SequenceEqual(input.Type)
                ) && 
                (
                    this.ExpectedCodes == input.ExpectedCodes ||
                    this.ExpectedCodes != null &&
                    input.ExpectedCodes != null &&
                    this.ExpectedCodes.SequenceEqual(input.ExpectedCodes)
                ) && 
                (
                    this.UrlPath == input.UrlPath ||
                    this.UrlPath != null &&
                    input.UrlPath != null &&
                    this.UrlPath.SequenceEqual(input.UrlPath)
                ) && 
                (
                    this.HttpMethod == input.HttpMethod ||
                    this.HttpMethod != null &&
                    input.HttpMethod != null &&
                    this.HttpMethod.SequenceEqual(input.HttpMethod)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    this.EnterpriseProjectId != null &&
                    input.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId)
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
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.PageReverse != null)
                    hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MonitorPort != null)
                    hashCode = hashCode * 59 + this.MonitorPort.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Delay != null)
                    hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.MaxRetries != null)
                    hashCode = hashCode * 59 + this.MaxRetries.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.MaxRetriesDown != null)
                    hashCode = hashCode * 59 + this.MaxRetriesDown.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ExpectedCodes != null)
                    hashCode = hashCode * 59 + this.ExpectedCodes.GetHashCode();
                if (this.UrlPath != null)
                    hashCode = hashCode * 59 + this.UrlPath.GetHashCode();
                if (this.HttpMethod != null)
                    hashCode = hashCode * 59 + this.HttpMethod.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
