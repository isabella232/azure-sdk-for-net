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
using System.Xml;
using Hyak.Common;
using Microsoft.Azure.Insights;
using Microsoft.Azure.Insights.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Insights
{
    /// <summary>
    /// Operations for metric values.
    /// </summary>
    internal partial class MetricOperations : IServiceOperations<InsightsClient>, IMetricOperations
    {
        /// <summary>
        /// Initializes a new instance of the MetricOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal MetricOperations(InsightsClient client)
        {
            this._client = client;
        }

        private InsightsClient _client;

        /// <summary>
        /// Gets a reference to the Microsoft.Azure.Insights.InsightsClient.
        /// </summary>
        public InsightsClient Client
        {
            get { return this._client; }
        }

        /// <summary>
        /// The List Metric operation lists the metric value sets for the
        /// resource metrics.
        /// </summary>
        /// <param name='resourceUri'>
        /// Required. The resource identifier of the target resource to get
        /// metrics for.
        /// </param>
        /// <param name='filterString'>
        /// Optional. An OData $filter expression that supports querying by the
        /// name, startTime, endTime and timeGrain of the metric value sets.
        /// For example, "(name.value eq 'Percentage CPU') and startTime eq
        /// 2014-07-02T01:00Z and endTime eq 2014-08-21T01:00:00Z and
        /// timeGrain eq duration'PT1H'". In the expression, startTime,
        /// endTime and timeGrain are required. Name is optional.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Metric values operation response.
        /// </returns>
        public async Task<MetricListResponse> GetMetricsInternalAsync(string resourceUri, string filterString, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceUri == null)
            {
                throw new ArgumentNullException("resourceUri");
            }

            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceUri", resourceUri);
                tracingParameters.Add("filterString", filterString);
                TracingAdapter.Enter(invocationId, this, "GetMetricsAsync", tracingParameters);
            }

            // Construct URL
            string url = "/" + Uri.EscapeDataString(resourceUri) + "/metrics?";
            url = url + "api-version=2014-04-01";
            if (filterString != null)
            {
                url = url + "&$filter=" + Uri.EscapeDataString(filterString);
            }
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
                httpRequest.Headers.Add("Accept", "application/json");
                httpRequest.Headers.Add("x-ms-version", "2014-04-01");

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
                    MetricListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new MetricListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }

                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            MetricCollection metricCollectionInstance = new MetricCollection();
                            result.MetricCollection = metricCollectionInstance;

                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    Metric metricInstance = new Metric();
                                    metricCollectionInstance.Value.Add(metricInstance);

                                    JToken nameValue = valueValue["name"];
                                    if (nameValue != null && nameValue.Type != JTokenType.Null)
                                    {
                                        LocalizableString nameInstance = new LocalizableString();
                                        metricInstance.Name = nameInstance;

                                        JToken valueValue2 = nameValue["value"];
                                        if (valueValue2 != null && valueValue2.Type != JTokenType.Null)
                                        {
                                            string valueInstance = ((string)valueValue2);
                                            nameInstance.Value = valueInstance;
                                        }

                                        JToken localizedValueValue = nameValue["localizedValue"];
                                        if (localizedValueValue != null && localizedValueValue.Type != JTokenType.Null)
                                        {
                                            string localizedValueInstance = ((string)localizedValueValue);
                                            nameInstance.LocalizedValue = localizedValueInstance;
                                        }
                                    }

                                    JToken unitValue = valueValue["unit"];
                                    if (unitValue != null && unitValue.Type != JTokenType.Null)
                                    {
                                        Unit unitInstance = ((Unit)Enum.Parse(typeof(Unit), ((string)unitValue), true));
                                        metricInstance.Unit = unitInstance;
                                    }

                                    JToken timeGrainValue = valueValue["timeGrain"];
                                    if (timeGrainValue != null && timeGrainValue.Type != JTokenType.Null)
                                    {
                                        TimeSpan timeGrainInstance = XmlConvert.ToTimeSpan(((string)timeGrainValue));
                                        metricInstance.TimeGrain = timeGrainInstance;
                                    }

                                    JToken startTimeValue = valueValue["startTime"];
                                    if (startTimeValue != null && startTimeValue.Type != JTokenType.Null)
                                    {
                                        DateTime startTimeInstance = ((DateTime)startTimeValue);
                                        metricInstance.StartTime = startTimeInstance;
                                    }

                                    JToken endTimeValue = valueValue["endTime"];
                                    if (endTimeValue != null && endTimeValue.Type != JTokenType.Null)
                                    {
                                        DateTime endTimeInstance = ((DateTime)endTimeValue);
                                        metricInstance.EndTime = endTimeInstance;
                                    }

                                    JToken metricValuesArray = valueValue["metricValues"];
                                    if (metricValuesArray != null && metricValuesArray.Type != JTokenType.Null)
                                    {
                                        foreach (JToken metricValuesValue in ((JArray)metricValuesArray))
                                        {
                                            MetricValue metricValueInstance = new MetricValue();
                                            metricInstance.MetricValues.Add(metricValueInstance);

                                            JToken timestampValue = metricValuesValue["timestamp"];
                                            if (timestampValue != null && timestampValue.Type != JTokenType.Null)
                                            {
                                                DateTime timestampInstance = ((DateTime)timestampValue);
                                                metricValueInstance.Timestamp = timestampInstance;
                                            }

                                            JToken averageValue = metricValuesValue["average"];
                                            if (averageValue != null && averageValue.Type != JTokenType.Null)
                                            {
                                                double averageInstance = ((double)averageValue);
                                                metricValueInstance.Average = averageInstance;
                                            }

                                            JToken minimumValue = metricValuesValue["minimum"];
                                            if (minimumValue != null && minimumValue.Type != JTokenType.Null)
                                            {
                                                double minimumInstance = ((double)minimumValue);
                                                metricValueInstance.Minimum = minimumInstance;
                                            }

                                            JToken maximumValue = metricValuesValue["maximum"];
                                            if (maximumValue != null && maximumValue.Type != JTokenType.Null)
                                            {
                                                double maximumInstance = ((double)maximumValue);
                                                metricValueInstance.Maximum = maximumInstance;
                                            }

                                            JToken totalValue = metricValuesValue["total"];
                                            if (totalValue != null && totalValue.Type != JTokenType.Null)
                                            {
                                                double totalInstance = ((double)totalValue);
                                                metricValueInstance.Total = totalInstance;
                                            }

                                            JToken countValue = metricValuesValue["count"];
                                            if (countValue != null && countValue.Type != JTokenType.Null)
                                            {
                                                long countInstance = ((long)countValue);
                                                metricValueInstance.Count = countInstance;
                                            }

                                            JToken lastValue = metricValuesValue["last"];
                                            if (lastValue != null && lastValue.Type != JTokenType.Null)
                                            {
                                                double lastInstance = ((double)lastValue);
                                                metricValueInstance.Last = lastInstance;
                                            }

                                            JToken propertiesSequenceElement = ((JToken)metricValuesValue["properties"]);
                                            if (propertiesSequenceElement != null && propertiesSequenceElement.Type != JTokenType.Null)
                                            {
                                                foreach (JProperty property in propertiesSequenceElement)
                                                {
                                                    string propertiesKey = ((string)property.Name);
                                                    string propertiesValue = ((string)property.Value);
                                                    metricValueInstance.Properties.Add(propertiesKey, propertiesValue);
                                                }
                                            }
                                        }
                                    }

                                    JToken resourceIdValue = valueValue["resourceId"];
                                    if (resourceIdValue != null && resourceIdValue.Type != JTokenType.Null)
                                    {
                                        string resourceIdInstance = ((string)resourceIdValue);
                                        metricInstance.ResourceId = resourceIdInstance;
                                    }

                                    JToken propertiesSequenceElement2 = ((JToken)valueValue["properties"]);
                                    if (propertiesSequenceElement2 != null && propertiesSequenceElement2.Type != JTokenType.Null)
                                    {
                                        foreach (JProperty property2 in propertiesSequenceElement2)
                                        {
                                            string propertiesKey2 = ((string)property2.Name);
                                            string propertiesValue2 = ((string)property2.Value);
                                            metricInstance.Properties.Add(propertiesKey2, propertiesValue2);
                                        }
                                    }

                                    JToken dimensionNameValue = valueValue["dimensionName"];
                                    if (dimensionNameValue != null && dimensionNameValue.Type != JTokenType.Null)
                                    {
                                        LocalizableString dimensionNameInstance = new LocalizableString();
                                        metricInstance.DimensionName = dimensionNameInstance;

                                        JToken valueValue3 = dimensionNameValue["value"];
                                        if (valueValue3 != null && valueValue3.Type != JTokenType.Null)
                                        {
                                            string valueInstance2 = ((string)valueValue3);
                                            dimensionNameInstance.Value = valueInstance2;
                                        }

                                        JToken localizedValueValue2 = dimensionNameValue["localizedValue"];
                                        if (localizedValueValue2 != null && localizedValueValue2.Type != JTokenType.Null)
                                        {
                                            string localizedValueInstance2 = ((string)localizedValueValue2);
                                            dimensionNameInstance.LocalizedValue = localizedValueInstance2;
                                        }
                                    }

                                    JToken dimensionValueValue = valueValue["dimensionValue"];
                                    if (dimensionValueValue != null && dimensionValueValue.Type != JTokenType.Null)
                                    {
                                        LocalizableString dimensionValueInstance = new LocalizableString();
                                        metricInstance.DimensionValue = dimensionValueInstance;

                                        JToken valueValue4 = dimensionValueValue["value"];
                                        if (valueValue4 != null && valueValue4.Type != JTokenType.Null)
                                        {
                                            string valueInstance3 = ((string)valueValue4);
                                            dimensionValueInstance.Value = valueInstance3;
                                        }

                                        JToken localizedValueValue3 = dimensionValueValue["localizedValue"];
                                        if (localizedValueValue3 != null && localizedValueValue3.Type != JTokenType.Null)
                                        {
                                            string localizedValueInstance3 = ((string)localizedValueValue3);
                                            dimensionValueInstance.LocalizedValue = localizedValueInstance3;
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
