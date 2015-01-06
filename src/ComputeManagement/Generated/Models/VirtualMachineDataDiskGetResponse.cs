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
using Microsoft.Azure;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// The Get Data Disk operation response.
    /// </summary>
    public partial class VirtualMachineDataDiskGetResponse : AzureOperationResponse
    {
        private string _hostCaching;
        
        /// <summary>
        /// Optional. The current value of the platform caching behavior of
        /// data disk blob for read/write efficiency. Possible values are:
        /// None, ReadOnly, or ReadWrite.
        /// </summary>
        public string HostCaching
        {
            get { return this._hostCaching; }
            set { this._hostCaching = value; }
        }
        
        private string _iOType;
        
        /// <summary>
        /// Optional. Gets or sets the IO type.
        /// </summary>
        public string IOType
        {
            get { return this._iOType; }
            set { this._iOType = value; }
        }
        
        private string _label;
        
        /// <summary>
        /// Optional. The description of the data disk.
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }
        
        private int _logicalDiskSizeInGB;
        
        /// <summary>
        /// Optional. The size, in GB, of the data disk.
        /// </summary>
        public int LogicalDiskSizeInGB
        {
            get { return this._logicalDiskSizeInGB; }
            set { this._logicalDiskSizeInGB = value; }
        }
        
        private int? _logicalUnitNumber;
        
        /// <summary>
        /// Optional. The Logical Unit Number (LUN) for the disk. The LUN
        /// specifies the slot in which the data drive appears when mounted
        /// for usage by the virtual machine.
        /// </summary>
        public int? LogicalUnitNumber
        {
            get { return this._logicalUnitNumber; }
            set { this._logicalUnitNumber = value; }
        }
        
        private Uri _mediaLinkUri;
        
        /// <summary>
        /// Optional. The location of the physical blob backing the data disk.
        /// The blob location is in the storage account in the subscription
        /// specified by the SubscriptionId value in the operation call.
        /// </summary>
        public Uri MediaLinkUri
        {
            get { return this._mediaLinkUri; }
            set { this._mediaLinkUri = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. The name of the data disk.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualMachineDataDiskGetResponse
        /// class.
        /// </summary>
        public VirtualMachineDataDiskGetResponse()
        {
        }
    }
}
