using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using G42Cloud.SDK.Core;
using G42Cloud.SDK.Vpc.V2.Model;

namespace G42Cloud.SDK.Vpc.V2
{
    public partial class VpcAsyncClient : Client
    {
        public static ClientBuilder<VpcAsyncClient> NewBuilder()
        {
            return new ClientBuilder<VpcAsyncClient>();
        }

        
        public async Task<AcceptVpcPeeringResponse> AcceptVpcPeeringAsync(AcceptVpcPeeringRequest acceptVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id" , acceptVpcPeeringRequest.PeeringId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}/accept",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptVpcPeeringRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<AcceptVpcPeeringResponse>(response);
        }
        
        public async Task<AssociateRouteTableResponse> AssociateRouteTableAsync(AssociateRouteTableRequest associateRouteTableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id" , associateRouteTableRequest.RoutetableId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateRouteTableRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AssociateRouteTableResponse>(response);
        }
        
        public async Task<BatchCreateSubnetTagsResponse> BatchCreateSubnetTagsAsync(BatchCreateSubnetTagsRequest batchCreateSubnetTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id" , batchCreateSubnetTagsRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSubnetTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateSubnetTagsResponse>(response);
        }
        
        public async Task<BatchDeleteSubnetTagsResponse> BatchDeleteSubnetTagsAsync(BatchDeleteSubnetTagsRequest batchDeleteSubnetTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id" , batchDeleteSubnetTagsRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSubnetTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteSubnetTagsResponse>(response);
        }
        
        public async Task<CreatePortResponse> CreatePortAsync(CreatePortRequest createPortRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPortRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePortResponse>(response);
        }
        
        public async Task<CreateRouteTableResponse> CreateRouteTableAsync(CreateRouteTableRequest createRouteTableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRouteTableRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRouteTableResponse>(response);
        }
        
        public async Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest createSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSecurityGroupResponse>(response);
        }
        
        public async Task<CreateSecurityGroupRuleResponse> CreateSecurityGroupRuleAsync(CreateSecurityGroupRuleRequest createSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSecurityGroupRuleResponse>(response);
        }
        
        public async Task<CreateSubnetResponse> CreateSubnetAsync(CreateSubnetRequest createSubnetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSubnetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSubnetResponse>(response);
        }
        
        public async Task<CreateSubnetTagResponse> CreateSubnetTagAsync(CreateSubnetTagRequest createSubnetTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id" , createSubnetTagRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSubnetTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateSubnetTagResponse>(response);
        }
        
        public async Task<CreateVpcPeeringResponse> CreateVpcPeeringAsync(CreateVpcPeeringRequest createVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcPeeringRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateVpcPeeringResponse>(response);
        }
        
        public async Task<DeletePortResponse> DeletePortAsync(DeletePortRequest deletePortRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id" , deletePortRequest.PortId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePortRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePortResponse>(response);
        }
        
        public async Task<DeleteRouteTableResponse> DeleteRouteTableAsync(DeleteRouteTableRequest deleteRouteTableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id" , deleteRouteTableRequest.RoutetableId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRouteTableRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRouteTableResponse>(response);
        }
        
