// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableEventHubsArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableEventHubsArmClient"/> class for mocking. </summary>
        protected MockableEventHubsArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableEventHubsArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableEventHubsArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableEventHubsArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="ClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ClusterResource.CreateResourceIdentifier" /> to create a <see cref="ClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ClusterResource" /> object. </returns>
        public virtual ClusterResource GetClusterResource(ResourceIdentifier id)
        {
            ClusterResource.ValidateResourceId(id);
            return new ClusterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EHNamespaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EHNamespaceResource.CreateResourceIdentifier" /> to create an <see cref="EHNamespaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EHNamespaceResource" /> object. </returns>
        public virtual EHNamespaceResource GetEHNamespaceResource(ResourceIdentifier id)
        {
            EHNamespaceResource.ValidateResourceId(id);
            return new EHNamespaceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkRuleSetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkRuleSetResource.CreateResourceIdentifier" /> to create a <see cref="NetworkRuleSetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkRuleSetResource" /> object. </returns>
        public virtual NetworkRuleSetResource GetNetworkRuleSetResource(ResourceIdentifier id)
        {
            NetworkRuleSetResource.ValidateResourceId(id);
            return new NetworkRuleSetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventHubsNamespaceAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubsNamespaceAuthorizationRuleResource.CreateResourceIdentifier" /> to create an <see cref="EventHubsNamespaceAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubsNamespaceAuthorizationRuleResource" /> object. </returns>
        public virtual EventHubsNamespaceAuthorizationRuleResource GetEventHubsNamespaceAuthorizationRuleResource(ResourceIdentifier id)
        {
            EventHubsNamespaceAuthorizationRuleResource.ValidateResourceId(id);
            return new EventHubsNamespaceAuthorizationRuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource.CreateResourceIdentifier" /> to create an <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource" /> object. </returns>
        public virtual EventHubsDisasterRecoveryAuthorizationRuleResource GetEventHubsDisasterRecoveryAuthorizationRuleResource(ResourceIdentifier id)
        {
            EventHubsDisasterRecoveryAuthorizationRuleResource.ValidateResourceId(id);
            return new EventHubsDisasterRecoveryAuthorizationRuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventHubAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubAuthorizationRuleResource.CreateResourceIdentifier" /> to create an <see cref="EventHubAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubAuthorizationRuleResource" /> object. </returns>
        public virtual EventHubAuthorizationRuleResource GetEventHubAuthorizationRuleResource(ResourceIdentifier id)
        {
            EventHubAuthorizationRuleResource.ValidateResourceId(id);
            return new EventHubAuthorizationRuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventHubsPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubsPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create an <see cref="EventHubsPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubsPrivateEndpointConnectionResource" /> object. </returns>
        public virtual EventHubsPrivateEndpointConnectionResource GetEventHubsPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            EventHubsPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new EventHubsPrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventHubsDisasterRecoveryResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubsDisasterRecoveryResource.CreateResourceIdentifier" /> to create an <see cref="EventHubsDisasterRecoveryResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubsDisasterRecoveryResource" /> object. </returns>
        public virtual EventHubsDisasterRecoveryResource GetEventHubsDisasterRecoveryResource(ResourceIdentifier id)
        {
            EventHubsDisasterRecoveryResource.ValidateResourceId(id);
            return new EventHubsDisasterRecoveryResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventHubResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubResource.CreateResourceIdentifier" /> to create an <see cref="EventHubResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubResource" /> object. </returns>
        public virtual EventHubResource GetEventHubResource(ResourceIdentifier id)
        {
            EventHubResource.ValidateResourceId(id);
            return new EventHubResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventHubsConsumerGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubsConsumerGroupResource.CreateResourceIdentifier" /> to create an <see cref="EventHubsConsumerGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubsConsumerGroupResource" /> object. </returns>
        public virtual EventHubsConsumerGroupResource GetEventHubsConsumerGroupResource(ResourceIdentifier id)
        {
            EventHubsConsumerGroupResource.ValidateResourceId(id);
            return new EventHubsConsumerGroupResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventHubsSchemaGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubsSchemaGroupResource.CreateResourceIdentifier" /> to create an <see cref="EventHubsSchemaGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubsSchemaGroupResource" /> object. </returns>
        public virtual EventHubsSchemaGroupResource GetEventHubsSchemaGroupResource(ResourceIdentifier id)
        {
            EventHubsSchemaGroupResource.ValidateResourceId(id);
            return new EventHubsSchemaGroupResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventHubsApplicationGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubsApplicationGroupResource.CreateResourceIdentifier" /> to create an <see cref="EventHubsApplicationGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubsApplicationGroupResource" /> object. </returns>
        public virtual EventHubsApplicationGroupResource GetEventHubsApplicationGroupResource(ResourceIdentifier id)
        {
            EventHubsApplicationGroupResource.ValidateResourceId(id);
            return new EventHubsApplicationGroupResource(Client, id);
        }
    }
}
