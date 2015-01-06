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
using Microsoft.WindowsAzure.Management.TrafficManager.Models;

namespace Microsoft.WindowsAzure.Management.TrafficManager
{
    /// <summary>
    /// The Traffic Manager API includes operations for managing Traffic
    /// Manager profiles.
    /// </summary>
    public partial interface IProfileOperations
    {
        /// <summary>
        /// The DNS name that you want to use. You must include
        /// .trafficmanager.net in the name.  (see
        /// http://msdn.microsoft.com/en-us/library/dn510368.aspx for more
        /// information)
        /// </summary>
        /// <param name='dnsName'>
        /// DNS name that you want to use
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response to the request for a listing of namespaces.
        /// </returns>
        Task<DnsPrefixAvailabilityCheckResponse> CheckDnsPrefixAvailabilityAsync(string dnsName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a new profile for a domain name, owned by the specified
        /// subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/hh758254.aspx for more
        /// information)
        /// </summary>
        /// <param name='name'>
        /// The name of the profile.
        /// </param>
        /// <param name='domainName'>
        /// The name of the domain that the profile is being created for.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> CreateAsync(string name, string domainName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a profile and all of its definitions. This operation cannot
        /// be reverted.  (see
        /// http://msdn.microsoft.com/en-us/library/hh758256.aspx for more
        /// information)
        /// </summary>
        /// <param name='profileName'>
        /// The name of the profile.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string profileName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns profile details, including all definition versions and
        /// their statuses.  (see
        /// http://msdn.microsoft.com/en-us/library/hh758248.aspx for more
        /// information)
        /// </summary>
        /// <param name='profileName'>
        /// The name of the profile.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Profile Details operation response.
        /// </returns>
        Task<ProfileGetResponse> GetAsync(string profileName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns all profiles owned by a subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/hh758249.aspx for more
        /// information)
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Profiles operation response.
        /// </returns>
        Task<ProfilesListResponse> ListAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Enables or disables a profile.  (see
        /// http://msdn.microsoft.com/en-us/library/hh758250.aspx for more
        /// information)
        /// </summary>
        /// <param name='profileName'>
        /// The name of the profile.
        /// </param>
        /// <param name='profileStatus'>
        /// Specifies whether the profile should be enabled or disabled.
        /// </param>
        /// <param name='definitionVersionNumber'>
        /// Version of the definition associated with the profile
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> UpdateAsync(string profileName, ProfileDefinitionStatus profileStatus, int definitionVersionNumber, CancellationToken cancellationToken);
    }
}
