// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Orbital.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Orbital
{
    /// <summary>
    /// A class representing a collection of <see cref="AvailableGroundStationResource" /> and their operations.
    /// Each <see cref="AvailableGroundStationResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get an <see cref="AvailableGroundStationCollection" /> instance call the GetAvailableGroundStations method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class AvailableGroundStationCollection : ArmCollection
    {
        private readonly ClientDiagnostics _availableGroundStationClientDiagnostics;
        private readonly AvailableGroundStationsRestOperations _availableGroundStationRestClient;

        /// <summary> Initializes a new instance of the <see cref="AvailableGroundStationCollection"/> class for mocking. </summary>
        protected AvailableGroundStationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AvailableGroundStationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AvailableGroundStationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _availableGroundStationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Orbital", AvailableGroundStationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AvailableGroundStationResource.ResourceType, out string availableGroundStationApiVersion);
            _availableGroundStationRestClient = new AvailableGroundStationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, availableGroundStationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified available ground station.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/availableGroundStations/{groundStationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableGroundStations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groundStationName"> Ground Station name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groundStationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groundStationName"/> is null. </exception>
        public virtual async Task<Response<AvailableGroundStationResource>> GetAsync(string groundStationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groundStationName, nameof(groundStationName));

            using var scope = _availableGroundStationClientDiagnostics.CreateScope("AvailableGroundStationCollection.Get");
            scope.Start();
            try
            {
                var response = await _availableGroundStationRestClient.GetAsync(Id.SubscriptionId, groundStationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvailableGroundStationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified available ground station.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/availableGroundStations/{groundStationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableGroundStations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groundStationName"> Ground Station name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groundStationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groundStationName"/> is null. </exception>
        public virtual Response<AvailableGroundStationResource> Get(string groundStationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groundStationName, nameof(groundStationName));

            using var scope = _availableGroundStationClientDiagnostics.CreateScope("AvailableGroundStationCollection.Get");
            scope.Start();
            try
            {
                var response = _availableGroundStationRestClient.Get(Id.SubscriptionId, groundStationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvailableGroundStationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns list of available ground stations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/availableGroundStations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableGroundStations_ListByCapability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capability"> Ground Station Capability. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailableGroundStationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvailableGroundStationResource> GetAllAsync(GroundStationCapability capability, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _availableGroundStationRestClient.CreateListByCapabilityRequest(Id.SubscriptionId, capability);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _availableGroundStationRestClient.CreateListByCapabilityNextPageRequest(nextLink, Id.SubscriptionId, capability);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AvailableGroundStationResource(Client, AvailableGroundStationData.DeserializeAvailableGroundStationData(e)), _availableGroundStationClientDiagnostics, Pipeline, "AvailableGroundStationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns list of available ground stations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/availableGroundStations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableGroundStations_ListByCapability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capability"> Ground Station Capability. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailableGroundStationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvailableGroundStationResource> GetAll(GroundStationCapability capability, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _availableGroundStationRestClient.CreateListByCapabilityRequest(Id.SubscriptionId, capability);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _availableGroundStationRestClient.CreateListByCapabilityNextPageRequest(nextLink, Id.SubscriptionId, capability);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AvailableGroundStationResource(Client, AvailableGroundStationData.DeserializeAvailableGroundStationData(e)), _availableGroundStationClientDiagnostics, Pipeline, "AvailableGroundStationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/availableGroundStations/{groundStationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableGroundStations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groundStationName"> Ground Station name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groundStationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groundStationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string groundStationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groundStationName, nameof(groundStationName));

            using var scope = _availableGroundStationClientDiagnostics.CreateScope("AvailableGroundStationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _availableGroundStationRestClient.GetAsync(Id.SubscriptionId, groundStationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/availableGroundStations/{groundStationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableGroundStations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groundStationName"> Ground Station name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groundStationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groundStationName"/> is null. </exception>
        public virtual Response<bool> Exists(string groundStationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groundStationName, nameof(groundStationName));

            using var scope = _availableGroundStationClientDiagnostics.CreateScope("AvailableGroundStationCollection.Exists");
            scope.Start();
            try
            {
                var response = _availableGroundStationRestClient.Get(Id.SubscriptionId, groundStationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/availableGroundStations/{groundStationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableGroundStations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groundStationName"> Ground Station name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groundStationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groundStationName"/> is null. </exception>
        public virtual async Task<NullableResponse<AvailableGroundStationResource>> GetIfExistsAsync(string groundStationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groundStationName, nameof(groundStationName));

            using var scope = _availableGroundStationClientDiagnostics.CreateScope("AvailableGroundStationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _availableGroundStationRestClient.GetAsync(Id.SubscriptionId, groundStationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AvailableGroundStationResource>(response.GetRawResponse());
                return Response.FromValue(new AvailableGroundStationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/availableGroundStations/{groundStationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableGroundStations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groundStationName"> Ground Station name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groundStationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groundStationName"/> is null. </exception>
        public virtual NullableResponse<AvailableGroundStationResource> GetIfExists(string groundStationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groundStationName, nameof(groundStationName));

            using var scope = _availableGroundStationClientDiagnostics.CreateScope("AvailableGroundStationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _availableGroundStationRestClient.Get(Id.SubscriptionId, groundStationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AvailableGroundStationResource>(response.GetRawResponse());
                return Response.FromValue(new AvailableGroundStationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
