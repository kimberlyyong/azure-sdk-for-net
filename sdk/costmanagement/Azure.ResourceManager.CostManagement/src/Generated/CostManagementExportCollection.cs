// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CostManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="CostManagementExportResource" /> and their operations.
    /// Each <see cref="CostManagementExportResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="CostManagementExportCollection" /> instance call the GetCostManagementExports method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class CostManagementExportCollection : ArmCollection, IEnumerable<CostManagementExportResource>, IAsyncEnumerable<CostManagementExportResource>
    {
        private readonly ClientDiagnostics _costManagementExportExportsClientDiagnostics;
        private readonly ExportsRestOperations _costManagementExportExportsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CostManagementExportCollection"/> class for mocking. </summary>
        protected CostManagementExportCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CostManagementExportCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CostManagementExportCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _costManagementExportExportsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CostManagement", CostManagementExportResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CostManagementExportResource.ResourceType, out string costManagementExportExportsApiVersion);
            _costManagementExportExportsRestClient = new ExportsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, costManagementExportExportsApiVersion);
        }

        /// <summary>
        /// The operation to create or update a export. Update operation requires latest eTag to be set in the request. You may obtain the latest eTag by performing a get operation. Create operation does not require eTag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="exportName"> Export Name. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate Export operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exportName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CostManagementExportResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string exportName, CostManagementExportData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exportName, nameof(exportName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _costManagementExportExportsClientDiagnostics.CreateScope("CostManagementExportCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _costManagementExportExportsRestClient.CreateOrUpdateAsync(Id, exportName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CostManagementArmOperation<CostManagementExportResource>(Response.FromValue(new CostManagementExportResource(Client, response), response.GetRawResponse()));
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
        /// The operation to create or update a export. Update operation requires latest eTag to be set in the request. You may obtain the latest eTag by performing a get operation. Create operation does not require eTag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="exportName"> Export Name. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate Export operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exportName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CostManagementExportResource> CreateOrUpdate(WaitUntil waitUntil, string exportName, CostManagementExportData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exportName, nameof(exportName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _costManagementExportExportsClientDiagnostics.CreateScope("CostManagementExportCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _costManagementExportExportsRestClient.CreateOrUpdate(Id, exportName, data, cancellationToken);
                var operation = new CostManagementArmOperation<CostManagementExportResource>(Response.FromValue(new CostManagementExportResource(Client, response), response.GetRawResponse()));
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
        /// The operation to get the export for the defined scope by export name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exportName"> Export Name. </param>
        /// <param name="expand"> May be used to expand the properties within an export. Currently only 'runHistory' is supported and will return information for the last 10 runs of the export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exportName"/> is null. </exception>
        public virtual async Task<Response<CostManagementExportResource>> GetAsync(string exportName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exportName, nameof(exportName));

            using var scope = _costManagementExportExportsClientDiagnostics.CreateScope("CostManagementExportCollection.Get");
            scope.Start();
            try
            {
                var response = await _costManagementExportExportsRestClient.GetAsync(Id, exportName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CostManagementExportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the export for the defined scope by export name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exportName"> Export Name. </param>
        /// <param name="expand"> May be used to expand the properties within an export. Currently only 'runHistory' is supported and will return information for the last 10 runs of the export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exportName"/> is null. </exception>
        public virtual Response<CostManagementExportResource> Get(string exportName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exportName, nameof(exportName));

            using var scope = _costManagementExportExportsClientDiagnostics.CreateScope("CostManagementExportCollection.Get");
            scope.Start();
            try
            {
                var response = _costManagementExportExportsRestClient.Get(Id, exportName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CostManagementExportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to list all exports at the given scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the properties within an export. Currently only 'runHistory' is supported and will return information for the last run of each export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CostManagementExportResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CostManagementExportResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _costManagementExportExportsRestClient.CreateListRequest(Id, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CostManagementExportResource(Client, CostManagementExportData.DeserializeCostManagementExportData(e)), _costManagementExportExportsClientDiagnostics, Pipeline, "CostManagementExportCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// The operation to list all exports at the given scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the properties within an export. Currently only 'runHistory' is supported and will return information for the last run of each export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CostManagementExportResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CostManagementExportResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _costManagementExportExportsRestClient.CreateListRequest(Id, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CostManagementExportResource(Client, CostManagementExportData.DeserializeCostManagementExportData(e)), _costManagementExportExportsClientDiagnostics, Pipeline, "CostManagementExportCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exportName"> Export Name. </param>
        /// <param name="expand"> May be used to expand the properties within an export. Currently only 'runHistory' is supported and will return information for the last 10 runs of the export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exportName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string exportName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exportName, nameof(exportName));

            using var scope = _costManagementExportExportsClientDiagnostics.CreateScope("CostManagementExportCollection.Exists");
            scope.Start();
            try
            {
                var response = await _costManagementExportExportsRestClient.GetAsync(Id, exportName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exportName"> Export Name. </param>
        /// <param name="expand"> May be used to expand the properties within an export. Currently only 'runHistory' is supported and will return information for the last 10 runs of the export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exportName"/> is null. </exception>
        public virtual Response<bool> Exists(string exportName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exportName, nameof(exportName));

            using var scope = _costManagementExportExportsClientDiagnostics.CreateScope("CostManagementExportCollection.Exists");
            scope.Start();
            try
            {
                var response = _costManagementExportExportsRestClient.Get(Id, exportName, expand, cancellationToken: cancellationToken);
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
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exportName"> Export Name. </param>
        /// <param name="expand"> May be used to expand the properties within an export. Currently only 'runHistory' is supported and will return information for the last 10 runs of the export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exportName"/> is null. </exception>
        public virtual async Task<NullableResponse<CostManagementExportResource>> GetIfExistsAsync(string exportName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exportName, nameof(exportName));

            using var scope = _costManagementExportExportsClientDiagnostics.CreateScope("CostManagementExportCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _costManagementExportExportsRestClient.GetAsync(Id, exportName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CostManagementExportResource>(response.GetRawResponse());
                return Response.FromValue(new CostManagementExportResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{scope}/providers/Microsoft.CostManagement/exports/{exportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exportName"> Export Name. </param>
        /// <param name="expand"> May be used to expand the properties within an export. Currently only 'runHistory' is supported and will return information for the last 10 runs of the export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exportName"/> is null. </exception>
        public virtual NullableResponse<CostManagementExportResource> GetIfExists(string exportName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exportName, nameof(exportName));

            using var scope = _costManagementExportExportsClientDiagnostics.CreateScope("CostManagementExportCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _costManagementExportExportsRestClient.Get(Id, exportName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CostManagementExportResource>(response.GetRawResponse());
                return Response.FromValue(new CostManagementExportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CostManagementExportResource> IEnumerable<CostManagementExportResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CostManagementExportResource> IAsyncEnumerable<CostManagementExportResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
