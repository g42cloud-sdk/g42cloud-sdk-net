using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using G42Cloud.SDK.Core;
using G42Cloud.SDK.Mpc.V1.Model;

namespace G42Cloud.SDK.Mpc.V1
{
    public partial class MpcAsyncClient : Client
    {
        public static ClientBuilder<MpcAsyncClient> NewBuilder()
        {
            return new ClientBuilder<MpcAsyncClient>();
        }

        
        public async Task<CreateAnimatedGraphicsTaskResponse> CreateAnimatedGraphicsTaskAsync(CreateAnimatedGraphicsTaskRequest createAnimatedGraphicsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAnimatedGraphicsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAnimatedGraphicsTaskResponse>(response);
        }
        
        public async Task<DeleteAnimatedGraphicsTaskResponse> DeleteAnimatedGraphicsTaskAsync(DeleteAnimatedGraphicsTaskRequest deleteAnimatedGraphicsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAnimatedGraphicsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAnimatedGraphicsTaskResponse>(response);
        }
        
        public async Task<ListAnimatedGraphicsTaskResponse> ListAnimatedGraphicsTaskAsync(ListAnimatedGraphicsTaskRequest listAnimatedGraphicsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAnimatedGraphicsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAnimatedGraphicsTaskResponse>(response);
        }
        
        public async Task<CreateAgenciesTaskResponse> CreateAgenciesTaskAsync(CreateAgenciesTaskRequest createAgenciesTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/agencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgenciesTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateAgenciesTaskResponse>(response);
        }
        
        public async Task<ListAllBucketsResponse> ListAllBucketsAsync(ListAllBucketsRequest listAllBucketsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/buckets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllBucketsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAllBucketsResponse>(response);
        }
        
        public async Task<ListAllObsObjListResponse> ListAllObsObjListAsync(ListAllObsObjListRequest listAllObsObjListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0-ext/{project_id}/objects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllObsObjListRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAllObsObjListResponse>(response);
        }
        
        public async Task<ListNotifyEventResponse> ListNotifyEventAsync(ListNotifyEventRequest listNotifyEventRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification/event",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotifyEventRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListNotifyEventResponse>(response);
        }
        
        public async Task<ListNotifySmnTopicConfigResponse> ListNotifySmnTopicConfigAsync(ListNotifySmnTopicConfigRequest listNotifySmnTopicConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotifySmnTopicConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListNotifySmnTopicConfigResponse>(response);
        }
        
        public async Task<NotifySmnTopicConfigResponse> NotifySmnTopicConfigAsync(NotifySmnTopicConfigRequest notifySmnTopicConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", notifySmnTopicConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<NotifySmnTopicConfigResponse>(response);
        }
        
        public async Task<ShowAgenciesTaskResponse> ShowAgenciesTaskAsync(ShowAgenciesTaskRequest showAgenciesTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/agencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgenciesTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAgenciesTaskResponse>(response);
        }
        
        public async Task<UpdateBucketAuthorizedResponse> UpdateBucketAuthorizedAsync(UpdateBucketAuthorizedRequest updateBucketAuthorizedRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/authority",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBucketAuthorizedRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateBucketAuthorizedResponse>(response);
        }
        
        public async Task<CreateEditingJobResponse> CreateEditingJobAsync(CreateEditingJobRequest createEditingJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEditingJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateEditingJobResponse>(response);
        }
        
        public async Task<DeleteEditingJobResponse> DeleteEditingJobAsync(DeleteEditingJobRequest deleteEditingJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEditingJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteEditingJobResponse>(response);
        }
        
        public async Task<ListEditingJobResponse> ListEditingJobAsync(ListEditingJobRequest listEditingJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEditingJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEditingJobResponse>(response);
        }
        
        public async Task<CreateEncryptTaskResponse> CreateEncryptTaskAsync(CreateEncryptTaskRequest createEncryptTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEncryptTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateEncryptTaskResponse>(response);
        }
        
        public async Task<DeleteEncryptTaskResponse> DeleteEncryptTaskAsync(DeleteEncryptTaskRequest deleteEncryptTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEncryptTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteEncryptTaskResponse>(response);
        }
        
        public async Task<ListEncryptTaskResponse> ListEncryptTaskAsync(ListEncryptTaskRequest listEncryptTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEncryptTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEncryptTaskResponse>(response);
        }
        
        public async Task<CreateExtractTaskResponse> CreateExtractTaskAsync(CreateExtractTaskRequest createExtractTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExtractTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateExtractTaskResponse>(response);
        }
        
        public async Task<DeleteExtractTaskResponse> DeleteExtractTaskAsync(DeleteExtractTaskRequest deleteExtractTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteExtractTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteExtractTaskResponse>(response);
        }
        
