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
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Hyak.Common;
using Microsoft.WindowsAzure.Management.RecoveryServices;
using Microsoft.WindowsAzure.Management.RecoveryServices.Models;

namespace Microsoft.WindowsAzure.Management.RecoveryServices
{
    /// <summary>
    /// Definition of cloud service operations for the Recovery services
    /// extension.
    /// </summary>
    internal partial class CloudServiceOperations : IServiceOperations<RecoveryServicesManagementClient>, ICloudServiceOperations
    {
        /// <summary>
        /// Initializes a new instance of the CloudServiceOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal CloudServiceOperations(RecoveryServicesManagementClient client)
        {
            this._client = client;
        }
        
        private RecoveryServicesManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.RecoveryServices.RecoveryServicesManagementClient.
        /// </summary>
        public RecoveryServicesManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Retrieve a list of Cloud services
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list cloud service operation.
        /// </returns>
        public async Task<CloudServiceListResponse> ListAsync(CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = (this.Client.Credentials.SubscriptionId == null ? "" : Uri.EscapeDataString(this.Client.Credentials.SubscriptionId)) + "/cloudservices?";
            url = url + "api-version=2014-10-27";
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/xml");
                httpRequest.Headers.Add("x-ms-version", "2013-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    CloudServiceListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new CloudServiceListResponse();
                        XDocument responseDoc = XDocument.Parse(responseContent);
                        
                        XElement cloudServicesSequenceElement = responseDoc.Element(XName.Get("CloudServices", "http://schemas.microsoft.com/windowsazure"));
                        if (cloudServicesSequenceElement != null)
                        {
                            foreach (XElement cloudServicesElement in cloudServicesSequenceElement.Elements(XName.Get("CloudService", "http://schemas.microsoft.com/windowsazure")))
                            {
                                CloudService cloudServiceInstance = new CloudService();
                                result.CloudServices.Add(cloudServiceInstance);
                                
                                XElement descriptionElement = cloudServicesElement.Element(XName.Get("Description", "http://schemas.microsoft.com/windowsazure"));
                                if (descriptionElement != null)
                                {
                                    string descriptionInstance = descriptionElement.Value;
                                    cloudServiceInstance.Description = descriptionInstance;
                                }
                                
                                XElement geoRegionElement = cloudServicesElement.Element(XName.Get("GeoRegion", "http://schemas.microsoft.com/windowsazure"));
                                if (geoRegionElement != null)
                                {
                                    string geoRegionInstance = geoRegionElement.Value;
                                    cloudServiceInstance.GeoRegion = geoRegionInstance;
                                }
                                
                                XElement labelElement = cloudServicesElement.Element(XName.Get("Label", "http://schemas.microsoft.com/windowsazure"));
                                if (labelElement != null)
                                {
                                    string labelInstance = labelElement.Value;
                                    cloudServiceInstance.Label = labelInstance;
                                }
                                
                                XElement nameElement = cloudServicesElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                                if (nameElement != null)
                                {
                                    string nameInstance = nameElement.Value;
                                    cloudServiceInstance.Name = nameInstance;
                                }
                                
                                XElement resourcesSequenceElement = cloudServicesElement.Element(XName.Get("Resources", "http://schemas.microsoft.com/windowsazure"));
                                if (resourcesSequenceElement != null)
                                {
                                    foreach (XElement resourcesElement in resourcesSequenceElement.Elements(XName.Get("Resource", "http://schemas.microsoft.com/windowsazure")))
                                    {
                                        Vault resourceInstance = new Vault();
                                        cloudServiceInstance.Resources.Add(resourceInstance);
                                        
                                        XElement resourceProviderNamespaceElement = resourcesElement.Element(XName.Get("ResourceProviderNamespace", "http://schemas.microsoft.com/windowsazure"));
                                        if (resourceProviderNamespaceElement != null)
                                        {
                                            string resourceProviderNamespaceInstance = resourceProviderNamespaceElement.Value;
                                            resourceInstance.ResourceProviderNamespace = resourceProviderNamespaceInstance;
                                        }
                                        
                                        XElement eTagElement = resourcesElement.Element(XName.Get("ETag", "http://schemas.microsoft.com/windowsazure"));
                                        if (eTagElement != null)
                                        {
                                            string eTagInstance = eTagElement.Value;
                                            resourceInstance.ETag = eTagInstance;
                                        }
                                        
                                        XElement labelElement2 = resourcesElement.Element(XName.Get("Label", "http://schemas.microsoft.com/windowsazure"));
                                        if (labelElement2 != null)
                                        {
                                            string labelInstance2 = labelElement2.Value;
                                            resourceInstance.Label = labelInstance2;
                                        }
                                        
                                        XElement nameElement2 = resourcesElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                                        if (nameElement2 != null)
                                        {
                                            string nameInstance2 = nameElement2.Value;
                                            resourceInstance.Name = nameInstance2;
                                        }
                                        
                                        XElement operationStatusElement = resourcesElement.Element(XName.Get("OperationStatus", "http://schemas.microsoft.com/windowsazure"));
                                        if (operationStatusElement != null)
                                        {
                                            ResourceOperationStatus operationStatusInstance = new ResourceOperationStatus();
                                            resourceInstance.OperationStatus = operationStatusInstance;
                                            
                                            XElement resultElement = operationStatusElement.Element(XName.Get("Result", "http://schemas.microsoft.com/windowsazure"));
                                            if (resultElement != null)
                                            {
                                                string resultInstance = resultElement.Value;
                                                operationStatusInstance.Result = resultInstance;
                                            }
                                            
                                            XElement typeElement = operationStatusElement.Element(XName.Get("Type", "http://schemas.microsoft.com/windowsazure"));
                                            if (typeElement != null)
                                            {
                                                string typeInstance = typeElement.Value;
                                                operationStatusInstance.Type = typeInstance;
                                            }
                                        }
                                        
                                        XElement outputItemsSequenceElement = resourcesElement.Element(XName.Get("OutputItems", "http://schemas.microsoft.com/windowsazure"));
                                        if (outputItemsSequenceElement != null)
                                        {
                                            foreach (XElement outputItemsElement in outputItemsSequenceElement.Elements(XName.Get("OutputItem", "http://schemas.microsoft.com/windowsazure")))
                                            {
                                                OutputItem outputItemInstance = new OutputItem();
                                                resourceInstance.OutputItems.Add(outputItemInstance);
                                                
                                                XElement keyElement = outputItemsElement.Element(XName.Get("Key", "http://schemas.microsoft.com/windowsazure"));
                                                if (keyElement != null)
                                                {
                                                    string keyInstance = keyElement.Value;
                                                    outputItemInstance.Key = keyInstance;
                                                }
                                                
                                                XElement valueElement = outputItemsElement.Element(XName.Get("Value", "http://schemas.microsoft.com/windowsazure"));
                                                if (valueElement != null)
                                                {
                                                    string valueInstance = valueElement.Value;
                                                    outputItemInstance.Value = valueInstance;
                                                }
                                            }
                                        }
                                        
                                        XElement planElement = resourcesElement.Element(XName.Get("Plan", "http://schemas.microsoft.com/windowsazure"));
                                        if (planElement != null)
                                        {
                                            string planInstance = planElement.Value;
                                            resourceInstance.Plan = planInstance;
                                        }
                                        
                                        XElement schemaVersionElement = resourcesElement.Element(XName.Get("SchemaVersion", "http://schemas.microsoft.com/windowsazure"));
                                        if (schemaVersionElement != null)
                                        {
                                            string schemaVersionInstance = schemaVersionElement.Value;
                                            resourceInstance.SchemaVersion = schemaVersionInstance;
                                        }
                                        
                                        XElement stateElement = resourcesElement.Element(XName.Get("State", "http://schemas.microsoft.com/windowsazure"));
                                        if (stateElement != null)
                                        {
                                            string stateInstance = stateElement.Value;
                                            resourceInstance.State = stateInstance;
                                        }
                                        
                                        XElement subStateElement = resourcesElement.Element(XName.Get("SubState", "http://schemas.microsoft.com/windowsazure"));
                                        if (subStateElement != null)
                                        {
                                            string subStateInstance = subStateElement.Value;
                                            resourceInstance.SubState = subStateInstance;
                                        }
                                        
                                        XElement typeElement2 = resourcesElement.Element(XName.Get("Type", "http://schemas.microsoft.com/windowsazure"));
                                        if (typeElement2 != null)
                                        {
                                            string typeInstance2 = typeElement2.Value;
                                            resourceInstance.Type = typeInstance2;
                                        }
                                    }
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
