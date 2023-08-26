using System;
using System.Net.Http;
using System.Collections.Generic;
using G42Cloud.SDK.Core;
using G42Cloud.SDK.Mpc.V1.Model;

namespace G42Cloud.SDK.Mpc.V1
{
    public partial class MpcClient : Client
    {
        public static ClientBuilder<MpcClient> NewBuilder()
        {
            return new ClientBuilder<MpcClient>();
        }

        
        public CreateAnimatedGraphicsTaskResponse CreateAnimatedGraphicsTask(CreateAnimatedGraphicsTaskRequest createAnimatedGraphicsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAnimatedGraphicsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAnimatedGraphicsTaskResponse>(response);
        }
        
        public DeleteAnimatedGraphicsTaskResponse DeleteAnimatedGraphicsTask(DeleteAnimatedGraphicsTaskRequest deleteAnimatedGraphicsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAnimatedGraphicsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAnimatedGraphicsTaskResponse>(response);
        }
        
        public ListAnimatedGraphicsTaskResponse ListAnimatedGraphicsTask(ListAnimatedGraphicsTaskRequest listAnimatedGraphicsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAnimatedGraphicsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAnimatedGraphicsTaskResponse>(response);
        }
        
        public CreateAgenciesTaskResponse CreateAgenciesTask(CreateAgenciesTaskRequest createAgenciesTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/agencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgenciesTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateAgenciesTaskResponse>(response);
        }
        
        public ListAllBucketsResponse ListAllBuckets(ListAllBucketsRequest listAllBucketsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/buckets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllBucketsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAllBucketsResponse>(response);
        }
        
        public ListAllObsObjListResponse ListAllObsObjList(ListAllObsObjListRequest listAllObsObjListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0-ext/{project_id}/objects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllObsObjListRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAllObsObjListResponse>(response);
        }
        
        public ListNotifyEventResponse ListNotifyEvent(ListNotifyEventRequest listNotifyEventRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification/event",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotifyEventRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNotifyEventResponse>(response);
        }
        
        public ListNotifySmnTopicConfigResponse ListNotifySmnTopicConfig(ListNotifySmnTopicConfigRequest listNotifySmnTopicConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotifySmnTopicConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNotifySmnTopicConfigResponse>(response);
        }
        
        public NotifySmnTopicConfigResponse NotifySmnTopicConfig(NotifySmnTopicConfigRequest notifySmnTopicConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", notifySmnTopicConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<NotifySmnTopicConfigResponse>(response);
        }
        
        public ShowAgenciesTaskResponse ShowAgenciesTask(ShowAgenciesTaskRequest showAgenciesTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/agencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgenciesTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAgenciesTaskResponse>(response);
        }
        
        public UpdateBucketAuthorizedResponse UpdateBucketAuthorized(UpdateBucketAuthorizedRequest updateBucketAuthorizedRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/authority",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBucketAuthorizedRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateBucketAuthorizedResponse>(response);
        }
        
        public CreateEditingJobResponse CreateEditingJob(CreateEditingJobRequest createEditingJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEditingJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateEditingJobResponse>(response);
        }
        
        public DeleteEditingJobResponse DeleteEditingJob(DeleteEditingJobRequest deleteEditingJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEditingJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteEditingJobResponse>(response);
        }
        
        public ListEditingJobResponse ListEditingJob(ListEditingJobRequest listEditingJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEditingJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListEditingJobResponse>(response);
        }
        
        public CreateEncryptTaskResponse CreateEncryptTask(CreateEncryptTaskRequest createEncryptTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEncryptTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateEncryptTaskResponse>(response);
        }
        
        public DeleteEncryptTaskResponse DeleteEncryptTask(DeleteEncryptTaskRequest deleteEncryptTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEncryptTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteEncryptTaskResponse>(response);
        }
        
        public ListEncryptTaskResponse ListEncryptTask(ListEncryptTaskRequest listEncryptTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEncryptTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListEncryptTaskResponse>(response);
        }
        
        public CreateExtractTaskResponse CreateExtractTask(CreateExtractTaskRequest createExtractTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExtractTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateExtractTaskResponse>(response);
        }
        
        public DeleteExtractTaskResponse DeleteExtractTask(DeleteExtractTaskRequest deleteExtractTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteExtractTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteExtractTaskResponse>(response);
        }
        
