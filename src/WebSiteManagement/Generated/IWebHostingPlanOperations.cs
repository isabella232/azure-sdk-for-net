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
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure.Management.WebSites
{
    /// <summary>
    /// Operations for managing web hosting plans beneath your subscription.
    /// </summary>
    public partial interface IWebHostingPlanOperations
    {
        /// <summary>
        /// Creates a new Web Hosting Plan.  (see
        /// http://azure.microsoft.com/en-us/documentation/articles/azure-web-sites-web-hosting-plans-in-depth-overview/
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='parameters'>
        /// Web Hosting Plan Parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Create Web Web Hosting Plan operation response.
        /// </returns>
        Task<WebHostingPlanCreateResponse> CreateAsync(string webSpaceName, WebHostingPlanCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a Web Hosting Plan  (see
        /// http://azure.microsoft.com/en-us/documentation/articles/azure-web-sites-web-hosting-plans-in-depth-overview/
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webHostingPlanName'>
        /// The name of the web hosting plan.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string webSpaceName, string webHostingPlanName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets details of an existing Web Hosting Plan  (see
        /// http://azure.microsoft.com/en-us/documentation/articles/azure-web-sites-web-hosting-plans-in-depth-overview/
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webHostingPlanName'>
        /// The name of the web hosting plan.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Web Hosting Plan operation response.
        /// </returns>
        Task<WebHostingPlanGetResponse> GetAsync(string webSpaceName, string webHostingPlanName, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can retrieve historical usage metrics for a site by issuing an
        /// HTTP GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166964.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webHostingPlanName'>
        /// The name of the web hosting plan.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Get Historical Usage Metrics Web hosting
        /// plan operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Historical Usage Metrics Web hosting plan operation
        /// response.
        /// </returns>
        Task<WebHostingPlanGetHistoricalUsageMetricsResponse> GetHistoricalUsageMetricsAsync(string webSpaceName, string webHostingPlanName, WebHostingPlanGetHistoricalUsageMetricsParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can list the web spaces under the current subscription by
        /// issuing a GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166961.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Web Hosting Plans operation response.
        /// </returns>
        Task<WebHostingPlanListResponse> ListAsync(string webSpaceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates an existing Web Hosting Plan.  (see
        /// http://azure.microsoft.com/en-us/documentation/articles/azure-web-sites-web-hosting-plans-in-depth-overview/
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webHostingPlanName'>
        /// The name of the web hosting plan.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Web Hosting Plan operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Create Web Hosting Plan operation response.
        /// </returns>
        Task<WebHostingPlanUpdateResponse> UpdateAsync(string webSpaceName, string webHostingPlanName, WebHostingPlanUpdateParameters parameters, CancellationToken cancellationToken);
    }
}