        public async Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest deleteSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , deleteSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupResponse>(response);
        }
        
        public async Task<DeleteSecurityGroupRuleResponse> DeleteSecurityGroupRuleAsync(DeleteSecurityGroupRuleRequest deleteSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id" , deleteSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules/{security_group_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupRuleResponse>(response);
        }
        
        public async Task<DeleteSubnetResponse> DeleteSubnetAsync(DeleteSubnetRequest deleteSubnetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , deleteSubnetRequest.VpcId.ToString());
            urlParam.Add("subnet_id" , deleteSubnetRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}/subnets/{subnet_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubnetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSubnetResponse>(response);
        }
        
        public async Task<DeleteSubnetTagResponse> DeleteSubnetTagAsync(DeleteSubnetTagRequest deleteSubnetTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id" , deleteSubnetTagRequest.SubnetId.ToString());
            urlParam.Add("key" , deleteSubnetTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubnetTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSubnetTagResponse>(response);
        }
        
        public async Task<DeleteVpcPeeringResponse> DeleteVpcPeeringAsync(DeleteVpcPeeringRequest deleteVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id" , deleteVpcPeeringRequest.PeeringId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcPeeringRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVpcPeeringResponse>(response);
        }
        
        public async Task<DisassociateRouteTableResponse> DisassociateRouteTableAsync(DisassociateRouteTableRequest disassociateRouteTableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id" , disassociateRouteTableRequest.RoutetableId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateRouteTableRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DisassociateRouteTableResponse>(response);
        }
        
        public async Task<ListPortsResponse> ListPortsAsync(ListPortsRequest listPortsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPortsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPortsResponse>(response);
        }
        
        public async Task<ListRouteTablesResponse> ListRouteTablesAsync(ListRouteTablesRequest listRouteTablesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRouteTablesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRouteTablesResponse>(response);
        }
        
        public async Task<ListSecurityGroupRulesResponse> ListSecurityGroupRulesAsync(ListSecurityGroupRulesRequest listSecurityGroupRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSecurityGroupRulesResponse>(response);
        }
        
        public async Task<ListSecurityGroupsResponse> ListSecurityGroupsAsync(ListSecurityGroupsRequest listSecurityGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSecurityGroupsResponse>(response);
        }
        
        public async Task<ListSubnetTagsResponse> ListSubnetTagsAsync(ListSubnetTagsRequest listSubnetTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubnetTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSubnetTagsResponse>(response);
        }
        
        public async Task<ListSubnetsResponse> ListSubnetsAsync(ListSubnetsRequest listSubnetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubnetsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSubnetsResponse>(response);
        }
        
        public async Task<ListSubnetsByTagsResponse> ListSubnetsByTagsAsync(ListSubnetsByTagsRequest listSubnetsByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSubnetsByTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListSubnetsByTagsResponse>(response);
        }
        
        public async Task<ListVpcPeeringsResponse> ListVpcPeeringsAsync(ListVpcPeeringsRequest listVpcPeeringsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcPeeringsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVpcPeeringsResponse>(response);
        }
        
        public async Task<RejectVpcPeeringResponse> RejectVpcPeeringAsync(RejectVpcPeeringRequest rejectVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id" , rejectVpcPeeringRequest.PeeringId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}/reject",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", rejectVpcPeeringRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<RejectVpcPeeringResponse>(response);
        }
        
        public async Task<ShowPortResponse> ShowPortAsync(ShowPortRequest showPortRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id" , showPortRequest.PortId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPortRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPortResponse>(response);
        }
        
        public async Task<ShowQuotaResponse> ShowQuotaAsync(ShowQuotaRequest showQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }
        
        public async Task<ShowRouteTableResponse> ShowRouteTableAsync(ShowRouteTableRequest showRouteTableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id" , showRouteTableRequest.RoutetableId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRouteTableRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRouteTableResponse>(response);
        }
        
        public async Task<ShowSecurityGroupResponse> ShowSecurityGroupAsync(ShowSecurityGroupRequest showSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , showSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSecurityGroupResponse>(response);
        }
        
        public async Task<ShowSecurityGroupRuleResponse> ShowSecurityGroupRuleAsync(ShowSecurityGroupRuleRequest showSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id" , showSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules/{security_group_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSecurityGroupRuleResponse>(response);
        }
        
        public async Task<ShowSubnetResponse> ShowSubnetAsync(ShowSubnetRequest showSubnetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id" , showSubnetRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets/{subnet_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubnetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSubnetResponse>(response);
        }
        
        public async Task<ShowSubnetTagsResponse> ShowSubnetTagsAsync(ShowSubnetTagsRequest showSubnetTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id" , showSubnetTagsRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubnetTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSubnetTagsResponse>(response);
        }
        
        public async Task<ShowVpcPeeringResponse> ShowVpcPeeringAsync(ShowVpcPeeringRequest showVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id" , showVpcPeeringRequest.PeeringId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcPeeringRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVpcPeeringResponse>(response);
        }
        
        public async Task<UpdatePortResponse> UpdatePortAsync(UpdatePortRequest updatePortRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id" , updatePortRequest.PortId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePortRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePortResponse>(response);
        }
        
        public async Task<UpdateRouteTableResponse> UpdateRouteTableAsync(UpdateRouteTableRequest updateRouteTableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id" , updateRouteTableRequest.RoutetableId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRouteTableRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRouteTableResponse>(response);
        }
        
        public async Task<UpdateSubnetResponse> UpdateSubnetAsync(UpdateSubnetRequest updateSubnetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , updateSubnetRequest.VpcId.ToString());
            urlParam.Add("subnet_id" , updateSubnetRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}/subnets/{subnet_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSubnetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSubnetResponse>(response);
        }
        
        public async Task<UpdateVpcPeeringResponse> UpdateVpcPeeringAsync(UpdateVpcPeeringRequest updateVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id" , updateVpcPeeringRequest.PeeringId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVpcPeeringRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVpcPeeringResponse>(response);
        }
        
        public async Task<CreatePrivateipResponse> CreatePrivateipAsync(CreatePrivateipRequest createPrivateipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPrivateipRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePrivateipResponse>(response);
        }
        
        public async Task<DeletePrivateipResponse> DeletePrivateipAsync(DeletePrivateipRequest deletePrivateipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("privateip_id" , deletePrivateipRequest.PrivateipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips/{privateip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateipRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePrivateipResponse>(response);
        }
        
        public async Task<ListPrivateipsResponse> ListPrivateipsAsync(ListPrivateipsRequest listPrivateipsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id" , listPrivateipsRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets/{subnet_id}/privateips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateipsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPrivateipsResponse>(response);
        }
        
        public async Task<ShowNetworkIpAvailabilitiesResponse> ShowNetworkIpAvailabilitiesAsync(ShowNetworkIpAvailabilitiesRequest showNetworkIpAvailabilitiesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("network_id" , showNetworkIpAvailabilitiesRequest.NetworkId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/network-ip-availabilities/{network_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkIpAvailabilitiesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowNetworkIpAvailabilitiesResponse>(response);
        }
        
        public async Task<ShowPrivateipResponse> ShowPrivateipAsync(ShowPrivateipRequest showPrivateipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("privateip_id" , showPrivateipRequest.PrivateipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips/{privateip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateipRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPrivateipResponse>(response);
        }
        
        public async Task<NeutronCreateSecurityGroupResponse> NeutronCreateSecurityGroupAsync(NeutronCreateSecurityGroupRequest neutronCreateSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<NeutronCreateSecurityGroupResponse>(response);
        }
        
        public async Task<NeutronCreateSecurityGroupRuleResponse> NeutronCreateSecurityGroupRuleAsync(NeutronCreateSecurityGroupRuleRequest neutronCreateSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateSecurityGroupRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<NeutronCreateSecurityGroupRuleResponse>(response);
        }
        
        public async Task<NeutronDeleteSecurityGroupResponse> NeutronDeleteSecurityGroupAsync(NeutronDeleteSecurityGroupRequest neutronDeleteSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , neutronDeleteSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<NeutronDeleteSecurityGroupResponse>(response);
        }
        
        public async Task<NeutronDeleteSecurityGroupRuleResponse> NeutronDeleteSecurityGroupRuleAsync(NeutronDeleteSecurityGroupRuleRequest neutronDeleteSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id" , neutronDeleteSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules/{security_group_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteSecurityGroupRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<NeutronDeleteSecurityGroupRuleResponse>(response);
        }
        
        public async Task<NeutronListSecurityGroupRulesResponse> NeutronListSecurityGroupRulesAsync(NeutronListSecurityGroupRulesRequest neutronListSecurityGroupRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListSecurityGroupRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NeutronListSecurityGroupRulesResponse>(response);
        }
        
        public async Task<NeutronListSecurityGroupsResponse> NeutronListSecurityGroupsAsync(NeutronListSecurityGroupsRequest neutronListSecurityGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListSecurityGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NeutronListSecurityGroupsResponse>(response);
        }
        
        public async Task<NeutronShowSecurityGroupResponse> NeutronShowSecurityGroupAsync(NeutronShowSecurityGroupRequest neutronShowSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , neutronShowSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NeutronShowSecurityGroupResponse>(response);
        }
        
        public async Task<NeutronShowSecurityGroupRuleResponse> NeutronShowSecurityGroupRuleAsync(NeutronShowSecurityGroupRuleRequest neutronShowSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id" , neutronShowSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules/{security_group_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowSecurityGroupRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NeutronShowSecurityGroupRuleResponse>(response);
        }
        
        public async Task<NeutronUpdateSecurityGroupResponse> NeutronUpdateSecurityGroupAsync(NeutronUpdateSecurityGroupRequest neutronUpdateSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , neutronUpdateSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<NeutronUpdateSecurityGroupResponse>(response);
        }
        
        public async Task<NeutronAddFirewallRuleResponse> NeutronAddFirewallRuleAsync(NeutronAddFirewallRuleRequest neutronAddFirewallRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id" , neutronAddFirewallRuleRequest.FirewallPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}/insert_rule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronAddFirewallRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<NeutronAddFirewallRuleResponse>(response);
        }
        
        public async Task<NeutronCreateFirewallGroupResponse> NeutronCreateFirewallGroupAsync(NeutronCreateFirewallGroupRequest neutronCreateFirewallGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<NeutronCreateFirewallGroupResponse>(response);
        }
        
        public async Task<NeutronCreateFirewallPolicyResponse> NeutronCreateFirewallPolicyAsync(NeutronCreateFirewallPolicyRequest neutronCreateFirewallPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<NeutronCreateFirewallPolicyResponse>(response);
        }
        
        public async Task<NeutronCreateFirewallRuleResponse> NeutronCreateFirewallRuleAsync(NeutronCreateFirewallRuleRequest neutronCreateFirewallRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<NeutronCreateFirewallRuleResponse>(response);
        }
        
        public async Task<NeutronDeleteFirewallGroupResponse> NeutronDeleteFirewallGroupAsync(NeutronDeleteFirewallGroupRequest neutronDeleteFirewallGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_group_id" , neutronDeleteFirewallGroupRequest.FirewallGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<NeutronDeleteFirewallGroupResponse>(response);
        }
        
        public async Task<NeutronDeleteFirewallPolicyResponse> NeutronDeleteFirewallPolicyAsync(NeutronDeleteFirewallPolicyRequest neutronDeleteFirewallPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id" , neutronDeleteFirewallPolicyRequest.FirewallPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<NeutronDeleteFirewallPolicyResponse>(response);
        }
        
        public async Task<NeutronDeleteFirewallRuleResponse> NeutronDeleteFirewallRuleAsync(NeutronDeleteFirewallRuleRequest neutronDeleteFirewallRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_rule_id" , neutronDeleteFirewallRuleRequest.FirewallRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<NeutronDeleteFirewallRuleResponse>(response);
        }
        
        public async Task<NeutronListFirewallGroupsResponse> NeutronListFirewallGroupsAsync(NeutronListFirewallGroupsRequest neutronListFirewallGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NeutronListFirewallGroupsResponse>(response);
        }
        
        public async Task<NeutronListFirewallPoliciesResponse> NeutronListFirewallPoliciesAsync(NeutronListFirewallPoliciesRequest neutronListFirewallPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallPoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NeutronListFirewallPoliciesResponse>(response);
        }
        
        public async Task<NeutronListFirewallRulesResponse> NeutronListFirewallRulesAsync(NeutronListFirewallRulesRequest neutronListFirewallRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NeutronListFirewallRulesResponse>(response);
        }
        
        public async Task<NeutronRemoveFirewallRuleResponse> NeutronRemoveFirewallRuleAsync(NeutronRemoveFirewallRuleRequest neutronRemoveFirewallRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id" , neutronRemoveFirewallRuleRequest.FirewallPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}/remove_rule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronRemoveFirewallRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<NeutronRemoveFirewallRuleResponse>(response);
        }
        
        public async Task<NeutronShowFirewallGroupResponse> NeutronShowFirewallGroupAsync(NeutronShowFirewallGroupRequest neutronShowFirewallGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_group_id" , neutronShowFirewallGroupRequest.FirewallGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NeutronShowFirewallGroupResponse>(response);
        }
        
        public async Task<NeutronShowFirewallPolicyResponse> NeutronShowFirewallPolicyAsync(NeutronShowFirewallPolicyRequest neutronShowFirewallPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id" , neutronShowFirewallPolicyRequest.FirewallPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NeutronShowFirewallPolicyResponse>(response);
        }
        
        public async Task<NeutronShowFirewallRuleResponse> NeutronShowFirewallRuleAsync(NeutronShowFirewallRuleRequest neutronShowFirewallRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_rule_id" , neutronShowFirewallRuleRequest.FirewallRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NeutronShowFirewallRuleResponse>(response);
        }
        
        public async Task<NeutronUpdateFirewallGroupResponse> NeutronUpdateFirewallGroupAsync(NeutronUpdateFirewallGroupRequest neutronUpdateFirewallGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_group_id" , neutronUpdateFirewallGroupRequest.FirewallGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<NeutronUpdateFirewallGroupResponse>(response);
        }
        
        public async Task<NeutronUpdateFirewallPolicyResponse> NeutronUpdateFirewallPolicyAsync(NeutronUpdateFirewallPolicyRequest neutronUpdateFirewallPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id" , neutronUpdateFirewallPolicyRequest.FirewallPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<NeutronUpdateFirewallPolicyResponse>(response);
        }
        
        public async Task<NeutronUpdateFirewallRuleResponse> NeutronUpdateFirewallRuleAsync(NeutronUpdateFirewallRuleRequest neutronUpdateFirewallRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_rule_id" , neutronUpdateFirewallRuleRequest.FirewallRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<NeutronUpdateFirewallRuleResponse>(response);
        }
        
        public async Task<BatchCreateVpcTagsResponse> BatchCreateVpcTagsAsync(BatchCreateVpcTagsRequest batchCreateVpcTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , batchCreateVpcTagsRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateVpcTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateVpcTagsResponse>(response);
        }
        
        public async Task<BatchDeleteVpcTagsResponse> BatchDeleteVpcTagsAsync(BatchDeleteVpcTagsRequest batchDeleteVpcTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , batchDeleteVpcTagsRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteVpcTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteVpcTagsResponse>(response);
        }
        
        public async Task<CreateVpcResponse> CreateVpcAsync(CreateVpcRequest createVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateVpcResponse>(response);
        }
        
        public async Task<CreateVpcResourceTagResponse> CreateVpcResourceTagAsync(CreateVpcResourceTagRequest createVpcResourceTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , createVpcResourceTagRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcResourceTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateVpcResourceTagResponse>(response);
        }
        
        public async Task<CreateVpcRouteResponse> CreateVpcRouteAsync(CreateVpcRouteRequest createVpcRouteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcRouteRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateVpcRouteResponse>(response);
        }
        
        public async Task<DeleteVpcResponse> DeleteVpcAsync(DeleteVpcRequest deleteVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , deleteVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVpcResponse>(response);
        }
        
        public async Task<DeleteVpcRouteResponse> DeleteVpcRouteAsync(DeleteVpcRouteRequest deleteVpcRouteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("route_id" , deleteVpcRouteRequest.RouteId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes/{route_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRouteRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVpcRouteResponse>(response);
        }
        
        public async Task<DeleteVpcTagResponse> DeleteVpcTagAsync(DeleteVpcTagRequest deleteVpcTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , deleteVpcTagRequest.VpcId.ToString());
            urlParam.Add("key" , deleteVpcTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVpcTagResponse>(response);
        }
        
        public async Task<ListVpcRoutesResponse> ListVpcRoutesAsync(ListVpcRoutesRequest listVpcRoutesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcRoutesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVpcRoutesResponse>(response);
        }
        
        public async Task<ListVpcTagsResponse> ListVpcTagsAsync(ListVpcTagsRequest listVpcTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVpcTagsResponse>(response);
        }
        
        public async Task<ListVpcsResponse> ListVpcsAsync(ListVpcsRequest listVpcsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVpcsResponse>(response);
        }
        
        public async Task<ListVpcsByTagsResponse> ListVpcsByTagsAsync(ListVpcsByTagsRequest listVpcsByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listVpcsByTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListVpcsByTagsResponse>(response);
        }
        
        public async Task<ShowVpcResponse> ShowVpcAsync(ShowVpcRequest showVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , showVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVpcResponse>(response);
        }
        
        public async Task<ShowVpcRouteResponse> ShowVpcRouteAsync(ShowVpcRouteRequest showVpcRouteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("route_id" , showVpcRouteRequest.RouteId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes/{route_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRouteRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVpcRouteResponse>(response);
        }
        
        public async Task<ShowVpcTagsResponse> ShowVpcTagsAsync(ShowVpcTagsRequest showVpcTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , showVpcTagsRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVpcTagsResponse>(response);
        }
        
        public async Task<UpdateVpcResponse> UpdateVpcAsync(UpdateVpcRequest updateVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , updateVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVpcRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVpcResponse>(response);
        }
        
    }
}