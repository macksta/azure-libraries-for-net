// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CustomerInsights.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LinksOperations.
    /// </summary>
    public static partial class LinksOperationsExtensions
    {
            /// <summary>
            /// Creates a link or updates an existing link in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='linkName'>
            /// The name of the link.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Link operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LinkResourceFormatInner> CreateOrUpdateAsync(this ILinksOperations operations, string resourceGroupName, string hubName, string linkName, LinkResourceFormatInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, hubName, linkName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a link in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='linkName'>
            /// The name of the link.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LinkResourceFormatInner> GetAsync(this ILinksOperations operations, string resourceGroupName, string hubName, string linkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, hubName, linkName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a link in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='linkName'>
            /// The name of the link.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ILinksOperations operations, string resourceGroupName, string hubName, string linkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, hubName, linkName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all the links in the specified hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LinkResourceFormatInner>> ListByHubAsync(this ILinksOperations operations, string resourceGroupName, string hubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHubWithHttpMessagesAsync(resourceGroupName, hubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a link or updates an existing link in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='linkName'>
            /// The name of the link.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Link operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LinkResourceFormatInner> BeginCreateOrUpdateAsync(this ILinksOperations operations, string resourceGroupName, string hubName, string linkName, LinkResourceFormatInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, hubName, linkName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the links in the specified hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LinkResourceFormatInner>> ListByHubNextAsync(this ILinksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHubNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
