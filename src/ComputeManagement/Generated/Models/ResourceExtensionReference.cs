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
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Specifies the properties of a resource extension that should be
    /// installed on the Virtual Machine.
    /// </summary>
    public partial class ResourceExtensionReference
    {
        private string _name;
        
        /// <summary>
        /// Optional. Specifies the name of the resource extension. You can use
        /// List Resource Extensions to find the names of available resource
        /// extensions.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _publisher;
        
        /// <summary>
        /// Optional. Specifies the name of the publisher who created the
        /// resource extension. You can use List Resource Extensions to find
        /// the publisher name of a resource extension.
        /// </summary>
        public string Publisher
        {
            get { return this._publisher; }
            set { this._publisher = value; }
        }
        
        private string _referenceName;
        
        /// <summary>
        /// Optional. Specifies the reference name of the resource extension.
        /// </summary>
        public string ReferenceName
        {
            get { return this._referenceName; }
            set { this._referenceName = value; }
        }
        
        private IList<ResourceExtensionParameterValue> _resourceExtensionParameterValues;
        
        /// <summary>
        /// Optional. Contains a collection of parameters that are passed to
        /// the resource extension when it is installed.
        /// </summary>
        public IList<ResourceExtensionParameterValue> ResourceExtensionParameterValues
        {
            get
            {
                if (this._resourceExtensionParameterValues == null)
                {
                    this._resourceExtensionParameterValues = new System.Collections.Generic.List<Microsoft.WindowsAzure.Management.Compute.Models.ResourceExtensionParameterValue>();
                }
                return this._resourceExtensionParameterValues;
            }
            set { this._resourceExtensionParameterValues = value; }
        }
        
        /// <summary>
        /// Optional. Contains a collection of parameters that are passed to
        /// the resource extension when it is installed.
        /// </summary>
        public IList<ResourceExtensionParameterValue> ResourceExtensionParameterValuesValue
        {
            get { return this._resourceExtensionParameterValues; }
            set { this._resourceExtensionParameterValues = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Optional. Specifies the state of the resource extension.Possible
        /// values are: Enable | Disable. The default value is Enable.
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private string _version;
        
        /// <summary>
        /// Optional. Specifies the version of the resource extension. You can
        /// use List Resource Extension Versions to find the version of the
        /// resource extension.
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ResourceExtensionReference class.
        /// </summary>
        public ResourceExtensionReference()
        {
        }
    }
}