        public ListExtractTaskResponse ListExtractTask(ListExtractTaskRequest listExtractTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExtractTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListExtractTaskResponse>(response);
        }
        
        public CreateMbTasksReportResponse CreateMbTasksReport(CreateMbTasksReportRequest createMbTasksReportRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/mediabox/tasks/report",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMbTasksReportRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<CreateMbTasksReportResponse>(response);
        }
        
        public CreateMergeChannelsTaskResponse CreateMergeChannelsTask(CreateMergeChannelsTaskRequest createMergeChannelsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeChannelsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateMergeChannelsTaskResponse>(response);
        }
        
        public CreateResetTracksTaskResponse CreateResetTracksTask(CreateResetTracksTaskRequest createResetTracksTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResetTracksTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateResetTracksTaskResponse>(response);
        }
        
        public DeleteMergeChannelsTaskResponse DeleteMergeChannelsTask(DeleteMergeChannelsTaskRequest deleteMergeChannelsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeChannelsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMergeChannelsTaskResponse>(response);
        }
        
        public DeleteResetTracksTaskResponse DeleteResetTracksTask(DeleteResetTracksTaskRequest deleteResetTracksTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResetTracksTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteResetTracksTaskResponse>(response);
        }
        
        public ListMergeChannelsTaskResponse ListMergeChannelsTask(ListMergeChannelsTaskRequest listMergeChannelsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeChannelsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListMergeChannelsTaskResponse>(response);
        }
        
        public ListResetTracksTaskResponse ListResetTracksTask(ListResetTracksTaskRequest listResetTracksTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResetTracksTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListResetTracksTaskResponse>(response);
        }
        
        public CreateMediaProcessTaskResponse CreateMediaProcessTask(CreateMediaProcessTaskRequest createMediaProcessTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMediaProcessTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateMediaProcessTaskResponse>(response);
        }
        
        public DeleteMediaProcessTaskResponse DeleteMediaProcessTask(DeleteMediaProcessTaskRequest deleteMediaProcessTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMediaProcessTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMediaProcessTaskResponse>(response);
        }
        
        public ListMediaProcessTaskResponse ListMediaProcessTask(ListMediaProcessTaskRequest listMediaProcessTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMediaProcessTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListMediaProcessTaskResponse>(response);
        }
        
        public CreateMpeCallBackResponse CreateMpeCallBack(CreateMpeCallBackRequest createMpeCallBackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/mpe/notification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMpeCallBackRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateMpeCallBackResponse>(response);
        }
        
        public CreateQualityEnhanceTemplateResponse CreateQualityEnhanceTemplate(CreateQualityEnhanceTemplateRequest createQualityEnhanceTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createQualityEnhanceTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateQualityEnhanceTemplateResponse>(response);
        }
        
        public DeleteQualityEnhanceTemplateResponse DeleteQualityEnhanceTemplate(DeleteQualityEnhanceTemplateRequest deleteQualityEnhanceTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQualityEnhanceTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteQualityEnhanceTemplateResponse>(response);
        }
        
        public ListQualityEnhanceDefaultTemplateResponse ListQualityEnhanceDefaultTemplate(ListQualityEnhanceDefaultTemplateRequest listQualityEnhanceDefaultTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance/default",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQualityEnhanceDefaultTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListQualityEnhanceDefaultTemplateResponse>(response);
        }
        
        public UpdateQualityEnhanceTemplateResponse UpdateQualityEnhanceTemplate(UpdateQualityEnhanceTemplateRequest updateQualityEnhanceTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateQualityEnhanceTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateQualityEnhanceTemplateResponse>(response);
        }
        
        public ListTranscodeDetailResponse ListTranscodeDetail(ListTranscodeDetailRequest listTranscodeDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTranscodeDetailResponse>(response);
        }
        
        public CancelRemuxTaskResponse CancelRemuxTask(CancelRemuxTaskRequest cancelRemuxTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRemuxTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<CancelRemuxTaskResponse>(response);
        }
        
        public CreateRemuxTaskResponse CreateRemuxTask(CreateRemuxTaskRequest createRemuxTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRemuxTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateRemuxTaskResponse>(response);
        }
        
