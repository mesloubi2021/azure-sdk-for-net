// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.EventHubs;
using Azure.ResourceManager.EventHubs.Models;

namespace Azure.ResourceManager.EventHubs.Samples
{
    public partial class Sample_EventHubResource
    {
        // EventHubCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_EventHubCreate()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubCreate.json
            // this example is just showing the usage of "EventHubs_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubResource created on azure
            // for more information of creating EventHubResource, please refer to the document of EventHubResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "Default-NotificationHubs-AustraliaEast";
            string namespaceName = "sdk-Namespace-5357";
            string eventHubName = "sdk-EventHub-6547";
            ResourceIdentifier eventHubResourceId = EventHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName);
            EventHubResource eventHub = client.GetEventHubResource(eventHubResourceId);

            // invoke the operation
            EventHubData data = new EventHubData()
            {
                PartitionCount = 4,
                Status = EventHubEntityStatus.Active,
                CaptureDescription = new CaptureDescription()
                {
                    Enabled = true,
                    Encoding = EncodingCaptureDescription.Avro,
                    IntervalInSeconds = 120,
                    SizeLimitInBytes = 10485763,
                    Destination = new EventHubDestination()
                    {
                        Name = "EventHubArchive.AzureBlockBlob",
                        Identity = new CaptureIdentity()
                        {
                            IdentityType = CaptureIdentityType.UserAssigned,
                            UserAssignedIdentity = "/subscriptions/SampleSubscription/resourceGroups/ResurceGroupSample/providers/Microsoft.ManagedIdentity/userAssignedIdentities/ud2",
                        },
                        StorageAccountResourceId = new ResourceIdentifier("/subscriptions/e2f361f0-3b27-4503-a9cc-21cfba380093/resourceGroups/Default-Storage-SouthCentralUS/providers/Microsoft.ClassicStorage/storageAccounts/arjunteststorage"),
                        BlobContainer = "container",
                        ArchiveNameFormat = "{Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}",
                    },
                },
                RetentionDescription = new RetentionDescription()
                {
                    CleanupPolicy = CleanupPolicyRetentionDescription.Compact,
                    RetentionTimeInHours = 96,
                    TombstoneRetentionTimeInHours = 1,
                },
            };
            ArmOperation<EventHubResource> lro = await eventHub.UpdateAsync(WaitUntil.Completed, data);
            EventHubResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // EventHubDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_EventHubDelete()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubDelete.json
            // this example is just showing the usage of "EventHubs_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubResource created on azure
            // for more information of creating EventHubResource, please refer to the document of EventHubResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-5357";
            string eventHubName = "sdk-EventHub-6547";
            ResourceIdentifier eventHubResourceId = EventHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName);
            EventHubResource eventHub = client.GetEventHubResource(eventHubResourceId);

            // invoke the operation
            await eventHub.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // EventHubGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_EventHubGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubGet.json
            // this example is just showing the usage of "EventHubs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubResource created on azure
            // for more information of creating EventHubResource, please refer to the document of EventHubResource
            string subscriptionId = "e2f361f0-3b27-4503-a9cc-21cfba380093";
            string resourceGroupName = "Default-NotificationHubs-AustraliaEast";
            string namespaceName = "sdk-Namespace-716";
            string eventHubName = "sdk-EventHub-10";
            ResourceIdentifier eventHubResourceId = EventHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName);
            EventHubResource eventHub = client.GetEventHubResource(eventHubResourceId);

            // invoke the operation
            EventHubResource result = await eventHub.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
