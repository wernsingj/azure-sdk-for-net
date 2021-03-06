// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The identity information for the resource.
    /// </summary>
    public partial class IdentityInfo
    {
        /// <summary>
        /// Initializes a new instance of the IdentityInfo class.
        /// </summary>
        public IdentityInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IdentityInfo class.
        /// </summary>
        /// <param name="type">The type of managed identity used. The type
        /// 'SystemAssigned, UserAssigned' includes both an implicitly created
        /// identity and a set of user-assigned identities. The type 'None'
        /// will remove any identity. Possible values include: 'None',
        /// 'SystemAssigned', 'UserAssigned', 'SystemAssigned,
        /// UserAssigned'</param>
        /// <param name="principalId">The principal ID of resource
        /// identity.</param>
        /// <param name="tenantId">The tenant ID of resource.</param>
        /// <param name="userAssignedIdentities">The list of user identities
        /// associated with the resource. The user identity dictionary key
        /// references will be ARM resource ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// This property is currently not used and reserved for future
        /// usage.</param>
        public IdentityInfo(string type = default(string), string principalId = default(string), string tenantId = default(string), IDictionary<string, UserIdentityProperties> userAssignedIdentities = default(IDictionary<string, UserIdentityProperties>))
        {
            Type = type;
            PrincipalId = principalId;
            TenantId = tenantId;
            UserAssignedIdentities = userAssignedIdentities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of managed identity used. The type
        /// 'SystemAssigned, UserAssigned' includes both an implicitly created
        /// identity and a set of user-assigned identities. The type 'None'
        /// will remove any identity. Possible values include: 'None',
        /// 'SystemAssigned', 'UserAssigned', 'SystemAssigned, UserAssigned'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the principal ID of resource identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the tenant ID of resource.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets the list of user identities associated with the
        /// resource. The user identity dictionary key references will be ARM
        /// resource ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// This property is currently not used and reserved for future usage.
        /// </summary>
        [JsonProperty(PropertyName = "userAssignedIdentities")]
        public IDictionary<string, UserIdentityProperties> UserAssignedIdentities { get; set; }

    }
}
