// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A class representing the EventHubsPrivateEndpointConnection data model.
    /// Properties of the PrivateEndpointConnection.
    /// </summary>
    public partial class EventHubsPrivateEndpointConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of EventHubsPrivateEndpointConnectionData. </summary>
        public EventHubsPrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of EventHubsPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpoint"> The Private Endpoint resource for this Connection. </param>
        /// <param name="connectionState"> Details about the state of the connection. </param>
        /// <param name="provisioningState"> Provisioning state of the Private Endpoint Connection. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        internal EventHubsPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, WritableSubResource privateEndpoint, ConnectionState connectionState, EndPointProvisioningState? provisioningState, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
            Location = location;
        }

        /// <summary> The Private Endpoint resource for this Connection. </summary>
        internal WritableSubResource PrivateEndpoint { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
            set
            {
                if (PrivateEndpoint is null)
                    PrivateEndpoint = new WritableSubResource();
                PrivateEndpoint.Id = value;
            }
        }

        /// <summary> Details about the state of the connection. </summary>
        public ConnectionState ConnectionState { get; set; }
        /// <summary> Provisioning state of the Private Endpoint Connection. </summary>
        public EndPointProvisioningState? ProvisioningState { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
    }
}