        public async Task<ListExtractTaskResponse> ListExtractTaskAsync(ListExtractTaskRequest listExtractTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExtractTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListExtractTaskResponse>(response);
        }
        
        public async Task<CreateMbTasksReportResponse> CreateMbTasksReportAsync(CreateMbTasksReportRequest createMbTasksReportRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/mediabox/tasks/report",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMbTasksReportRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<CreateMbTasksReportResponse>(response);
        }
        
        public async Task<CreateMergeChannelsTaskResponse> CreateMergeChannelsTaskAsync(CreateMergeChannelsTaskRequest createMergeChannelsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeChannelsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateMergeChannelsTaskResponse>(response);
        }
        
        public async Task<CreateResetTracksTaskResponse> CreateResetTracksTaskAsync(CreateResetTracksTaskRequest createResetTracksTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResetTracksTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateResetTracksTaskResponse>(response);
        }
        
        public async Task<DeleteMergeChannelsTaskResponse> DeleteMergeChannelsTaskAsync(DeleteMergeChannelsTaskRequest deleteMergeChannelsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeChannelsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMergeChannelsTaskResponse>(response);
        }
        
        public async Task<DeleteResetTracksTaskResponse> DeleteResetTracksTaskAsync(DeleteResetTracksTaskRequest deleteResetTracksTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResetTracksTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteResetTracksTaskResponse>(response);
        }
        
        public async Task<ListMergeChannelsTaskResponse> ListMergeChannelsTaskAsync(ListMergeChannelsTaskRequest listMergeChannelsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeChannelsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMergeChannelsTaskResponse>(response);
        }
        
        public async Task<ListResetTracksTaskResponse> ListResetTracksTaskAsync(ListResetTracksTaskRequest listResetTracksTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResetTracksTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListResetTracksTaskResponse>(response);
        }
        
        public async Task<CreateMediaProcessTaskResponse> CreateMediaProcessTaskAsync(CreateMediaProcessTaskRequest createMediaProcessTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMediaProcessTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateMediaProcessTaskResponse>(response);
        }
        
        public async Task<DeleteMediaProcessTaskResponse> DeleteMediaProcessTaskAsync(DeleteMediaProcessTaskRequest deleteMediaProcessTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMediaProcessTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMediaProcessTaskResponse>(response);
        }
        
        public async Task<ListMediaProcessTaskResponse> ListMediaProcessTaskAsync(ListMediaProcessTaskRequest listMediaProcessTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMediaProcessTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMediaProcessTaskResponse>(response);
        }
        
        public async Task<CreateMpeCallBackResponse> CreateMpeCallBackAsync(CreateMpeCallBackRequest createMpeCallBackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/mpe/notification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMpeCallBackRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateMpeCallBackResponse>(response);
        }
        
        public async Task<CreateQualityEnhanceTemplateResponse> CreateQualityEnhanceTemplateAsync(CreateQualityEnhanceTemplateRequest createQualityEnhanceTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createQualityEnhanceTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateQualityEnhanceTemplateResponse>(response);
        }
        
        public async Task<DeleteQualityEnhanceTemplateResponse> DeleteQualityEnhanceTemplateAsync(DeleteQualityEnhanceTemplateRequest deleteQualityEnhanceTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQualityEnhanceTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteQualityEnhanceTemplateResponse>(response);
        }
        
        public async Task<ListQualityEnhanceDefaultTemplateResponse> ListQualityEnhanceDefaultTemplateAsync(ListQualityEnhanceDefaultTemplateRequest listQualityEnhanceDefaultTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance/default",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQualityEnhanceDefaultTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListQualityEnhanceDefaultTemplateResponse>(response);
        }
        
        public async Task<UpdateQualityEnhanceTemplateResponse> UpdateQualityEnhanceTemplateAsync(UpdateQualityEnhanceTemplateRequest updateQualityEnhanceTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateQualityEnhanceTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateQualityEnhanceTemplateResponse>(response);
        }
        
        public async Task<ListTranscodeDetailResponse> ListTranscodeDetailAsync(ListTranscodeDetailRequest listTranscodeDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTranscodeDetailResponse>(response);
        }
        
        public async Task<CancelRemuxTaskResponse> CancelRemuxTaskAsync(CancelRemuxTaskRequest cancelRemuxTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRemuxTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<CancelRemuxTaskResponse>(response);
        }
        
        public async Task<CreateRemuxTaskResponse> CreateRemuxTaskAsync(CreateRemuxTaskRequest createRemuxTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRemuxTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRemuxTaskResponse>(response);
        }
        
