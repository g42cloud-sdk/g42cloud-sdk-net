using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using G42Cloud.SDK.Core;
using G42Cloud.SDK.Cdn.V1.Model;

namespace G42Cloud.SDK.Cdn.V1
{
    public partial class CdnAsyncClient : Client
    {
        public static ClientBuilder<CdnAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CdnAsyncClient>("GlobalCredentials");
        }

        
        public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest createDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDomainResponse>(response);
        }
        
        public async Task<CreatePreheatingTasksResponse> CreatePreheatingTasksAsync(CreatePreheatingTasksRequest createPreheatingTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/preheating-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingTasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePreheatingTasksResponse>(response);
        }
        
        public async Task<CreateRefreshTasksResponse> CreateRefreshTasksAsync(CreateRefreshTasksRequest createRefreshTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/refresh-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRefreshTasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRefreshTasksResponse>(response);
        }
        
        public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest deleteDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , deleteDomainRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteDomainResponse>(response);
        }
        
        public async Task<DisableDomainResponse> DisableDomainAsync(DisableDomainRequest disableDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , disableDomainRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/disable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<DisableDomainResponse>(response);
        }
        
        public async Task<EnableDomainResponse> EnableDomainAsync(EnableDomainRequest enableDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , enableDomainRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/enable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<EnableDomainResponse>(response);
        }
        
        public async Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest listDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDomainsResponse>(response);
        }
        
        public async Task<ShowBlackWhiteListResponse> ShowBlackWhiteListAsync(ShowBlackWhiteListRequest showBlackWhiteListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showBlackWhiteListRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/ip-acl",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlackWhiteListRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBlackWhiteListResponse>(response);
        }
        
        public async Task<ShowCacheRulesResponse> ShowCacheRulesAsync(ShowCacheRulesRequest showCacheRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showCacheRulesRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/cache",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCacheRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCacheRulesResponse>(response);
        }
        
        public async Task<ShowCertificatesHttpsInfoResponse> ShowCertificatesHttpsInfoAsync(ShowCertificatesHttpsInfoRequest showCertificatesHttpsInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/https-certificate-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificatesHttpsInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCertificatesHttpsInfoResponse>(response);
        }
        
        public async Task<ShowDomainDetailResponse> ShowDomainDetailAsync(ShowDomainDetailRequest showDomainDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showDomainDetailRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainDetailResponse>(response);
        }
        
        public async Task<ShowDomainFullConfigResponse> ShowDomainFullConfigAsync(ShowDomainFullConfigRequest showDomainFullConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name" , showDomainFullConfigRequest.DomainName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainFullConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainFullConfigResponse>(response);
        }
        
        public async Task<ShowDomainItemDetailsResponse> ShowDomainItemDetailsAsync(ShowDomainItemDetailsRequest showDomainItemDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-item-details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainItemDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainItemDetailsResponse>(response);
        }
        
        public async Task<ShowDomainItemLocationDetailsResponse> ShowDomainItemLocationDetailsAsync(ShowDomainItemLocationDetailsRequest showDomainItemLocationDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-item-location-details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainItemLocationDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainItemLocationDetailsResponse>(response);
        }
        
        public async Task<ShowDomainLocationStatsResponse> ShowDomainLocationStatsAsync(ShowDomainLocationStatsRequest showDomainLocationStatsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-location-stats",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLocationStatsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainLocationStatsResponse>(response);
        }
        
        public async Task<ShowDomainStatsResponse> ShowDomainStatsAsync(ShowDomainStatsRequest showDomainStatsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-stats",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainStatsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainStatsResponse>(response);
        }
        
        public async Task<ShowHistoryTaskDetailsResponse> ShowHistoryTaskDetailsAsync(ShowHistoryTaskDetailsRequest showHistoryTaskDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("history_tasks_id" , showHistoryTaskDetailsRequest.HistoryTasksId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks/{history_tasks_id}/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTaskDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowHistoryTaskDetailsResponse>(response);
        }
        
        public async Task<ShowHistoryTasksResponse> ShowHistoryTasksAsync(ShowHistoryTasksRequest showHistoryTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowHistoryTasksResponse>(response);
        }
        
        public async Task<ShowHttpInfoResponse> ShowHttpInfoAsync(ShowHttpInfoRequest showHttpInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showHttpInfoRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/https-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHttpInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowHttpInfoResponse>(response);
        }
        
        public async Task<ShowIpInfoResponse> ShowIpInfoAsync(ShowIpInfoRequest showIpInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/ip-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowIpInfoResponse>(response);
        }
        
        public async Task<ShowLogsResponse> ShowLogsAsync(ShowLogsRequest showLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowLogsResponse>(response);
        }
        
        public async Task<ShowOriginHostResponse> ShowOriginHostAsync(ShowOriginHostRequest showOriginHostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showOriginHostRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/originhost",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOriginHostRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowOriginHostResponse>(response);
        }
        
        public async Task<ShowQuotaResponse> ShowQuotaAsync(ShowQuotaRequest showQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/quota",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }
        
        public async Task<ShowReferResponse> ShowReferAsync(ShowReferRequest showReferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showReferRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/referer",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReferRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowReferResponse>(response);
        }
        
        public async Task<ShowResponseHeaderResponse> ShowResponseHeaderAsync(ShowResponseHeaderRequest showResponseHeaderRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showResponseHeaderRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/response-header",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResponseHeaderRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowResponseHeaderResponse>(response);
        }
        
        public async Task<ShowTopUrlResponse> ShowTopUrlAsync(ShowTopUrlRequest showTopUrlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-url",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopUrlRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTopUrlResponse>(response);
        }
        
        public async Task<UpdateBlackWhiteListResponse> UpdateBlackWhiteListAsync(UpdateBlackWhiteListRequest updateBlackWhiteListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateBlackWhiteListRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/ip-acl",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBlackWhiteListRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateBlackWhiteListResponse>(response);
        }
        
        public async Task<UpdateCacheRulesResponse> UpdateCacheRulesAsync(UpdateCacheRulesRequest updateCacheRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateCacheRulesRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/cache",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCacheRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateCacheRulesResponse>(response);
        }
        
        public async Task<UpdateDomainFullConfigResponse> UpdateDomainFullConfigAsync(UpdateDomainFullConfigRequest updateDomainFullConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name" , updateDomainFullConfigRequest.DomainName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainFullConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateDomainFullConfigResponse>(response);
        }
        
        public async Task<UpdateDomainMultiCertificatesResponse> UpdateDomainMultiCertificatesAsync(UpdateDomainMultiCertificatesRequest updateDomainMultiCertificatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/config-https-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainMultiCertificatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainMultiCertificatesResponse>(response);
        }
        
        public async Task<UpdateDomainOriginResponse> UpdateDomainOriginAsync(UpdateDomainOriginRequest updateDomainOriginRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateDomainOriginRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/origin",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainOriginRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainOriginResponse>(response);
        }
        
        public async Task<UpdateFollow302SwitchResponse> UpdateFollow302SwitchAsync(UpdateFollow302SwitchRequest updateFollow302SwitchRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateFollow302SwitchRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/follow302-switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFollow302SwitchRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFollow302SwitchResponse>(response);
        }
        
        public async Task<UpdateHttpsInfoResponse> UpdateHttpsInfoAsync(UpdateHttpsInfoRequest updateHttpsInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateHttpsInfoRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/https-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHttpsInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateHttpsInfoResponse>(response);
        }
        
        public async Task<UpdateOriginHostResponse> UpdateOriginHostAsync(UpdateOriginHostRequest updateOriginHostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateOriginHostRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/originhost",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOriginHostRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateOriginHostResponse>(response);
        }
        
        public async Task<UpdatePrivateBucketAccessResponse> UpdatePrivateBucketAccessAsync(UpdatePrivateBucketAccessRequest updatePrivateBucketAccessRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updatePrivateBucketAccessRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/private-bucket-access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateBucketAccessRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePrivateBucketAccessResponse>(response);
        }
        
        public async Task<UpdateRangeSwitchResponse> UpdateRangeSwitchAsync(UpdateRangeSwitchRequest updateRangeSwitchRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateRangeSwitchRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/range-switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRangeSwitchRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRangeSwitchResponse>(response);
        }
        
        public async Task<UpdateReferResponse> UpdateReferAsync(UpdateReferRequest updateReferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateReferRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/referer",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReferRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateReferResponse>(response);
        }
        
        public async Task<UpdateResponseHeaderResponse> UpdateResponseHeaderAsync(UpdateResponseHeaderRequest updateResponseHeaderRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateResponseHeaderRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/response-header",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResponseHeaderRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateResponseHeaderResponse>(response);
        }
        
    }
}