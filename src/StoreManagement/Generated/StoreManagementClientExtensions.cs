// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Store;

namespace Microsoft.WindowsAzure.Management.Store
{
    /// <summary>
    /// The Windows Azure Store API is a REST API for managing Windows Azure
    /// Store add-ins.
    /// </summary>
    public static partial class StoreManagementClientExtensions
    {
        /// <summary>
        /// The Get Operation Status operation returns the status of
        /// thespecified operation. After calling an asynchronous operation,
        /// you can call Get Operation Status to determine whether the
        /// operation has succeeded, failed, or is still in progress.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460783.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Store.IStoreManagementClient.
        /// </param>
        /// <param name='requestId'>
        /// Required. The request ID for the request you wish to track. The
        /// request ID is returned in the x-ms-request-id response header for
        /// every request.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static OperationStatusResponse GetOperationStatus(this IStoreManagementClient operations, string requestId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IStoreManagementClient)s).GetOperationStatusAsync(requestId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of
        /// thespecified operation. After calling an asynchronous operation,
        /// you can call Get Operation Status to determine whether the
        /// operation has succeeded, failed, or is still in progress.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460783.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Store.IStoreManagementClient.
        /// </param>
        /// <param name='requestId'>
        /// Required. The request ID for the request you wish to track. The
        /// request ID is returned in the x-ms-request-id response header for
        /// every request.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static Task<OperationStatusResponse> GetOperationStatusAsync(this IStoreManagementClient operations, string requestId)
        {
            return operations.GetOperationStatusAsync(requestId, CancellationToken.None);
        }
    }
}