        public CreateRetryRemuxTaskResponse CreateRetryRemuxTask(CreateRetryRemuxTaskRequest createRetryRemuxTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRetryRemuxTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<CreateRetryRemuxTaskResponse>(response);
        }
        
        public DeleteRemuxTaskResponse DeleteRemuxTask(DeleteRemuxTaskRequest deleteRemuxTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRemuxTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRemuxTaskResponse>(response);
        }
        
        public ListRemuxTaskResponse ListRemuxTask(ListRemuxTaskRequest listRemuxTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRemuxTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRemuxTaskResponse>(response);
        }
        
        public CreateTemplateGroupResponse CreateTemplateGroup(CreateTemplateGroupRequest createTemplateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTemplateGroupResponse>(response);
        }
        
        public DeleteTemplateGroupResponse DeleteTemplateGroup(DeleteTemplateGroupRequest deleteTemplateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTemplateGroupResponse>(response);
        }
        
        public ListTemplateGroupResponse ListTemplateGroup(ListTemplateGroupRequest listTemplateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateGroupResponse>(response);
        }
        
        public UpdateTemplateGroupResponse UpdateTemplateGroup(UpdateTemplateGroupRequest updateTemplateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTemplateGroupResponse>(response);
        }
        
        public CreateThumbnailsTaskResponse CreateThumbnailsTask(CreateThumbnailsTaskRequest createThumbnailsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createThumbnailsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateThumbnailsTaskResponse>(response);
        }
        
        public DeleteThumbnailsTaskResponse DeleteThumbnailsTask(DeleteThumbnailsTaskRequest deleteThumbnailsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteThumbnailsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteThumbnailsTaskResponse>(response);
        }
        
        public ListThumbnailsTaskResponse ListThumbnailsTask(ListThumbnailsTaskRequest listThumbnailsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listThumbnailsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListThumbnailsTaskResponse>(response);
        }
        
        public CreateTranscodingTaskResponse CreateTranscodingTask(CreateTranscodingTaskRequest createTranscodingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTranscodingTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTranscodingTaskResponse>(response);
        }
        
        public DeleteTranscodingTaskResponse DeleteTranscodingTask(DeleteTranscodingTaskRequest deleteTranscodingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTranscodingTaskResponse>(response);
        }
        
        public DeleteTranscodingTaskByConsoleResponse DeleteTranscodingTaskByConsole(DeleteTranscodingTaskByConsoleRequest deleteTranscodingTaskByConsoleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingTaskByConsoleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTranscodingTaskByConsoleResponse>(response);
        }
        
        public ListStatSummaryResponse ListStatSummary(ListStatSummaryRequest listStatSummaryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/summaries",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatSummaryRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListStatSummaryResponse>(response);
        }
        
        public ListTranscodingTaskResponse ListTranscodingTask(ListTranscodingTaskRequest listTranscodingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodingTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTranscodingTaskResponse>(response);
        }
        
        public CreateTransTemplateResponse CreateTransTemplate(CreateTransTemplateRequest createTransTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTransTemplateResponse>(response);
        }
        
        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest deleteTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTemplateResponse>(response);
        }
        
        public ListTemplateResponse ListTemplate(ListTemplateRequest listTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateResponse>(response);
        }
        
        public UpdateTransTemplateResponse UpdateTransTemplate(UpdateTransTemplateRequest updateTransTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTransTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTransTemplateResponse>(response);
        }
        
        public CreateWatermarkTemplateResponse CreateWatermarkTemplate(CreateWatermarkTemplateRequest createWatermarkTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWatermarkTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateWatermarkTemplateResponse>(response);
        }
        
        public DeleteWatermarkTemplateResponse DeleteWatermarkTemplate(DeleteWatermarkTemplateRequest deleteWatermarkTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWatermarkTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteWatermarkTemplateResponse>(response);
        }
        
        public ListWatermarkTemplateResponse ListWatermarkTemplate(ListWatermarkTemplateRequest listWatermarkTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWatermarkTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListWatermarkTemplateResponse>(response);
        }
        
        public UpdateWatermarkTemplateResponse UpdateWatermarkTemplate(UpdateWatermarkTemplateRequest updateWatermarkTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWatermarkTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateWatermarkTemplateResponse>(response);
        }
        
    }
}