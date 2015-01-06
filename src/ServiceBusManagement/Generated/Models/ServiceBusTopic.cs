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
using Hyak.Common;
using Microsoft.WindowsAzure.Management.ServiceBus.Models;

namespace Microsoft.WindowsAzure.Management.ServiceBus.Models
{
    public partial class ServiceBusTopic
    {
        private DateTime _accessedAt;
        
        /// <summary>
        /// Optional. The time the queue was last accessed.
        /// </summary>
        public DateTime AccessedAt
        {
            get { return this._accessedAt; }
            set { this._accessedAt = value; }
        }
        
        private IList<ServiceBusSharedAccessAuthorizationRule> _authorizationRules;
        
        /// <summary>
        /// Optional. Gets the authorization rules for the description.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780749.aspx
        /// for more information)
        /// </summary>
        public IList<ServiceBusSharedAccessAuthorizationRule> AuthorizationRules
        {
            get { return this._authorizationRules; }
            set { this._authorizationRules = value; }
        }
        
        private string _autoDeleteOnIdle;
        
        /// <summary>
        /// Optional. Implemented.
        /// </summary>
        public string AutoDeleteOnIdle
        {
            get { return this._autoDeleteOnIdle; }
            set { this._autoDeleteOnIdle = value; }
        }
        
        private CountDetails _countDetails;
        
        /// <summary>
        /// Optional. Current queue statistics.
        /// </summary>
        public CountDetails CountDetails
        {
            get { return this._countDetails; }
            set { this._countDetails = value; }
        }
        
        private DateTime _createdAt;
        
        /// <summary>
        /// Optional. The time the queue was created at.
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }
        
        private string _defaultMessageTimeToLive;
        
        /// <summary>
        /// Optional. Determines how long a message lives in the associated
        /// subscriptions. Subscriptions inherit the TTL from the topic unless
        /// they are created explicitly with a smaller TTL. Based on whether
        /// dead-lettering is enabled, a message whose TTL has expired will
        /// either be moved to the subscription's associated DeadLtterQueue or
        /// will be permanently deleted. The following values are settable at
        /// topic creation time:* Range: 1 second - TimeSpan.MaxValue*
        /// Default: TimeSpan.MaxValue  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj839740.aspx
        /// for more information)
        /// </summary>
        public string DefaultMessageTimeToLive
        {
            get { return this._defaultMessageTimeToLive; }
            set { this._defaultMessageTimeToLive = value; }
        }
        
        private string _duplicateDetectionHistoryTimeWindow;
        
        /// <summary>
        /// Optional. Specifies the time span during which the Service Bus will
        /// detect message duplication.* Range: 1 second - 7 days* Default: 10
        /// minutes  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780749.aspx
        /// for more information)
        /// </summary>
        public string DuplicateDetectionHistoryTimeWindow
        {
            get { return this._duplicateDetectionHistoryTimeWindow; }
            set { this._duplicateDetectionHistoryTimeWindow = value; }
        }
        
        private bool _enableBatchedOperations;
        
        /// <summary>
        /// Optional. Enables or disables service side batching behavior when
        /// performing operations for the specific queue. When enabled,
        /// service bus will collect/batch multiple operations to the backend
        /// to be more connection efficient. If user wants lower operation
        /// latency then they can disable this feature.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780749.aspx
        /// for more information)
        /// </summary>
        public bool EnableBatchedOperations
        {
            get { return this._enableBatchedOperations; }
            set { this._enableBatchedOperations = value; }
        }
        
        private string _entityAvailabilityStatus;
        
        /// <summary>
        /// Optional. The current availability status of the topic.
        /// </summary>
        public string EntityAvailabilityStatus
        {
            get { return this._entityAvailabilityStatus; }
            set { this._entityAvailabilityStatus = value; }
        }
        
        private bool _filteringMessagesBeforePublishing;
        
        /// <summary>
        /// Optional. Gets or sets whether messages should be filtered before
        /// publishing.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780749.aspx
        /// for more information)
        /// </summary>
        public bool FilteringMessagesBeforePublishing
        {
            get { return this._filteringMessagesBeforePublishing; }
            set { this._filteringMessagesBeforePublishing = value; }
        }
        
        private bool _isAnonymousAccessible;
        
        /// <summary>
        /// Optional. Gets whether anonymous access is allowed.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780749.aspx
        /// for more information)
        /// </summary>
        public bool IsAnonymousAccessible
        {
            get { return this._isAnonymousAccessible; }
            set { this._isAnonymousAccessible = value; }
        }
        
        private int _maxSizeInMegabytes;
        
        /// <summary>
        /// Optional. Specifies the maximum topic size in megabytes. Any
        /// attempt to enqueue a message that will cause the topic to exceed
        /// this value will fail. All messages that are stored in the topic or
        /// any of its subscriptions count towards this value. Multiple copies
        /// of a message that reside in one or multiple subscriptions count as
        /// a single messages. For example, if message m exists once in
        /// subscription s1 and twice in subscription s2, m is counted as a
        /// single message. You can only set this parameter at topic creation
        /// time using the following values:* Range: 1 - 5*1024 MB* Default:
        /// 1*1024  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780749.aspx
        /// for more information)
        /// </summary>
        public int MaxSizeInMegabytes
        {
            get { return this._maxSizeInMegabytes; }
            set { this._maxSizeInMegabytes = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. The name of the topic.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private bool _requiresDuplicateDetection;
        
        /// <summary>
        /// Optional. If enabled, the topic will detect duplicate messages
        /// within the time span specified by the
        /// DuplicateDetectionHistoryTimeWindow property. Settable only at
        /// topic creation time.* Default: false  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780749.aspx
        /// for more information)
        /// </summary>
        public bool RequiresDuplicateDetection
        {
            get { return this._requiresDuplicateDetection; }
            set { this._requiresDuplicateDetection = value; }
        }
        
        private int _sizeInBytes;
        
        /// <summary>
        /// Optional. Reflects the actual bytes toward the topic quota that
        /// messages in the topic currently occupy. (read-only)* Range: 0
        /// -MaxTopicSizeinMegaBytes  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780749.aspx
        /// for more information)
        /// </summary>
        public int SizeInBytes
        {
            get { return this._sizeInBytes; }
            set { this._sizeInBytes = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Gets or sets the current status of the topic (enabled or
        /// disabled). When a topic is disabled, that topic cannot send or
        /// receive messages.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780749.aspx
        /// for more information)
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private int _subscriptionCount;
        
        /// <summary>
        /// Optional. The current number of subscriptions to the topic.
        /// </summary>
        public int SubscriptionCount
        {
            get { return this._subscriptionCount; }
            set { this._subscriptionCount = value; }
        }
        
        private bool _supportOrdering;
        
        /// <summary>
        /// Optional. Gets or sets whether the topics can be ordered.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780749.aspx
        /// for more information)
        /// </summary>
        public bool SupportOrdering
        {
            get { return this._supportOrdering; }
            set { this._supportOrdering = value; }
        }
        
        private DateTime _updatedAt;
        
        /// <summary>
        /// Optional. The time the queue was last updated.
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ServiceBusTopic class.
        /// </summary>
        public ServiceBusTopic()
        {
            this.AuthorizationRules = new LazyList<ServiceBusSharedAccessAuthorizationRule>();
        }
    }
}
