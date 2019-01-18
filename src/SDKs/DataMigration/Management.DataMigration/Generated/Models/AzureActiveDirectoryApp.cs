// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure Active Directory Application
    /// </summary>
    public partial class AzureActiveDirectoryApp
    {
        /// <summary>
        /// Initializes a new instance of the AzureActiveDirectoryApp class.
        /// </summary>
        public AzureActiveDirectoryApp()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureActiveDirectoryApp class.
        /// </summary>
        /// <param name="applicationId">Application ID of the Azure Active
        /// Directory Application</param>
        /// <param name="appKey">Key used to authenticate to the Azure Active
        /// Directory Application</param>
        /// <param name="tenantId">Tenant id of the customer</param>
        public AzureActiveDirectoryApp(string applicationId, string appKey, string tenantId)
        {
            ApplicationId = applicationId;
            AppKey = appKey;
            TenantId = tenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets application ID of the Azure Active Directory
        /// Application
        /// </summary>
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets key used to authenticate to the Azure Active Directory
        /// Application
        /// </summary>
        [JsonProperty(PropertyName = "appKey")]
        public string AppKey { get; set; }

        /// <summary>
        /// Gets or sets tenant id of the customer
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ApplicationId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApplicationId");
            }
            if (AppKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AppKey");
            }
            if (TenantId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TenantId");
            }
        }
    }
}