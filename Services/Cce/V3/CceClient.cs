using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using G42Cloud.SDK.Cce.V3.Model;

namespace G42Cloud.SDK.Cce.V3
{
    public partial class CceClient : Client
    {
        public static ClientBuilder<CceClient> NewBuilder()
        {
            return new ClientBuilder<CceClient>();
        }

        
        public AwakeClusterResponse AwakeCluster(AwakeClusterRequest awakeClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , awakeClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/awake",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", awakeClusterRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<AwakeClusterResponse>(response);
        }
        
        public CreateAddonInstanceResponse CreateAddonInstance(CreateAddonInstanceRequest createAddonInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddonInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAddonInstanceResponse>(response);
        }
        
        public CreateCloudPersistentVolumeClaimsResponse CreateCloudPersistentVolumeClaims(CreateCloudPersistentVolumeClaimsRequest createCloudPersistentVolumeClaimsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createCloudPersistentVolumeClaimsRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v1/namespaces/{namespace}/cloudpersistentvolumeclaims",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCloudPersistentVolumeClaimsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateCloudPersistentVolumeClaimsResponse>(response);
        }
        
        public CreateClusterResponse CreateCluster(CreateClusterRequest createClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateClusterResponse>(response);
        }
        
        public CreateKubernetesClusterCertResponse CreateKubernetesClusterCert(CreateKubernetesClusterCertRequest createKubernetesClusterCertRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , createKubernetesClusterCertRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/clustercert",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKubernetesClusterCertRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateKubernetesClusterCertResponse>(response);
        }
        
        public CreateNodeResponse CreateNode(CreateNodeRequest createNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , createNodeRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateNodeResponse>(response);
        }
        
        public CreateNodePoolResponse CreateNodePool(CreateNodePoolRequest createNodePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , createNodePoolRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNodePoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateNodePoolResponse>(response);
        }
        
        public DeleteAddonInstanceResponse DeleteAddonInstance(DeleteAddonInstanceRequest deleteAddonInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , deleteAddonInstanceRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddonInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteAddonInstanceResponse deleteAddonInstanceResponse = JsonUtils.DeSerializeNull<DeleteAddonInstanceResponse>(response);
            return deleteAddonInstanceResponse;
        }
        
        public DeleteCloudPersistentVolumeClaimsResponse DeleteCloudPersistentVolumeClaims(DeleteCloudPersistentVolumeClaimsRequest deleteCloudPersistentVolumeClaimsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("name" , deleteCloudPersistentVolumeClaimsRequest.Name.ToString());
            urlParam.Add("namespace" , deleteCloudPersistentVolumeClaimsRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v1/namespaces/{namespace}/cloudpersistentvolumeclaims/{name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCloudPersistentVolumeClaimsRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteCloudPersistentVolumeClaimsResponse>(response);
        }
        
        public DeleteClusterResponse DeleteCluster(DeleteClusterRequest deleteClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , deleteClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteClusterResponse>(response);
        }
        
        public DeleteNodeResponse DeleteNode(DeleteNodeRequest deleteNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , deleteNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id" , deleteNodeRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteNodeResponse>(response);
        }
        
        public DeleteNodePoolResponse DeleteNodePool(DeleteNodePoolRequest deleteNodePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , deleteNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id" , deleteNodePoolRequest.NodepoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodePoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteNodePoolResponse>(response);
        }
        
        public HibernateClusterResponse HibernateCluster(HibernateClusterRequest hibernateClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , hibernateClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/hibernate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", hibernateClusterRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<HibernateClusterResponse>(response);
        }
        
        public ListAddonInstancesResponse ListAddonInstances(ListAddonInstancesRequest listAddonInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAddonInstancesResponse>(response);
        }
        
        public ListAddonTemplatesResponse ListAddonTemplates(ListAddonTemplatesRequest listAddonTemplatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addontemplates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonTemplatesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAddonTemplatesResponse>(response);
        }
        
        public ListClustersResponse ListClusters(ListClustersRequest listClustersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClustersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListClustersResponse>(response);
        }
        
        public ListNodePoolsResponse ListNodePools(ListNodePoolsRequest listNodePoolsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , listNodePoolsRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodePoolsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNodePoolsResponse>(response);
        }
        
        public ListNodesResponse ListNodes(ListNodesRequest listNodesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , listNodesRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNodesResponse>(response);
        }
        
        public MigrateNodeResponse MigrateNode(MigrateNodeRequest migrateNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , migrateNodeRequest.ClusterId.ToString());
            urlParam.Add("target_cluster_id" , migrateNodeRequest.TargetClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/operation/migrateto/{target_cluster_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<MigrateNodeResponse>(response);
        }
        
        public RemoveNodeResponse RemoveNode(RemoveNodeRequest removeNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , removeNodeRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/operation/remove",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<RemoveNodeResponse>(response);
        }
        
        public ShowAddonInstanceResponse ShowAddonInstance(ShowAddonInstanceRequest showAddonInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , showAddonInstanceRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddonInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAddonInstanceResponse>(response);
        }
        
        public ShowClusterResponse ShowCluster(ShowClusterRequest showClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , showClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowClusterResponse>(response);
        }
        
        public ShowJobResponse ShowJob(ShowJobRequest showJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }
        
        public ShowNodeResponse ShowNode(ShowNodeRequest showNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , showNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id" , showNodeRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowNodeResponse>(response);
        }
        
        public ShowNodePoolResponse ShowNodePool(ShowNodePoolRequest showNodePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , showNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id" , showNodePoolRequest.NodepoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowNodePoolResponse>(response);
        }
        
        public UpdateAddonInstanceResponse UpdateAddonInstance(UpdateAddonInstanceRequest updateAddonInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , updateAddonInstanceRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddonInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAddonInstanceResponse>(response);
        }
        
        public UpdateClusterResponse UpdateCluster(UpdateClusterRequest updateClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , updateClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateClusterResponse>(response);
        }
        
        public UpdateNodeResponse UpdateNode(UpdateNodeRequest updateNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , updateNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id" , updateNodeRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateNodeResponse>(response);
        }
        
        public UpdateNodePoolResponse UpdateNodePool(UpdateNodePoolRequest updateNodePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , updateNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id" , updateNodePoolRequest.NodepoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodePoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateNodePoolResponse>(response);
        }
        
    }
}