// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MixedReality.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SpatialAnchorsAccount Response.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SpatialAnchorsAccount : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the SpatialAnchorsAccount class.
        /// </summary>
        public SpatialAnchorsAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SpatialAnchorsAccount class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="accountId">unique id of certain Spatial Anchors
        /// Account data contract.</param>
        /// <param name="accountDomain">Correspond domain name of certain
        /// Spatial Anchors Account</param>
        public SpatialAnchorsAccount(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string accountId = default(string), string accountDomain = default(string))
            : base(location, id, name, type, tags)
        {
            AccountId = accountId;
            AccountDomain = accountDomain;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets unique id of certain Spatial Anchors Account data contract.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountId")]
        public string AccountId { get; private set; }

        /// <summary>
        /// Gets correspond domain name of certain Spatial Anchors Account
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountDomain")]
        public string AccountDomain { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}