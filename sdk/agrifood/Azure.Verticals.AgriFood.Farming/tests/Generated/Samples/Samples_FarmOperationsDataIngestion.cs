// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Verticals.AgriFood.Farming;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    public partial class Samples_FarmOperationsDataIngestion
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetJobDetails_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmOperationsDataIngestion client = new FarmBeatsClient(credential).GetFarmOperationsDataIngestionClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetJobDetails("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("authProviderId").ToString());
            Console.WriteLine(result.GetProperty("startYear").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetJobDetails_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmOperationsDataIngestion client = new FarmBeatsClient(credential).GetFarmOperationsDataIngestionClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetJobDetailsAsync("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("authProviderId").ToString());
            Console.WriteLine(result.GetProperty("startYear").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetJobDetails_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmOperationsDataIngestion client = new FarmBeatsClient(credential).GetFarmOperationsDataIngestionClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetJobDetails("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("authProviderId").ToString());
            Console.WriteLine(result.GetProperty("operations")[0].ToString());
            Console.WriteLine(result.GetProperty("startYear").ToString());
            Console.WriteLine(result.GetProperty("isIncremental").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetJobDetails_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmOperationsDataIngestion client = new FarmBeatsClient(credential).GetFarmOperationsDataIngestionClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetJobDetailsAsync("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("authProviderId").ToString());
            Console.WriteLine(result.GetProperty("operations")[0].ToString());
            Console.WriteLine(result.GetProperty("startYear").ToString());
            Console.WriteLine(result.GetProperty("isIncremental").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateJob_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmOperationsDataIngestion client = new FarmBeatsClient(credential).GetFarmOperationsDataIngestionClient(apiVersion: "2022-11-01-preview");

            using RequestContent content = RequestContent.Create(new
            {
                partyId = "<partyId>",
                authProviderId = "<authProviderId>",
                startYear = 1234,
            });
            Operation<BinaryData> operation = client.CreateJob(WaitUntil.Completed, "<jobId>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("authProviderId").ToString());
            Console.WriteLine(result.GetProperty("startYear").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateJob_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmOperationsDataIngestion client = new FarmBeatsClient(credential).GetFarmOperationsDataIngestionClient(apiVersion: "2022-11-01-preview");

            using RequestContent content = RequestContent.Create(new
            {
                partyId = "<partyId>",
                authProviderId = "<authProviderId>",
                startYear = 1234,
            });
            Operation<BinaryData> operation = await client.CreateJobAsync(WaitUntil.Completed, "<jobId>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("authProviderId").ToString());
            Console.WriteLine(result.GetProperty("startYear").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateJob_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmOperationsDataIngestion client = new FarmBeatsClient(credential).GetFarmOperationsDataIngestionClient(apiVersion: "2022-11-01-preview");

            using RequestContent content = RequestContent.Create(new
            {
                partyId = "<partyId>",
                authProviderId = "<authProviderId>",
                operations = new object[]
            {
"<operations>"
            },
                startYear = 1234,
                isIncremental = true,
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Operation<BinaryData> operation = client.CreateJob(WaitUntil.Completed, "<jobId>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("authProviderId").ToString());
            Console.WriteLine(result.GetProperty("operations")[0].ToString());
            Console.WriteLine(result.GetProperty("startYear").ToString());
            Console.WriteLine(result.GetProperty("isIncremental").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateJob_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmOperationsDataIngestion client = new FarmBeatsClient(credential).GetFarmOperationsDataIngestionClient(apiVersion: "2022-11-01-preview");

            using RequestContent content = RequestContent.Create(new
            {
                partyId = "<partyId>",
                authProviderId = "<authProviderId>",
                operations = new object[]
            {
"<operations>"
            },
                startYear = 1234,
                isIncremental = true,
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Operation<BinaryData> operation = await client.CreateJobAsync(WaitUntil.Completed, "<jobId>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("authProviderId").ToString());
            Console.WriteLine(result.GetProperty("operations")[0].ToString());
            Console.WriteLine(result.GetProperty("startYear").ToString());
            Console.WriteLine(result.GetProperty("isIncremental").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }
    }
}
