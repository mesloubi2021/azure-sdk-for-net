// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the GalleryInVmAccessControlProfileVersion data model.
    /// Specifies information about the gallery inVMAccessControlProfile version that you want to create or update.
    /// </summary>
    public partial class GalleryInVmAccessControlProfileVersionData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GalleryInVmAccessControlProfileVersionData"/>. </summary>
        /// <param name="location"> The location. </param>
        public GalleryInVmAccessControlProfileVersionData(AzureLocation location) : base(location)
        {
            TargetLocations = new ChangeTrackingList<TargetRegion>();
        }

        /// <summary> Initializes a new instance of <see cref="GalleryInVmAccessControlProfileVersionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="targetLocations"> The target regions where the Resource Profile version is going to be replicated to. This property is updatable. </param>
        /// <param name="excludeFromLatest"> If set to true, Virtual Machines deployed from the latest version of the Resource Profile won't use this Profile version. </param>
        /// <param name="publishedOn"> The timestamp for when the Resource Profile Version is published. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="replicationStatus"> This is the replication status of the gallery image version. </param>
        /// <param name="mode"> This property allows you to specify whether the access control rules are in Audit mode, in Enforce mode or Disabled. Possible values are: 'Audit', 'Enforce' or 'Disabled'. </param>
        /// <param name="defaultAccess"> This property allows you to specify if the requests will be allowed to access the host endpoints. Possible values are: 'Allow', 'Deny'. </param>
        /// <param name="rules"> This is the Access Control Rules specification for an inVMAccessControlProfile version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GalleryInVmAccessControlProfileVersionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IList<TargetRegion> targetLocations, bool? excludeFromLatest, DateTimeOffset? publishedOn, GalleryProvisioningState? provisioningState, ReplicationStatus replicationStatus, GalleryInVmAccessControlRulesMode? mode, ComputeGalleryEndpointAccess? defaultAccess, GalleryInVmAccessControlRules rules, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            TargetLocations = targetLocations;
            ExcludeFromLatest = excludeFromLatest;
            PublishedOn = publishedOn;
            ProvisioningState = provisioningState;
            ReplicationStatus = replicationStatus;
            Mode = mode;
            DefaultAccess = defaultAccess;
            Rules = rules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GalleryInVmAccessControlProfileVersionData"/> for deserialization. </summary>
        internal GalleryInVmAccessControlProfileVersionData()
        {
        }

        /// <summary> The target regions where the Resource Profile version is going to be replicated to. This property is updatable. </summary>
        public IList<TargetRegion> TargetLocations { get; }
        /// <summary> If set to true, Virtual Machines deployed from the latest version of the Resource Profile won't use this Profile version. </summary>
        public bool? ExcludeFromLatest { get; set; }
        /// <summary> The timestamp for when the Resource Profile Version is published. </summary>
        public DateTimeOffset? PublishedOn { get; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public GalleryProvisioningState? ProvisioningState { get; }
        /// <summary> This is the replication status of the gallery image version. </summary>
        public ReplicationStatus ReplicationStatus { get; }
        /// <summary> This property allows you to specify whether the access control rules are in Audit mode, in Enforce mode or Disabled. Possible values are: 'Audit', 'Enforce' or 'Disabled'. </summary>
        public GalleryInVmAccessControlRulesMode? Mode { get; set; }
        /// <summary> This property allows you to specify if the requests will be allowed to access the host endpoints. Possible values are: 'Allow', 'Deny'. </summary>
        public ComputeGalleryEndpointAccess? DefaultAccess { get; set; }
        /// <summary> This is the Access Control Rules specification for an inVMAccessControlProfile version. </summary>
        public GalleryInVmAccessControlRules Rules { get; set; }
    }
}
