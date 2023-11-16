// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableEventHubsResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableEventHubsResourceGroupResource"/> class for mocking. </summary>
        protected MockableEventHubsResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableEventHubsResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableEventHubsResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ClusterResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ClusterResources and their operations over a ClusterResource. </returns>
        public virtual ClusterCollection GetClusters()
        {
            return GetCachedClient(client => new ClusterCollection(client, Id));
        }

        /// <summary>
        /// Gets the resource description of the specified Event Hubs Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ClusterResource>> GetClusterAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            return await GetClusters().GetAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the resource description of the specified Event Hubs Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ClusterResource> GetCluster(string clusterName, CancellationToken cancellationToken = default)
        {
            return GetClusters().Get(clusterName, cancellationToken);
        }

        /// <summary> Gets a collection of EHNamespaceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of EHNamespaceResources and their operations over a EHNamespaceResource. </returns>
        public virtual EHNamespaceCollection GetEHNamespaces()
        {
            return GetCachedClient(client => new EHNamespaceCollection(client, Id));
        }

        /// <summary>
        /// Gets the description of the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<EHNamespaceResource>> GetEHNamespaceAsync(string namespaceName, CancellationToken cancellationToken = default)
        {
            return await GetEHNamespaces().GetAsync(namespaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the description of the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<EHNamespaceResource> GetEHNamespace(string namespaceName, CancellationToken cancellationToken = default)
        {
            return GetEHNamespaces().Get(namespaceName, cancellationToken);
        }
    }
}
