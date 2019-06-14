// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotCentral
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AppsOperations.
    /// </summary>
    public static partial class AppsOperationsExtensions
    {
            /// <summary>
            /// Get the metadata of an IoT Central application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT Central application.
            /// </param>
            /// <param name='resourceName'>
            /// The ARM resource name of the IoT Central application.
            /// </param>
            public static App Get(this IAppsOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.GetAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the metadata of an IoT Central application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT Central application.
            /// </param>
            /// <param name='resourceName'>
            /// The ARM resource name of the IoT Central application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<App> GetAsync(this IAppsOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the metadata of an IoT Central application. The usual
            /// pattern to modify a property is to retrieve the IoT Central application
            /// metadata and security metadata, and then combine them with the modified
            /// values in a new body to update the IoT Central application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT Central application.
            /// </param>
            /// <param name='resourceName'>
            /// The ARM resource name of the IoT Central application.
            /// </param>
            /// <param name='app'>
            /// The IoT Central application metadata and security metadata.
            /// </param>
            public static App CreateOrUpdate(this IAppsOperations operations, string resourceGroupName, string resourceName, App app)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, resourceName, app).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the metadata of an IoT Central application. The usual
            /// pattern to modify a property is to retrieve the IoT Central application
            /// metadata and security metadata, and then combine them with the modified
            /// values in a new body to update the IoT Central application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT Central application.
            /// </param>
            /// <param name='resourceName'>
            /// The ARM resource name of the IoT Central application.
            /// </param>
            /// <param name='app'>
            /// The IoT Central application metadata and security metadata.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<App> CreateOrUpdateAsync(this IAppsOperations operations, string resourceGroupName, string resourceName, App app, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, app, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the metadata of an IoT Central application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT Central application.
            /// </param>
            /// <param name='resourceName'>
            /// The ARM resource name of the IoT Central application.
            /// </param>
            /// <param name='appPatch'>
            /// The IoT Central application metadata and security metadata.
            /// </param>
            public static App Update(this IAppsOperations operations, string resourceGroupName, string resourceName, AppPatch appPatch)
            {
                return operations.UpdateAsync(resourceGroupName, resourceName, appPatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the metadata of an IoT Central application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT Central application.
            /// </param>
            /// <param name='resourceName'>
            /// The ARM resource name of the IoT Central application.
            /// </param>
            /// <param name='appPatch'>
            /// The IoT Central application metadata and security metadata.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<App> UpdateAsync(this IAppsOperations operations, string resourceGroupName, string resourceName, AppPatch appPatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, resourceName, appPatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an IoT Central application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT Central application.
            /// </param>
            /// <param name='resourceName'>
            /// The ARM resource name of the IoT Central application.
            /// </param>
            public static void Delete(this IAppsOperations operations, string resourceGroupName, string resourceName)
            {
                operations.DeleteAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an IoT Central application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT Central application.
            /// </param>
            /// <param name='resourceName'>
            /// The ARM resource name of the IoT Central application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAppsOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get all IoT Central Applications in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<App> ListBySubscription(this IAppsOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all IoT Central Applications in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<App>> ListBySubscriptionAsync(this IAppsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all the IoT Central Applications in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT Central application.
            /// </param>
            public static IPage<App> ListByResourceGroup(this IAppsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the IoT Central Applications in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT Central application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<App>> ListByResourceGroupAsync(this IAppsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Check if an IoT Central application name is available.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='operationInputs'>
            /// Set the name parameter in the OperationInputs structure to the name of the
            /// IoT Central application to check.
            /// </param>
            public static AppAvailabilityInfo CheckNameAvailability(this IAppsOperations operations, OperationInputs operationInputs)
            {
                return operations.CheckNameAvailabilityAsync(operationInputs).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check if an IoT Central application name is available.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='operationInputs'>
            /// Set the name parameter in the OperationInputs structure to the name of the
            /// IoT Central application to check.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AppAvailabilityInfo> CheckNameAvailabilityAsync(this IAppsOperations operations, OperationInputs operationInputs, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(operationInputs, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Check if an IoT Central application subdomain is available.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='operationInputs'>
            /// Set the name parameter in the OperationInputs structure to the subdomain of
            /// the IoT Central application to check.
            /// </param>
            public static AppAvailabilityInfo CheckSubdomainAvailability(this IAppsOperations operations, OperationInputs operationInputs)
            {
                return operations.CheckSubdomainAvailabilityAsync(operationInputs).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check if an IoT Central application subdomain is available.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='operationInputs'>
            /// Set the name parameter in the OperationInputs structure to the subdomain of
            /// the IoT Central application to check.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AppAvailabilityInfo> CheckSubdomainAvailabilityAsync(this IAppsOperations operations, OperationInputs operationInputs, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckSubdomainAvailabilityWithHttpMessagesAsync(operationInputs, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all available application templates.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<AppTemplate> ListTemplates(this IAppsOperations operations)
            {
                return operations.ListTemplatesAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all available application templates.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AppTemplate>> ListTemplatesAsync(this IAppsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListTemplatesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the metadata of an IoT Central application. The usual
            /// pattern to modify a property is to retrieve the IoT Central application
            /// metadata and security metadata, and then combine them with the modified
            /// values in a new body to update the IoT Central application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT Central application.
            /// </param>
            /// <param name='resourceName'>
            /// The ARM resource name of the IoT Central application.
            /// </param>
            /// <param name='app'>
            /// The IoT Central application metadata and security metadata.
            /// </param>
            public static App BeginCreateOrUpdate(this IAppsOperations operations, string resourceGroupName, string resourceName, App app)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, resourceName, app).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the metadata of an IoT Central application. The usual
            /// pattern to modify a property is to retrieve the IoT Central application
            /// metadata and security metadata, and then combine them with the modified
            /// values in a new body to update the IoT Central application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT Central application.
            /// </param>
            /// <param name='resourceName'>
            /// The ARM resource name of the IoT Central application.
            /// </param>
            /// <param name='app'>
            /// The IoT Central application metadata and security metadata.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<App> BeginCreateOrUpdateAsync(this IAppsOperations operations, string resourceGroupName, string resourceName, App app, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, app, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the metadata of an IoT Central application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT Central application.
            /// </param>
            /// <param name='resourceName'>
            /// The ARM resource name of the IoT Central application.
            /// </param>
            /// <param name='appPatch'>
            /// The IoT Central application metadata and security metadata.
            /// </param>
            public static App BeginUpdate(this IAppsOperations operations, string resourceGroupName, string resourceName, AppPatch appPatch)
            {
                return operations.BeginUpdateAsync(resourceGroupName, resourceName, appPatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the metadata of an IoT Central application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT Central application.
            /// </param>
            /// <param name='resourceName'>
            /// The ARM resource name of the IoT Central application.
            /// </param>
            /// <param name='appPatch'>
            /// The IoT Central application metadata and security metadata.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<App> BeginUpdateAsync(this IAppsOperations operations, string resourceGroupName, string resourceName, AppPatch appPatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, appPatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an IoT Central application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT Central application.
            /// </param>
            /// <param name='resourceName'>
            /// The ARM resource name of the IoT Central application.
            /// </param>
            public static void BeginDelete(this IAppsOperations operations, string resourceGroupName, string resourceName)
            {
                operations.BeginDeleteAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an IoT Central application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT Central application.
            /// </param>
            /// <param name='resourceName'>
            /// The ARM resource name of the IoT Central application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IAppsOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get all IoT Central Applications in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<App> ListBySubscriptionNext(this IAppsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all IoT Central Applications in a subscription.
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
            public static async Task<IPage<App>> ListBySubscriptionNextAsync(this IAppsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all the IoT Central Applications in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<App> ListByResourceGroupNext(this IAppsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the IoT Central Applications in a resource group.
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
            public static async Task<IPage<App>> ListByResourceGroupNextAsync(this IAppsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all available application templates.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AppTemplate> ListTemplatesNext(this IAppsOperations operations, string nextPageLink)
            {
                return operations.ListTemplatesNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all available application templates.
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
            public static async Task<IPage<AppTemplate>> ListTemplatesNextAsync(this IAppsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListTemplatesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}