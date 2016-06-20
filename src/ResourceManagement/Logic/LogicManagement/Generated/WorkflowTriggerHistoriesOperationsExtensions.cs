// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for WorkflowTriggerHistoriesOperations.
    /// </summary>
    public static partial class WorkflowTriggerHistoriesOperationsExtensions
    {
            /// <summary>
            /// Gets a list of workflow trigger histories.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            public static IPage<WorkflowTriggerHistory> List(this IWorkflowTriggerHistoriesOperations operations, string resourceGroupName, string workflowName, string triggerName, int? top = default(int?))
            {
                return Task.Factory.StartNew(s => ((IWorkflowTriggerHistoriesOperations)s).ListAsync(resourceGroupName, workflowName, triggerName, top), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of workflow trigger histories.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WorkflowTriggerHistory>> ListAsync(this IWorkflowTriggerHistoriesOperations operations, string resourceGroupName, string workflowName, string triggerName, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workflowName, triggerName, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a workflow trigger history.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            /// <param name='historyName'>
            /// The workflow trigger history name.
            /// </param>
            public static WorkflowTriggerHistory Get(this IWorkflowTriggerHistoriesOperations operations, string resourceGroupName, string workflowName, string triggerName, string historyName)
            {
                return Task.Factory.StartNew(s => ((IWorkflowTriggerHistoriesOperations)s).GetAsync(resourceGroupName, workflowName, triggerName, historyName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a workflow trigger history.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            /// <param name='historyName'>
            /// The workflow trigger history name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkflowTriggerHistory> GetAsync(this IWorkflowTriggerHistoriesOperations operations, string resourceGroupName, string workflowName, string triggerName, string historyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workflowName, triggerName, historyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of workflow trigger histories.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<WorkflowTriggerHistory> ListNext(this IWorkflowTriggerHistoriesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IWorkflowTriggerHistoriesOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of workflow trigger histories.
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
            public static async Task<IPage<WorkflowTriggerHistory>> ListNextAsync(this IWorkflowTriggerHistoriesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}