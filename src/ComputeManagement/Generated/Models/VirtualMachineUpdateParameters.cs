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
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Parameters supplied to the Update Virtual Machine operation.
    /// </summary>
    public partial class VirtualMachineUpdateParameters
    {
        private string _availabilitySetName;
        
        /// <summary>
        /// Optional. Specifies the name of an availability set to which to add
        /// the virtual machine. This value controls the virtual machine
        /// allocation in the Azure environment. Virtual machines specified in
        /// the same availability set are allocated to different nodes to
        /// maximize availability.
        /// </summary>
        public string AvailabilitySetName
        {
            get { return this._availabilitySetName; }
            set { this._availabilitySetName = value; }
        }
        
        private IList<ConfigurationSet> _configurationSets;
        
        /// <summary>
        /// Optional. Contains the collection of configuration sets that
        /// contain system and application configuration settings.
        /// </summary>
        public IList<ConfigurationSet> ConfigurationSets
        {
            get { return this._configurationSets; }
            set { this._configurationSets = value; }
        }
        
        private IList<DataVirtualHardDisk> _dataVirtualHardDisks;
        
        /// <summary>
        /// Optional. Contains the parameters Azure used to create the data
        /// disk for the virtual machine.
        /// </summary>
        public IList<DataVirtualHardDisk> DataVirtualHardDisks
        {
            get { return this._dataVirtualHardDisks; }
            set { this._dataVirtualHardDisks = value; }
        }
        
        private string _label;
        
        /// <summary>
        /// Optional. Specifies the friendly name for the virtual machine.
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }
        
        private OSVirtualHardDisk _oSVirtualHardDisk;
        
        /// <summary>
        /// Required. Contains the parameters Azure used to create the
        /// operating system disk for the virtual machine.
        /// </summary>
        public OSVirtualHardDisk OSVirtualHardDisk
        {
            get { return this._oSVirtualHardDisk; }
            set { this._oSVirtualHardDisk = value; }
        }
        
        private bool? _provisionGuestAgent;
        
        /// <summary>
        /// Optional. Indicates whether the WindowsAzureGuestAgent service is
        /// installed on the Virtual Machine. To run a resource extension in a
        /// Virtual Machine, this service must be installed.
        /// </summary>
        public bool? ProvisionGuestAgent
        {
            get { return this._provisionGuestAgent; }
            set { this._provisionGuestAgent = value; }
        }
        
        private IList<ResourceExtensionReference> _resourceExtensionReferences;
        
        /// <summary>
        /// Optional. Contains a collection of resource extensions that are to
        /// be installed on the Virtual Machine. This element is used if
        /// ProvisionGuestAgent is set to true.
        /// </summary>
        public IList<ResourceExtensionReference> ResourceExtensionReferences
        {
            get { return this._resourceExtensionReferences; }
            set { this._resourceExtensionReferences = value; }
        }
        
        private string _roleName;
        
        /// <summary>
        /// Required. Specifies the name for the virtual machine. The name must
        /// be unique within the deployment.
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }
        
        private string _roleSize;
        
        /// <summary>
        /// Optional. The size of the virtual machine.
        /// </summary>
        public string RoleSize
        {
            get { return this._roleSize; }
            set { this._roleSize = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualMachineUpdateParameters
        /// class.
        /// </summary>
        public VirtualMachineUpdateParameters()
        {
            this.ConfigurationSets = new LazyList<ConfigurationSet>();
            this.DataVirtualHardDisks = new LazyList<DataVirtualHardDisk>();
            this.ResourceExtensionReferences = new LazyList<ResourceExtensionReference>();
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualMachineUpdateParameters
        /// class with required arguments.
        /// </summary>
        public VirtualMachineUpdateParameters(string roleName, OSVirtualHardDisk oSVirtualHardDisk)
            : this()
        {
            if (roleName == null)
            {
                throw new ArgumentNullException("roleName");
            }
            if (oSVirtualHardDisk == null)
            {
                throw new ArgumentNullException("oSVirtualHardDisk");
            }
            this.RoleName = roleName;
            this.OSVirtualHardDisk = oSVirtualHardDisk;
        }
    }
}
