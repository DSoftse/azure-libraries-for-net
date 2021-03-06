// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// IP security restriction on an app.
    /// </summary>
    public partial class IpSecurityRestriction
    {
        /// <summary>
        /// Initializes a new instance of the IpSecurityRestriction class.
        /// </summary>
        public IpSecurityRestriction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IpSecurityRestriction class.
        /// </summary>
        /// <param name="ipAddress">IP address the security restriction is
        /// valid for.
        /// It can be in form of pure ipv4 address (required SubnetMask
        /// property) or
        /// CIDR notation such as ipv4/mask (leading bit match). For CIDR,
        /// SubnetMask property must not be specified.</param>
        /// <param name="subnetMask">Subnet mask for the range of IP addresses
        /// the restriction is valid for.</param>
        /// <param name="vnetSubnetResourceId">Virtual network resource
        /// id</param>
        /// <param name="vnetTrafficTag">(internal) Vnet traffic tag</param>
        /// <param name="subnetTrafficTag">(internal) Subnet traffic
        /// tag</param>
        /// <param name="action">Allow or Deny access for this IP
        /// range.</param>
        /// <param name="tag">Defines what this IP filter will be used for.
        /// This is to support IP filtering on proxies. Possible values
        /// include: 'Default', 'XffProxy'</param>
        /// <param name="priority">Priority of IP restriction rule.</param>
        /// <param name="name">IP restriction rule name.</param>
        /// <param name="description">IP restriction rule description.</param>
        public IpSecurityRestriction(string ipAddress = default(string), string subnetMask = default(string), string vnetSubnetResourceId = default(string), int? vnetTrafficTag = default(int?), int? subnetTrafficTag = default(int?), string action = default(string), IpFilterTag? tag = default(IpFilterTag?), int? priority = default(int?), string name = default(string), string description = default(string))
        {
            IpAddress = ipAddress;
            SubnetMask = subnetMask;
            VnetSubnetResourceId = vnetSubnetResourceId;
            VnetTrafficTag = vnetTrafficTag;
            SubnetTrafficTag = subnetTrafficTag;
            Action = action;
            Tag = tag;
            Priority = priority;
            Name = name;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets IP address the security restriction is valid for.
        /// It can be in form of pure ipv4 address (required SubnetMask
        /// property) or
        /// CIDR notation such as ipv4/mask (leading bit match). For CIDR,
        /// SubnetMask property must not be specified.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets subnet mask for the range of IP addresses the
        /// restriction is valid for.
        /// </summary>
        [JsonProperty(PropertyName = "subnetMask")]
        public string SubnetMask { get; set; }

        /// <summary>
        /// Gets or sets virtual network resource id
        /// </summary>
        [JsonProperty(PropertyName = "vnetSubnetResourceId")]
        public string VnetSubnetResourceId { get; set; }

        /// <summary>
        /// Gets or sets (internal) Vnet traffic tag
        /// </summary>
        [JsonProperty(PropertyName = "vnetTrafficTag")]
        public int? VnetTrafficTag { get; set; }

        /// <summary>
        /// Gets or sets (internal) Subnet traffic tag
        /// </summary>
        [JsonProperty(PropertyName = "subnetTrafficTag")]
        public int? SubnetTrafficTag { get; set; }

        /// <summary>
        /// Gets or sets allow or Deny access for this IP range.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets defines what this IP filter will be used for. This is
        /// to support IP filtering on proxies. Possible values include:
        /// 'Default', 'XffProxy'
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public IpFilterTag? Tag { get; set; }

        /// <summary>
        /// Gets or sets priority of IP restriction rule.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets IP restriction rule name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets IP restriction rule description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
