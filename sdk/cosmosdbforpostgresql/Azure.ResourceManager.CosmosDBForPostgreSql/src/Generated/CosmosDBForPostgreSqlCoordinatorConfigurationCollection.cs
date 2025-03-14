// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBForPostgreSqlCoordinatorConfigurationResource" /> and their operations.
    /// Each <see cref="CosmosDBForPostgreSqlCoordinatorConfigurationResource" /> in the collection will belong to the same instance of <see cref="CosmosDBForPostgreSqlClusterResource" />.
    /// To get a <see cref="CosmosDBForPostgreSqlCoordinatorConfigurationCollection" /> instance call the GetCosmosDBForPostgreSqlCoordinatorConfigurations method from an instance of <see cref="CosmosDBForPostgreSqlClusterResource" />.
    /// </summary>
    public partial class CosmosDBForPostgreSqlCoordinatorConfigurationCollection : ArmCollection
    {
        private readonly ClientDiagnostics _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsClientDiagnostics;
        private readonly ConfigurationsRestOperations _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBForPostgreSqlCoordinatorConfigurationCollection"/> class for mocking. </summary>
        protected CosmosDBForPostgreSqlCoordinatorConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBForPostgreSqlCoordinatorConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBForPostgreSqlCoordinatorConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDBForPostgreSql", CosmosDBForPostgreSqlCoordinatorConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBForPostgreSqlCoordinatorConfigurationResource.ResourceType, out string cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsApiVersion);
            _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsRestClient = new ConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBForPostgreSqlClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBForPostgreSqlClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates configuration of coordinator in a cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/coordinatorConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_UpdateOnCoordinator</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationName"> The name of the cluster configuration. </param>
        /// <param name="data"> The required parameters for updating a cluster configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBForPostgreSqlCoordinatorConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string configurationName, CosmosDBForPostgreSqlServerConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsClientDiagnostics.CreateScope("CosmosDBForPostgreSqlCoordinatorConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsRestClient.UpdateOnCoordinatorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBForPostgreSqlArmOperation<CosmosDBForPostgreSqlCoordinatorConfigurationResource>(new CosmosDBForPostgreSqlCoordinatorConfigurationOperationSource(Client), _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsClientDiagnostics, Pipeline, _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsRestClient.CreateUpdateOnCoordinatorRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates configuration of coordinator in a cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/coordinatorConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_UpdateOnCoordinator</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationName"> The name of the cluster configuration. </param>
        /// <param name="data"> The required parameters for updating a cluster configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CosmosDBForPostgreSqlCoordinatorConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string configurationName, CosmosDBForPostgreSqlServerConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsClientDiagnostics.CreateScope("CosmosDBForPostgreSqlCoordinatorConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsRestClient.UpdateOnCoordinator(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data, cancellationToken);
                var operation = new CosmosDBForPostgreSqlArmOperation<CosmosDBForPostgreSqlCoordinatorConfigurationResource>(new CosmosDBForPostgreSqlCoordinatorConfigurationOperationSource(Client), _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsClientDiagnostics, Pipeline, _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsRestClient.CreateUpdateOnCoordinatorRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information of a configuration for coordinator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/coordinatorConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_GetCoordinator</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the cluster configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<Response<CosmosDBForPostgreSqlCoordinatorConfigurationResource>> GetAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsClientDiagnostics.CreateScope("CosmosDBForPostgreSqlCoordinatorConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsRestClient.GetCoordinatorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlCoordinatorConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information of a configuration for coordinator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/coordinatorConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_GetCoordinator</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the cluster configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual Response<CosmosDBForPostgreSqlCoordinatorConfigurationResource> Get(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsClientDiagnostics.CreateScope("CosmosDBForPostgreSqlCoordinatorConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsRestClient.GetCoordinator(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlCoordinatorConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/coordinatorConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_GetCoordinator</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the cluster configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsClientDiagnostics.CreateScope("CosmosDBForPostgreSqlCoordinatorConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsRestClient.GetCoordinatorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/coordinatorConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_GetCoordinator</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the cluster configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsClientDiagnostics.CreateScope("CosmosDBForPostgreSqlCoordinatorConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsRestClient.GetCoordinator(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/coordinatorConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_GetCoordinator</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the cluster configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<NullableResponse<CosmosDBForPostgreSqlCoordinatorConfigurationResource>> GetIfExistsAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsClientDiagnostics.CreateScope("CosmosDBForPostgreSqlCoordinatorConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsRestClient.GetCoordinatorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBForPostgreSqlCoordinatorConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlCoordinatorConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/coordinatorConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_GetCoordinator</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the cluster configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual NullableResponse<CosmosDBForPostgreSqlCoordinatorConfigurationResource> GetIfExists(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsClientDiagnostics.CreateScope("CosmosDBForPostgreSqlCoordinatorConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlCoordinatorConfigurationConfigurationsRestClient.GetCoordinator(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBForPostgreSqlCoordinatorConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlCoordinatorConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
