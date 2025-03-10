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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EdgeOrder
{
    /// <summary>
    /// A class representing a collection of <see cref="EdgeOrderResource" /> and their operations.
    /// Each <see cref="EdgeOrderResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="EdgeOrderCollection" /> instance call the GetEdgeOrders method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class EdgeOrderCollection : ArmCollection
    {
        private readonly ClientDiagnostics _edgeOrderClientDiagnostics;
        private readonly EdgeOrderManagementRestOperations _edgeOrderRestClient;

        /// <summary> Initializes a new instance of the <see cref="EdgeOrderCollection"/> class for mocking. </summary>
        protected EdgeOrderCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EdgeOrderCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EdgeOrderCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _edgeOrderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EdgeOrder", EdgeOrderResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EdgeOrderResource.ResourceType, out string edgeOrderApiVersion);
            _edgeOrderRestClient = new EdgeOrderManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, edgeOrderApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets an order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetOrderByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderName"/> is null. </exception>
        public virtual async Task<Response<EdgeOrderResource>> GetAsync(AzureLocation location, string orderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderName, nameof(orderName));

            using var scope = _edgeOrderClientDiagnostics.CreateScope("EdgeOrderCollection.Get");
            scope.Start();
            try
            {
                var response = await _edgeOrderRestClient.GetOrderByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, location, orderName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EdgeOrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetOrderByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderName"/> is null. </exception>
        public virtual Response<EdgeOrderResource> Get(AzureLocation location, string orderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderName, nameof(orderName));

            using var scope = _edgeOrderClientDiagnostics.CreateScope("EdgeOrderCollection.Get");
            scope.Start();
            try
            {
                var response = _edgeOrderRestClient.GetOrderByName(Id.SubscriptionId, Id.ResourceGroupName, location, orderName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EdgeOrderResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetOrderByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(AzureLocation location, string orderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderName, nameof(orderName));

            using var scope = _edgeOrderClientDiagnostics.CreateScope("EdgeOrderCollection.Exists");
            scope.Start();
            try
            {
                var response = await _edgeOrderRestClient.GetOrderByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, location, orderName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetOrderByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderName"/> is null. </exception>
        public virtual Response<bool> Exists(AzureLocation location, string orderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderName, nameof(orderName));

            using var scope = _edgeOrderClientDiagnostics.CreateScope("EdgeOrderCollection.Exists");
            scope.Start();
            try
            {
                var response = _edgeOrderRestClient.GetOrderByName(Id.SubscriptionId, Id.ResourceGroupName, location, orderName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetOrderByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderName"/> is null. </exception>
        public virtual async Task<NullableResponse<EdgeOrderResource>> GetIfExistsAsync(AzureLocation location, string orderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderName, nameof(orderName));

            using var scope = _edgeOrderClientDiagnostics.CreateScope("EdgeOrderCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _edgeOrderRestClient.GetOrderByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, location, orderName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<EdgeOrderResource>(response.GetRawResponse());
                return Response.FromValue(new EdgeOrderResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetOrderByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderName"/> is null. </exception>
        public virtual NullableResponse<EdgeOrderResource> GetIfExists(AzureLocation location, string orderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(orderName, nameof(orderName));

            using var scope = _edgeOrderClientDiagnostics.CreateScope("EdgeOrderCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _edgeOrderRestClient.GetOrderByName(Id.SubscriptionId, Id.ResourceGroupName, location, orderName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<EdgeOrderResource>(response.GetRawResponse());
                return Response.FromValue(new EdgeOrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
