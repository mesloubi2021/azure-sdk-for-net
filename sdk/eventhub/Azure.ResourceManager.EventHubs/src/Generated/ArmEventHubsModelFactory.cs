// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.EventHubs;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmEventHubsModelFactory
    {
        /// <summary> Initializes a new instance of AvailableCluster. </summary>
        /// <param name="location"> Location fo the Available Cluster. </param>
        /// <returns> A new <see cref="Models.AvailableCluster"/> instance for mocking. </returns>
        public static AvailableCluster AvailableCluster(AzureLocation? location = null)
        {
            return new AvailableCluster(location);
        }

        /// <summary> Initializes a new instance of ClusterData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Properties of the cluster SKU. </param>
        /// <param name="createdAt"> The UTC time when the Event Hubs Cluster was created. </param>
        /// <param name="provisioningState"> Provisioning state of the Cluster. </param>
        /// <param name="updatedAt"> The UTC time when the Event Hubs Cluster was last updated. </param>
        /// <param name="metricId"> The metric ID of the cluster resource. Provided by the service and not modifiable by the user. </param>
        /// <param name="status"> Status of the Cluster resource. </param>
        /// <param name="supportsScaling"> A value that indicates whether Scaling is Supported. </param>
        /// <param name="upgradePreferences"> Properties of the cluster upgrade preferences. </param>
        /// <returns> A new <see cref="EventHubs.ClusterData"/> instance for mocking. </returns>
        public static ClusterData ClusterData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ClusterSku sku = null, string createdAt = null, ProvisioningState? provisioningState = null, string updatedAt = null, string metricId = null, string status = null, bool? supportsScaling = null, UpgradePreferences upgradePreferences = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ClusterData(id, name, resourceType, systemData, tags, location, sku, createdAt, provisioningState, updatedAt, metricId, status, supportsScaling, upgradePreferences);
        }

        /// <summary> Initializes a new instance of EHNamespaceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Properties of sku resource. </param>
        /// <param name="identity"> Properties of BYOK Identity description. </param>
        /// <param name="minimumTlsVersion"> The minimum TLS version for the cluster to support, e.g. '1.2'. </param>
        /// <param name="provisioningState"> Provisioning state of the Namespace. </param>
        /// <param name="status"> Status of the Namespace. </param>
        /// <param name="createdOn"> The time the Namespace was created. </param>
        /// <param name="updatedOn"> The time the Namespace was updated. </param>
        /// <param name="serviceBusEndpoint"> Endpoint you can use to perform Service Bus operations. </param>
        /// <param name="clusterArmId"> Cluster ARM ID of the Namespace. </param>
        /// <param name="metricId"> Identifier for Azure Insights metrics. </param>
        /// <param name="isAutoInflateEnabled"> Value that indicates whether AutoInflate is enabled for eventhub namespace. </param>
        /// <param name="publicNetworkAccess"> This determines if traffic is allowed over public network. By default it is enabled. </param>
        /// <param name="maximumThroughputUnits"> Upper limit of throughput units when AutoInflate is enabled, value should be within 0 to 20 throughput units. ( '0' if AutoInflateEnabled = true). </param>
        /// <param name="kafkaEnabled"> Value that indicates whether Kafka is enabled for eventhub namespace. </param>
        /// <param name="zoneRedundant"> Enabling this property creates a Standard Event Hubs Namespace in regions supported availability zones. </param>
        /// <param name="encryption"> Properties of BYOK Encryption description. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections. </param>
        /// <param name="disableLocalAuth"> This property disables SAS authentication for the Event Hubs namespace. </param>
        /// <param name="alternateName"> Alternate name specified when alias and namespace names are same. </param>
        /// <returns> A new <see cref="EventHubs.EHNamespaceData"/> instance for mocking. </returns>
        public static EHNamespaceData EHNamespaceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, EventHubsSku sku = null, ManagedServiceIdentity identity = null, EventHubsTlsVersion? minimumTlsVersion = null, string provisioningState = null, string status = null, DateTimeOffset? createdOn = null, DateTimeOffset? updatedOn = null, string serviceBusEndpoint = null, string clusterArmId = null, string metricId = null, bool? isAutoInflateEnabled = null, EventHubsPublicNetworkAccess? publicNetworkAccess = null, int? maximumThroughputUnits = null, bool? kafkaEnabled = null, bool? zoneRedundant = null, Encryption encryption = null, IEnumerable<EventHubsPrivateEndpointConnectionData> privateEndpointConnections = null, bool? disableLocalAuth = null, string alternateName = null)
        {
            tags ??= new Dictionary<string, string>();
            privateEndpointConnections ??= new List<EventHubsPrivateEndpointConnectionData>();

            return new EHNamespaceData(id, name, resourceType, systemData, tags, location, sku, identity, minimumTlsVersion, provisioningState, status, createdOn, updatedOn, serviceBusEndpoint, clusterArmId, metricId, isAutoInflateEnabled, publicNetworkAccess, maximumThroughputUnits, kafkaEnabled, zoneRedundant, encryption, privateEndpointConnections?.ToList(), disableLocalAuth, alternateName);
        }

        /// <summary> Initializes a new instance of EventHubsPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpointId"> The Private Endpoint resource for this Connection. </param>
        /// <param name="connectionState"> Details about the state of the connection. </param>
        /// <param name="provisioningState"> Provisioning state of the Private Endpoint Connection. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="EventHubs.EventHubsPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static EventHubsPrivateEndpointConnectionData EventHubsPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceIdentifier privateEndpointId = null, ConnectionState connectionState = null, EndPointProvisioningState? provisioningState = null, AzureLocation? location = null)
        {
            return new EventHubsPrivateEndpointConnectionData(id, name, resourceType, systemData, privateEndpointId != null ? ResourceManagerModelFactory.WritableSubResource(privateEndpointId) : null, connectionState, provisioningState, location);
        }

        /// <summary> Initializes a new instance of EventHubsPrivateLinkResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The private link resource Private link DNS zone name. </param>
        /// <returns> A new <see cref="Models.EventHubsPrivateLinkResource"/> instance for mocking. </returns>
        public static EventHubsPrivateLinkResource EventHubsPrivateLinkResource(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new EventHubsPrivateLinkResource(id, name, resourceType, systemData, groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList());
        }

        /// <summary> Initializes a new instance of EventHubsNetworkSecurityPerimeterConfiguration. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of NetworkSecurityPerimeter configuration propagation. </param>
        /// <param name="provisioningIssues"> List of Provisioning Issues if any. </param>
        /// <param name="networkSecurityPerimeter"> NetworkSecurityPerimeter related information. </param>
        /// <param name="resourceAssociation"> Information about resource association. </param>
        /// <param name="profile"> Information about current network profile. </param>
        /// <param name="isBackingResource"> True if the EventHub namespace is backed by another Azure resource and not visible to end users. </param>
        /// <param name="applicableFeatures"> Indicates that the NSP controls related to backing association are only applicable to a specific feature in backing resource's data plane. </param>
        /// <param name="parentAssociationName"> Source Resource Association name. </param>
        /// <param name="sourceResourceId"> ARM Id of source resource. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="Models.EventHubsNetworkSecurityPerimeterConfiguration"/> instance for mocking. </returns>
        public static EventHubsNetworkSecurityPerimeterConfiguration EventHubsNetworkSecurityPerimeterConfiguration(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, EventHubsNetworkSecurityPerimeterConfigurationProvisioningState? provisioningState = null, IEnumerable<EventHubsProvisioningIssue> provisioningIssues = null, EventHubsNetworkSecurityPerimeter networkSecurityPerimeter = null, EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation resourceAssociation = null, EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile profile = null, bool? isBackingResource = null, IEnumerable<string> applicableFeatures = null, string parentAssociationName = null, string sourceResourceId = null, AzureLocation? location = null)
        {
            provisioningIssues ??= new List<EventHubsProvisioningIssue>();
            applicableFeatures ??= new List<string>();

            return new EventHubsNetworkSecurityPerimeterConfiguration(id, name, resourceType, systemData, provisioningState, provisioningIssues?.ToList(), networkSecurityPerimeter, resourceAssociation, profile, isBackingResource, applicableFeatures?.ToList(), parentAssociationName, sourceResourceId, location);
        }

        /// <summary> Initializes a new instance of EventHubsProvisioningIssue. </summary>
        /// <param name="name"> Name of the issue. </param>
        /// <param name="properties"> Properties of Provisioning Issue. </param>
        /// <returns> A new <see cref="Models.EventHubsProvisioningIssue"/> instance for mocking. </returns>
        public static EventHubsProvisioningIssue EventHubsProvisioningIssue(string name = null, EventHubsProvisioningIssueProperties properties = null)
        {
            return new EventHubsProvisioningIssue(name, properties);
        }

        /// <summary> Initializes a new instance of EventHubsProvisioningIssueProperties. </summary>
        /// <param name="issueType"> Type of Issue. </param>
        /// <param name="description"> Description of the issue. </param>
        /// <returns> A new <see cref="Models.EventHubsProvisioningIssueProperties"/> instance for mocking. </returns>
        public static EventHubsProvisioningIssueProperties EventHubsProvisioningIssueProperties(string issueType = null, string description = null)
        {
            return new EventHubsProvisioningIssueProperties(issueType, description);
        }

        /// <summary> Initializes a new instance of EventHubsNetworkSecurityPerimeter. </summary>
        /// <param name="id"> Fully qualified identifier of the resource. </param>
        /// <param name="perimeterGuid"> Guid of the resource. </param>
        /// <param name="location"> Location of the resource. </param>
        /// <returns> A new <see cref="Models.EventHubsNetworkSecurityPerimeter"/> instance for mocking. </returns>
        public static EventHubsNetworkSecurityPerimeter EventHubsNetworkSecurityPerimeter(string id = null, string perimeterGuid = null, AzureLocation? location = null)
        {
            return new EventHubsNetworkSecurityPerimeter(id, perimeterGuid, location);
        }

        /// <summary> Initializes a new instance of EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation. </summary>
        /// <param name="name"> Name of the resource association. </param>
        /// <param name="accessMode"> Access Mode of the resource association. </param>
        /// <returns> A new <see cref="Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation"/> instance for mocking. </returns>
        public static EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation(string name = null, EventHubsResourceAssociationAccessMode? accessMode = null)
        {
            return new EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation(name, accessMode);
        }

        /// <summary> Initializes a new instance of EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile. </summary>
        /// <param name="name"> Name of the resource. </param>
        /// <param name="accessRulesVersion"> Current access rules version. </param>
        /// <param name="accessRules"> List of Access Rules. </param>
        /// <returns> A new <see cref="Models.EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile"/> instance for mocking. </returns>
        public static EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile(string name = null, string accessRulesVersion = null, IEnumerable<EventHubsNspAccessRule> accessRules = null)
        {
            accessRules ??= new List<EventHubsNspAccessRule>();

            return new EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile(name, accessRulesVersion, accessRules?.ToList());
        }

        /// <summary> Initializes a new instance of EventHubsNspAccessRule. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of Access Rule. </param>
        /// <returns> A new <see cref="Models.EventHubsNspAccessRule"/> instance for mocking. </returns>
        public static EventHubsNspAccessRule EventHubsNspAccessRule(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, EventHubsNspAccessRuleProperties properties = null)
        {
            return new EventHubsNspAccessRule(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of EventHubsNspAccessRuleProperties. </summary>
        /// <param name="direction"> Direction of Access Rule. </param>
        /// <param name="addressPrefixes"> Address prefixes in the CIDR format for inbound rules. </param>
        /// <param name="subscriptions"> Subscriptions for inbound rules. </param>
        /// <param name="networkSecurityPerimeters"> NetworkSecurityPerimeters for inbound rules. </param>
        /// <param name="fullyQualifiedDomainNames"> FQDN for outbound rules. </param>
        /// <returns> A new <see cref="Models.EventHubsNspAccessRuleProperties"/> instance for mocking. </returns>
        public static EventHubsNspAccessRuleProperties EventHubsNspAccessRuleProperties(EventHubsNspAccessRuleDirection? direction = null, IEnumerable<string> addressPrefixes = null, IEnumerable<SubResource> subscriptions = null, IEnumerable<EventHubsNetworkSecurityPerimeter> networkSecurityPerimeters = null, IEnumerable<string> fullyQualifiedDomainNames = null)
        {
            addressPrefixes ??= new List<string>();
            subscriptions ??= new List<SubResource>();
            networkSecurityPerimeters ??= new List<EventHubsNetworkSecurityPerimeter>();
            fullyQualifiedDomainNames ??= new List<string>();

            return new EventHubsNspAccessRuleProperties(direction, addressPrefixes?.ToList(), subscriptions?.ToList(), networkSecurityPerimeters?.ToList(), fullyQualifiedDomainNames?.ToList());
        }

        /// <summary> Initializes a new instance of NetworkRuleSetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="trustedServiceAccessEnabled"> Value that indicates whether Trusted Service Access is Enabled or not. </param>
        /// <param name="defaultAction"> Default Action for Network Rule Set. </param>
        /// <param name="virtualNetworkRules"> List VirtualNetwork Rules. </param>
        /// <param name="ipRules"> List of IpRules. </param>
        /// <param name="publicNetworkAccess"> This determines if traffic is allowed over public network. By default it is enabled. If value is SecuredByPerimeter then Inbound and Outbound communication is controlled by the network security perimeter and profile's access rules. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="EventHubs.NetworkRuleSetData"/> instance for mocking. </returns>
        public static NetworkRuleSetData NetworkRuleSetData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, bool? trustedServiceAccessEnabled = null, DefaultAction? defaultAction = null, IEnumerable<NWRuleSetVirtualNetworkRules> virtualNetworkRules = null, IEnumerable<NWRuleSetIPRules> ipRules = null, PublicNetworkAccessFlag? publicNetworkAccess = null, AzureLocation? location = null)
        {
            virtualNetworkRules ??= new List<NWRuleSetVirtualNetworkRules>();
            ipRules ??= new List<NWRuleSetIPRules>();

            return new NetworkRuleSetData(id, name, resourceType, systemData, trustedServiceAccessEnabled, defaultAction, virtualNetworkRules?.ToList(), ipRules?.ToList(), publicNetworkAccess, location);
        }

        /// <summary> Initializes a new instance of EventHubsAuthorizationRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="rights"> The rights associated with the rule. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="EventHubs.EventHubsAuthorizationRuleData"/> instance for mocking. </returns>
        public static EventHubsAuthorizationRuleData EventHubsAuthorizationRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IEnumerable<EventHubsAccessRight> rights = null, AzureLocation? location = null)
        {
            rights ??= new List<EventHubsAccessRight>();

            return new EventHubsAuthorizationRuleData(id, name, resourceType, systemData, rights?.ToList(), location);
        }

        /// <summary> Initializes a new instance of EventHubsAccessKeys. </summary>
        /// <param name="primaryConnectionString"> Primary connection string of the created namespace AuthorizationRule. </param>
        /// <param name="secondaryConnectionString"> Secondary connection string of the created namespace AuthorizationRule. </param>
        /// <param name="aliasPrimaryConnectionString"> Primary connection string of the alias if GEO DR is enabled. </param>
        /// <param name="aliasSecondaryConnectionString"> Secondary  connection string of the alias if GEO DR is enabled. </param>
        /// <param name="primaryKey"> A base64-encoded 256-bit primary key for signing and validating the SAS token. </param>
        /// <param name="secondaryKey"> A base64-encoded 256-bit primary key for signing and validating the SAS token. </param>
        /// <param name="keyName"> A string that describes the AuthorizationRule. </param>
        /// <returns> A new <see cref="Models.EventHubsAccessKeys"/> instance for mocking. </returns>
        public static EventHubsAccessKeys EventHubsAccessKeys(string primaryConnectionString = null, string secondaryConnectionString = null, string aliasPrimaryConnectionString = null, string aliasSecondaryConnectionString = null, string primaryKey = null, string secondaryKey = null, string keyName = null)
        {
            return new EventHubsAccessKeys(primaryConnectionString, secondaryConnectionString, aliasPrimaryConnectionString, aliasSecondaryConnectionString, primaryKey, secondaryKey, keyName);
        }

        /// <summary> Initializes a new instance of EventHubsNameAvailabilityResult. </summary>
        /// <param name="message"> The detailed info regarding the reason associated with the Namespace. </param>
        /// <param name="nameAvailable"> Value indicating Namespace is availability, true if the Namespace is available; otherwise, false. </param>
        /// <param name="reason"> The reason for unavailability of a Namespace. </param>
        /// <returns> A new <see cref="Models.EventHubsNameAvailabilityResult"/> instance for mocking. </returns>
        public static EventHubsNameAvailabilityResult EventHubsNameAvailabilityResult(string message = null, bool? nameAvailable = null, EventHubsNameUnavailableReason? reason = null)
        {
            return new EventHubsNameAvailabilityResult(message, nameAvailable, reason);
        }

        /// <summary> Initializes a new instance of EventHubsConsumerGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="createdOn"> Exact time the message was created. </param>
        /// <param name="updatedOn"> The exact time the message was updated. </param>
        /// <param name="userMetadata"> User Metadata is a placeholder to store user-defined string data with maximum length 1024. e.g. it can be used to store descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="EventHubs.EventHubsConsumerGroupData"/> instance for mocking. </returns>
        public static EventHubsConsumerGroupData EventHubsConsumerGroupData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DateTimeOffset? createdOn = null, DateTimeOffset? updatedOn = null, string userMetadata = null, AzureLocation? location = null)
        {
            return new EventHubsConsumerGroupData(id, name, resourceType, systemData, createdOn, updatedOn, userMetadata, location);
        }

        /// <summary> Initializes a new instance of EventHubsDisasterRecoveryData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the Alias(Disaster Recovery configuration) - possible values 'Accepted' or 'Succeeded' or 'Failed'. </param>
        /// <param name="partnerNamespace"> ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairing. </param>
        /// <param name="alternateName"> Alternate name specified when alias and namespace names are same. </param>
        /// <param name="role"> role of namespace in GEO DR - possible values 'Primary' or 'PrimaryNotReplicating' or 'Secondary'. </param>
        /// <param name="pendingReplicationOperationsCount"> Number of entities pending to be replicated. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="EventHubs.EventHubsDisasterRecoveryData"/> instance for mocking. </returns>
        public static EventHubsDisasterRecoveryData EventHubsDisasterRecoveryData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, EventHubsDisasterRecoveryProvisioningState? provisioningState = null, string partnerNamespace = null, string alternateName = null, EventHubsDisasterRecoveryRole? role = null, long? pendingReplicationOperationsCount = null, AzureLocation? location = null)
        {
            return new EventHubsDisasterRecoveryData(id, name, resourceType, systemData, provisioningState, partnerNamespace, alternateName, role, pendingReplicationOperationsCount, location);
        }

        /// <summary> Initializes a new instance of EventHubData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="partitionIds"> Current number of shards on the Event Hub. </param>
        /// <param name="createdOn"> Exact time the Event Hub was created. </param>
        /// <param name="updatedOn"> The exact time the message was updated. </param>
        /// <param name="partitionCount"> Number of partitions created for the Event Hub, allowed values are from 1 to 32 partitions. </param>
        /// <param name="status"> Enumerates the possible values for the status of the Event Hub. </param>
        /// <param name="captureDescription"> Properties of capture description. </param>
        /// <param name="retentionDescription"> Event Hub retention settings. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="EventHubs.EventHubData"/> instance for mocking. </returns>
        public static EventHubData EventHubData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IEnumerable<string> partitionIds = null, DateTimeOffset? createdOn = null, DateTimeOffset? updatedOn = null, long? partitionCount = null, EventHubEntityStatus? status = null, CaptureDescription captureDescription = null, RetentionDescription retentionDescription = null, AzureLocation? location = null)
        {
            partitionIds ??= new List<string>();

            return new EventHubData(id, name, resourceType, systemData, partitionIds?.ToList(), createdOn, updatedOn, partitionCount, status, captureDescription, retentionDescription, location);
        }

        /// <summary> Initializes a new instance of EventHubsSchemaGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="updatedAtUtc"> Exact time the Schema Group was updated. </param>
        /// <param name="createdAtUtc"> Exact time the Schema Group was created. </param>
        /// <param name="eTag"> The ETag value. </param>
        /// <param name="groupProperties"> dictionary object for SchemaGroup group properties. </param>
        /// <param name="schemaCompatibility"></param>
        /// <param name="schemaType"></param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="EventHubs.EventHubsSchemaGroupData"/> instance for mocking. </returns>
        public static EventHubsSchemaGroupData EventHubsSchemaGroupData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DateTimeOffset? updatedAtUtc = null, DateTimeOffset? createdAtUtc = null, ETag? eTag = null, IDictionary<string, string> groupProperties = null, EventHubsSchemaCompatibility? schemaCompatibility = null, EventHubsSchemaType? schemaType = null, AzureLocation? location = null)
        {
            groupProperties ??= new Dictionary<string, string>();

            return new EventHubsSchemaGroupData(id, name, resourceType, systemData, updatedAtUtc, createdAtUtc, eTag, groupProperties, schemaCompatibility, schemaType, location);
        }

        /// <summary> Initializes a new instance of EventHubsApplicationGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isEnabled"> Determines if Application Group is allowed to create connection with namespace or not. Once the isEnabled is set to false, all the existing connections of application group gets dropped and no new connections will be allowed. </param>
        /// <param name="clientAppGroupIdentifier"> The Unique identifier for application group.Supports SAS(SASKeyName=KeyName) or AAD(AADAppID=Guid). </param>
        /// <param name="policies">
        /// List of group policies that define the behavior of application group. The policies can support resource governance scenarios such as limiting ingress or egress traffic.
        /// Please note <see cref="EventHubsApplicationGroupPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="EventHubsThrottlingPolicy"/>.
        /// </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="EventHubs.EventHubsApplicationGroupData"/> instance for mocking. </returns>
        public static EventHubsApplicationGroupData EventHubsApplicationGroupData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, bool? isEnabled = null, string clientAppGroupIdentifier = null, IEnumerable<EventHubsApplicationGroupPolicy> policies = null, AzureLocation? location = null)
        {
            policies ??= new List<EventHubsApplicationGroupPolicy>();

            return new EventHubsApplicationGroupData(id, name, resourceType, systemData, isEnabled, clientAppGroupIdentifier, policies?.ToList(), location);
        }
    }
}
