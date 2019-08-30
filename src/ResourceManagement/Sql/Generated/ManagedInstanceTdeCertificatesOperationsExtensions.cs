// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ManagedInstanceTdeCertificatesOperations.
    /// </summary>
    public static partial class ManagedInstanceTdeCertificatesOperationsExtensions
    {
            /// <summary>
            /// Creates a TDE certificate for a given server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='parameters'>
            /// The requested TDE certificate to be created or updated.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateAsync(this IManagedInstanceTdeCertificatesOperations operations, string resourceGroupName, string managedInstanceName, TdeCertificateInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CreateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a TDE certificate for a given server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='parameters'>
            /// The requested TDE certificate to be created or updated.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginCreateAsync(this IManagedInstanceTdeCertificatesOperations operations, string resourceGroupName, string managedInstanceName, TdeCertificateInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}