using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using G42Cloud.SDK.Ces.V1.Model;

namespace G42Cloud.SDK.Ces.V1
{
    public partial class CesAsyncClient : Client
    {
        public static ClientBuilder<CesAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CesAsyncClient>();
        }

        
        public async Task<BatchListMetricDataResponse> BatchListMetricDataAsync(BatchListMetricDataRequest batchListMetricDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/batch-query-metric-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListMetricDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchListMetricDataResponse>(response);
        }
        
        public async Task<CreateAlarmResponse> CreateAlarmAsync(CreateAlarmRequest createAlarmRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAlarmResponse>(response);
        }
        
        public async Task<CreateAlarmTemplateResponse> CreateAlarmTemplateAsync(CreateAlarmTemplateRequest createAlarmTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAlarmTemplateResponse>(response);
        }
        
        public async Task<CreateEventsResponse> CreateEventsAsync(CreateEventsRequest createEventsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/events",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEventsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            CreateEventsResponse createEventsResponse = JsonUtils.DeSerializeNull<CreateEventsResponse>(response);
            createEventsResponse.Body = JsonUtils.DeSerializeList<CreateEventsResponseBody>(response);
            return createEventsResponse;
        }
        
        public async Task<CreateMetricDataResponse> CreateMetricDataAsync(CreateMetricDataRequest createMetricDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metric-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMetricDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateMetricDataResponse>(response);
        }
        
        public async Task<CreateResourceGroupResponse> CreateResourceGroupAsync(CreateResourceGroupRequest createResourceGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateResourceGroupResponse>(response);
        }
        
        public async Task<DeleteAlarmResponse> DeleteAlarmAsync(DeleteAlarmRequest deleteAlarmRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , deleteAlarmRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAlarmResponse>(response);
        }
        
        public async Task<DeleteAlarmTemplateResponse> DeleteAlarmTemplateAsync(DeleteAlarmTemplateRequest deleteAlarmTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id" , deleteAlarmTemplateRequest.TemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template/{template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAlarmTemplateResponse>(response);
        }
        
        public async Task<DeleteResourceGroupResponse> DeleteResourceGroupAsync(DeleteResourceGroupRequest deleteResourceGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , deleteResourceGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteResourceGroupResponse>(response);
        }
        
        public async Task<ListAlarmHistoriesResponse> ListAlarmHistoriesAsync(ListAlarmHistoriesRequest listAlarmHistoriesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmHistoriesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmHistoriesResponse>(response);
        }
        
        public async Task<ListAlarmTemplatesResponse> ListAlarmTemplatesAsync(ListAlarmTemplatesRequest listAlarmTemplatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmTemplatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmTemplatesResponse>(response);
        }
        
        public async Task<ListAlarmsResponse> ListAlarmsAsync(ListAlarmsRequest listAlarmsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmsResponse>(response);
        }
        
        public async Task<ListEventDetailResponse> ListEventDetailAsync(ListEventDetailRequest listEventDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("event_name" , listEventDetailRequest.EventName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/event/{event_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEventDetailResponse>(response);
        }
        
        public async Task<ListEventsResponse> ListEventsAsync(ListEventsRequest listEventsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/events",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEventsResponse>(response);
        }
        
        public async Task<ListMetricsResponse> ListMetricsAsync(ListMetricsRequest listMetricsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metrics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMetricsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMetricsResponse>(response);
        }
        
        public async Task<ListResourceGroupResponse> ListResourceGroupAsync(ListResourceGroupRequest listResourceGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListResourceGroupResponse>(response);
        }
        
        public async Task<ShowAlarmResponse> ShowAlarmAsync(ShowAlarmRequest showAlarmRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , showAlarmRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAlarmResponse>(response);
        }
        
        public async Task<ShowEventDataResponse> ShowEventDataAsync(ShowEventDataRequest showEventDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/event-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEventDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowEventDataResponse>(response);
        }
        
        public async Task<ShowMetricDataResponse> ShowMetricDataAsync(ShowMetricDataRequest showMetricDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/metric-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetricDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMetricDataResponse>(response);
        }
        
        public async Task<ShowQuotasResponse> ShowQuotasAsync(ShowQuotasRequest showQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }
        
        public async Task<ShowResourceGroupResponse> ShowResourceGroupAsync(ShowResourceGroupRequest showResourceGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , showResourceGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowResourceGroupResponse>(response);
        }
        
        public async Task<UpdateAlarmResponse> UpdateAlarmAsync(UpdateAlarmRequest updateAlarmRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , updateAlarmRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateAlarmResponse>(response);
        }
        
        public async Task<UpdateAlarmActionResponse> UpdateAlarmActionAsync(UpdateAlarmActionRequest updateAlarmActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , updateAlarmActionRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarms/{alarm_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmActionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateAlarmActionResponse>(response);
        }
        
        public async Task<UpdateAlarmTemplateResponse> UpdateAlarmTemplateAsync(UpdateAlarmTemplateRequest updateAlarmTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id" , updateAlarmTemplateRequest.TemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/alarm-template/{template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateAlarmTemplateResponse>(response);
        }
        
        public async Task<UpdateResourceGroupResponse> UpdateResourceGroupAsync(UpdateResourceGroupRequest updateResourceGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , updateResourceGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/V1.0/{project_id}/resource-groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateResourceGroupResponse>(response);
        }
        
    }
}