        public async Task<CreateRetryRemuxTaskResponse> CreateRetryRemuxTaskAsync(CreateRetryRemuxTaskRequest createRetryRemuxTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRetryRemuxTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<CreateRetryRemuxTaskResponse>(response);
        }
        
        public async Task<DeleteRemuxTaskResponse> DeleteRemuxTaskAsync(DeleteRemuxTaskRequest deleteRemuxTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRemuxTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRemuxTaskResponse>(response);
        }
        
        public async Task<ListRemuxTaskResponse> ListRemuxTaskAsync(ListRemuxTaskRequest listRemuxTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRemuxTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRemuxTaskResponse>(response);
        }
        
        public async Task<CreateTemplateGroupResponse> CreateTemplateGroupAsync(CreateTemplateGroupRequest createTemplateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTemplateGroupResponse>(response);
        }
        
        public async Task<DeleteTemplateGroupResponse> DeleteTemplateGroupAsync(DeleteTemplateGroupRequest deleteTemplateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTemplateGroupResponse>(response);
        }
        
        public async Task<ListTemplateGroupResponse> ListTemplateGroupAsync(ListTemplateGroupRequest listTemplateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateGroupResponse>(response);
        }
        
        public async Task<UpdateTemplateGroupResponse> UpdateTemplateGroupAsync(UpdateTemplateGroupRequest updateTemplateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTemplateGroupResponse>(response);
        }
        
        public async Task<CreateThumbnailsTaskResponse> CreateThumbnailsTaskAsync(CreateThumbnailsTaskRequest createThumbnailsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createThumbnailsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateThumbnailsTaskResponse>(response);
        }
        
        public async Task<DeleteThumbnailsTaskResponse> DeleteThumbnailsTaskAsync(DeleteThumbnailsTaskRequest deleteThumbnailsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteThumbnailsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteThumbnailsTaskResponse>(response);
        }
        
        public async Task<ListThumbnailsTaskResponse> ListThumbnailsTaskAsync(ListThumbnailsTaskRequest listThumbnailsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listThumbnailsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListThumbnailsTaskResponse>(response);
        }
        
        public async Task<CreateTranscodingTaskResponse> CreateTranscodingTaskAsync(CreateTranscodingTaskRequest createTranscodingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTranscodingTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTranscodingTaskResponse>(response);
        }
        
        public async Task<DeleteTranscodingTaskResponse> DeleteTranscodingTaskAsync(DeleteTranscodingTaskRequest deleteTranscodingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTranscodingTaskResponse>(response);
        }
        
        public async Task<DeleteTranscodingTaskByConsoleResponse> DeleteTranscodingTaskByConsoleAsync(DeleteTranscodingTaskByConsoleRequest deleteTranscodingTaskByConsoleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingTaskByConsoleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTranscodingTaskByConsoleResponse>(response);
        }
        
        public async Task<ListStatSummaryResponse> ListStatSummaryAsync(ListStatSummaryRequest listStatSummaryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/summaries",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatSummaryRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListStatSummaryResponse>(response);
        }
        
        public async Task<ListTranscodingTaskResponse> ListTranscodingTaskAsync(ListTranscodingTaskRequest listTranscodingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodingTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTranscodingTaskResponse>(response);
        }
        
        public async Task<CreateTransTemplateResponse> CreateTransTemplateAsync(CreateTransTemplateRequest createTransTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTransTemplateResponse>(response);
        }
        
        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest deleteTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTemplateResponse>(response);
        }
        
        public async Task<ListTemplateResponse> ListTemplateAsync(ListTemplateRequest listTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateResponse>(response);
        }
        
        public async Task<UpdateTransTemplateResponse> UpdateTransTemplateAsync(UpdateTransTemplateRequest updateTransTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTransTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTransTemplateResponse>(response);
        }
        
        public async Task<CreateWatermarkTemplateResponse> CreateWatermarkTemplateAsync(CreateWatermarkTemplateRequest createWatermarkTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWatermarkTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateWatermarkTemplateResponse>(response);
        }
        
        public async Task<DeleteWatermarkTemplateResponse> DeleteWatermarkTemplateAsync(DeleteWatermarkTemplateRequest deleteWatermarkTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWatermarkTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteWatermarkTemplateResponse>(response);
        }
        
        public async Task<ListWatermarkTemplateResponse> ListWatermarkTemplateAsync(ListWatermarkTemplateRequest listWatermarkTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWatermarkTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListWatermarkTemplateResponse>(response);
        }
        
        public async Task<UpdateWatermarkTemplateResponse> UpdateWatermarkTemplateAsync(UpdateWatermarkTemplateRequest updateWatermarkTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWatermarkTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateWatermarkTemplateResponse>(response);
        }
        
    }
}